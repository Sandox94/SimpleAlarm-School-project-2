using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SQLCommunication
{
    //This enum is used to easily get the syntax of the alarmtype right.
    public enum AlarmtypesEnum { NoCharge, HighTemp, LowTemp, LowBattery, ComFault, Motion }

    //Class SQLCom takes care of every interaction between the C#-program and the SQLDatabase.
    //All methods are static, which means they can be invoked without having to create
    //an instance of SQLCom. 
    public class SQL
    {

        #region Fields
        private static string conString = @"Data Source=SIMEN-PC;Initial Catalog = Alarmsystem; 
                                Integrated Security = True";
        private static SqlConnection con;
        private static SqlCommand command;
        #endregion

        #region Methods
        //Adds a new subcriber in the database
        public static void AddSubscriber(Subscriber sub)
        {
            if (SubscriberExists(sub) == false)
            {
                try
                {
                    con.Open(); //Opening the connection to the database
                    command.CommandText = "NewSubscriber"; //Calling the stored procedure to add a new subscriber
                    command.Parameters.Clear(); //Clears the parameterlist
                    command.Parameters.Add(new SqlParameter("@Email", sub.Email)); //Further adding the parameters necessary for the procedure
                    command.Parameters.Add(new SqlParameter("@FirstName", sub.FirstName));
                    command.Parameters.Add(new SqlParameter("@LastName", sub.LastName));
                    command.Parameters.Add(new SqlParameter("@Telephone", sub.Telephone));
                    command.ExecuteNonQuery(); //Executing  
                }
                catch (Exception error) //if error occurs do:
                {
                    Console.WriteLine(error.Message);
                }
                finally
                {
                    con.Close(); //Closes the connection to database at either successful or unsuccessful method execution
                }
            }
        }

        //Updates a subscriber specified by the oldEmail parameter
        public static void UpdateSubscriber(Subscriber sub, string newEmail, string newFirstName, string newLastName, int newPhoneNumber)
        {
            if (SubscriberExists(sub))
            {
                try
                {
                    con.Open();
                    command.CommandText = "UpdateSubscriber";
                    command.Parameters.Clear();
                    command.Parameters.Add(new SqlParameter("@Email", sub.Email));
                    command.Parameters.Add(new SqlParameter("@NewEmail", newEmail));
                    command.Parameters.Add(new SqlParameter("@FirstName", newFirstName));
                    command.Parameters.Add(new SqlParameter("@LastName", newLastName));
                    command.Parameters.Add(new SqlParameter("@Telephone", newPhoneNumber));
                    command.ExecuteNonQuery();
                    sub.Email = newEmail;
                    sub.FirstName = newFirstName;
                    sub.LastName = newLastName;
                    sub.Telephone = newPhoneNumber;
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        //LogTemp inserts a double value in the temperature history
        public static void LogTemp(double temp)
        {
            try
            {
                con.Open();
                command.CommandText = "MeasureTemp";
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@Temperature", temp));
                command.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //NewAlarm inserts a alarm in the alarm history
        public static void NewAlarm(AlarmtypesEnum alarmtype)
        {
            try
            {
                con.Open();
                command.CommandText = "NewAlarm";
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@Alarm", alarmtype.ToString()));
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //UpdateAlarmLimit changes the alarm limits in the database
        public static void UpdateAlarmLimit(AlarmtypesEnum alarmtype, double newLimit)
        {
            try
            {

                con.Open();
                command.CommandText = "UpdateLimit";
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@AlarmType", alarmtype.ToString()));
                command.Parameters.Add(new SqlParameter("@NewLimit", newLimit));
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //GetLimit returns the alarm limit for a specific alarmtype as a double 
        public static double GetAlarmLimit(AlarmtypesEnum alarmtype)
        {
            try
            {
                con.Open();
                command.CommandText = "GetLimit";
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@AlarmType", alarmtype.ToString()));
                double result = ((double)command.ExecuteScalar());
                con.Close();
                return result;
            }
            catch (Exception)
            {
                //throw new NotImplementedException();
                return 0;
            }
            finally
            {
                con.Close();
            }
        }

        //GetDescription returns the description for a specified alarmtype as a string
        public static string GetDescription(AlarmtypesEnum alarmtype)
        {
            try
            {
                con.Open();
                command.CommandText = "GetDescription";
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@AlarmType", alarmtype.ToString()));
                string result = ((string)command.ExecuteScalar());
                return result;
            }
            catch (Exception error)
            {
                return "Failed to get description: \n" + error.Message;
            }
            finally
            {
                con.Close();
            }

        }

        //MakeDataGridView returns DataTable which can be used to fill a DataGridView.
        //Datatable contains data specified in the sqlQueryToFillTable, which means you have to pass
        //a valid sql query to invoke the method without errors
        public static DataTable MakeDataGridView(string sqlQueryToFillTable)
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlQueryToFillTable, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        //Removes a subscriber from the database
        public static void DeleteSubscriber(Subscriber sub)
        {
            try
            {
                con.Open();
                command.CommandText = "DeleteSubscriber";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Email", sub.Email);
                command.ExecuteScalar();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //This method adds a subscriber to an alarm, in other words, the specified subscriber will
        //get notifications when this type of alarms is raised
        public static void SubscribesTo(Subscriber sub, AlarmtypesEnum alarmtype)
        {
            try
            {
                con.Open();
                command.CommandText = "NewSubscribesTo";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Email", sub.Email);
                command.Parameters.AddWithValue("@Alarmtype", alarmtype.ToString());
                command.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //Unsubscribes a subscriber from email notifications for a given alarmtype
        public static void UnsubscribeTo(Subscriber sub, AlarmtypesEnum alarmtype)
        {
            try
            {
                con.Open();
                command.CommandText = "UnSubscribesTo";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Email", sub.Email);
                command.Parameters.AddWithValue("@Alarmtype", alarmtype.ToString());
                command.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //Checks if a subscriber already exists in the database
        public static bool SubscriberExists(Subscriber sub)
        {
            try
            {
                con.Open();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT EMAIL FROM SUBSCRIBER WHERE EMAIL = '" + sub.Email + "'";
                object test = command.ExecuteScalar();
                if (test != null)
                {
                    //MessageBox.Show("Bruker er allerede lagt til i databasen!");
                    //Console.WriteLine("Bruker er allerede lagt til i databasen!");
                    return true;
                }
                else return false;
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                return false;
            }
            finally
            {
                con.Close();
                command.CommandType = CommandType.StoredProcedure;
            }
        }

        //Gets a list of the alarms the subscribers subscribe to
        public static List<string> GetSubscriberAlarmList(Subscriber sub)
        {
            List<string> AlarmList = new List<string>();
            SqlDataReader rdr = null;
            try
            {
                con.Open();
                command.CommandType = CommandType.Text;
                command.CommandText = @"SELECT Alarm FROM SUBSCRIBESTO WHERE Email = '" + sub.Email + "'";
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    string alarm = rdr["Alarm"].ToString();
                    AlarmList.Add(alarm);
                }
                return AlarmList;

            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                return null;
            }
            finally
            {
                con.Close();
                command.CommandType = CommandType.StoredProcedure;
            }
        }

        public static List<string> GetEmailList(AlarmtypesEnum alarmtype)
        {
            List<string> EmailList = new List<string>();
            SqlDataReader rdr = null;
            try
            {
                con.Open();
                command.CommandType = CommandType.Text;
                command.CommandText = @"SELECT Email FROM SUBSCRIBESTO WHERE Alarm = '" + alarmtype + "'";
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    string Email = rdr["Email"].ToString();
                    EmailList.Add(Email);
                }
                return EmailList;

            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                return null;
            }
            finally
            {
                con.Close();
                command.CommandType = CommandType.StoredProcedure;
            }
        }

        public static List<string> GetFullEmailList()
        {
            List<string> EmailList = new List<string>();
            SqlDataReader rdr = null;
            try
            {
                con.Open();
                command.CommandType = CommandType.Text;
                command.CommandText = @"SELECT Email FROM SUBSCRIBER";
                rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    string email = rdr["Email"].ToString();
                    EmailList.Add(email);
                }
                return EmailList;

            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                return null;
            }
            finally
            {
                con.Close();
                command.CommandType = CommandType.StoredProcedure;
            }
        }

        #endregion

        public static string ConnectionString
        {
            get { return conString; }
            set
            {
                conString = value;
                con = new SqlConnection(conString); //initializes a new SQLConnection
                command = new SqlCommand()
                { Connection = con, CommandType = CommandType.StoredProcedure }; //initializes a new SQLCommand of type "Stored Procedure"
            }
        }
    }
}
    
