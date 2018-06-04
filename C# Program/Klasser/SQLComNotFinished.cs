using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;

namespace SQLCommunication
{
    public enum Alarmtypes { NoCharge, HighTemp, LowTemp, LowBattery, ComFault }

    public class SQLCom
    {
        #region Fields
        private static string conString;
        private static SqlConnection con;
        private static SqlCommand command;
        private static string databaseName = "Alarmsystem";
        #endregion

        #region Methods
        //De fleste metodene kaller en stored procedure i sql, derfor er dette spesifisert i feltet command 

        static public void Init()
        {
            SuccessfullLogin = false;
            DatabaseExist = false;
            conString = string.Format("Data Source={0};Initial Catalog=master;Integrated Security=True", DataSource); //Connection string til databasen

            try
            {
                con = new SqlConnection(conString); //initialiserer en ny sql-kobling
                con.Open();
                SuccessfullLogin = true;
                con.ChangeDatabase(databaseName);
                DatabaseExist = true;
                command = new SqlCommand() { Connection = con, CommandType = CommandType.StoredProcedure }; //initialiserer en ny sql-kommando
            }
            catch (Exception error)
            {
                if (error.Message.Contains("error: 26") || error.Message.Contains("error: 40"))
                {
                    SuccessfullLogin = false;
                    //MessageBox.Show("Feil innloggingsinformasjon");
                }
                else if (error.Message.Contains("'Alarmsystem' does not exist"))
                {
                    DatabaseExist = false;
                    //MessageBox.Show("Databasen eksisterer ikke. Vil du opprette databasen Alarmsystem?", "Feil", MessageBoxButtons.YesNo);
                }
                else
                {
                    MessageBox.Show(error.Message);
                }
            }
            finally
            {
                con.Close();
            }
        }

        static public void CreateDatabase()
        {
            try
            {
                Process sqlCreateDatabaseScript = new Process();
                sqlCreateDatabaseScript.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                sqlCreateDatabaseScript.StartInfo.FileName = "SQLCMD.EXE";
                sqlCreateDatabaseScript.StartInfo.Arguments = string.Format("-S {0} -E -w 166 -e -i Database\\CreateDatabase.sql -o Database\\CreateDatabase.log", DataSource);
                sqlCreateDatabaseScript.Start();
                DatabaseExist = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        /// <summary>
        /// Her legges det inn en ny abonnent i databasen.
        /// </summary>
        public static void NewSubscriber(Subscriber sub)
        {
            try
            {
                con = new SqlConnection(conString);
                con.Open(); // Åpner kobling mot databasen
                con.ChangeDatabase(databaseName);
                command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "NewSubscriber"; //Kaller stored procedure
                command.Parameters.Add(new SqlParameter("@Email", sub.Email)); //Videre legges det inn parameterne som må være med i SP
                command.Parameters.Add(new SqlParameter("@FirstName", sub.FirstName));
                command.Parameters.Add(new SqlParameter("@LastName", sub.LastName));
                command.Parameters.Add(new SqlParameter("@Telephone", sub.Telephone));
                command.ExecuteNonQuery(); //Utfører spørring
                MessageBox.Show("Bruker lagt til");  
            }
            catch (Exception error)
            {
                MessageBox.Show((error.Message));
            }
            finally
            {
                con.Close(); // Lukker kobling mot databasen
            }
        }
        /// <summary>
        /// LogTemp lagrer en ny måleverdi for temperatur i databasen.
        /// </summary>
        public static void LogTemp(double temp) 
        {
            try
            {
                con.Open();
                command.CommandText = "MeasureTemp";
                command.Parameters.Add(new SqlParameter("@Temperature", temp));
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

        }

        /// <summary>
        /// NewAlarm lagrer en ny alarm i databasen.
        /// </summary>
        public static void NewAlarm(string alarmtype)
        {
            try
            {
                con.Open();
                command.CommandText = "NewAlarm";
                command.Parameters.Add(new SqlParameter("@Alarm", alarmtype));
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
        /// <summary>
        /// UpdateAlarmLimit endrer alarmgrensene i databasen.
        /// Bruk enum Alarmtype og velg hvilken alarm du vil oppdatere som parameter.
        /// </summary>
        public static void UpdateAlarmLimit(Enum alarmtype, string newLimit)
        {
            try
            {
                con = new SqlConnection(conString);
                con.Open();
                con.ChangeDatabase(databaseName);
                command = new SqlCommand("UpdateLimit", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@AlarmType", alarmtype.ToString()));
                command.Parameters.Add(new SqlParameter("@NewLimit", newLimit));
                command.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Feil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();

            }
        }

        /// <summary>
        /// GetLimit returnerer alarmgrensene til en angitt alarmtype som en string.
        /// Bruk enum Alarmtype og velg hvilken alarm du vil ha returnert som parameter.
        /// </summary>
        public static double GetAlarmLimit(Enum alarmtype)
        {
            try
            {
                con.Open();
                command.CommandText = "GetLimit";
                command.Parameters.Add(new SqlParameter("@AlarmType", alarmtype.ToString()));
                double result = ((double)command.ExecuteScalar());
                con.Close();
                return result;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
        /// <summary>
        /// GetDescription returnerer beskrivelsen på angitt alarmtype som en string.
        /// Bruk enum Alarmtype og velg hvilken alarm du vil ha returnert som parameter.
        /// </summary>
        public static string GetDescription(Enum alarmtype)
        {
            try
            {
                con.Open();
                command.CommandText = "GetDescription";
                command.Parameters.Add(new SqlParameter("@AlarmType", alarmtype.ToString()));
                string result = ((string)command.ExecuteScalar());
                con.Close();
                return result;
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }

        /// <summary>
        /// MakeDataGridView returnerer datatable. Dette kan bruke til å fylle DataGridView.
        /// Data som returneres angis av spørringen som sendes med som parameter "sqlQueryToFillTable".
        /// </summary>
        public static DataTable MakeDataGridView(string sqlQueryToFillTable)
        {
            try
            {
                con = new SqlConnection(conString);
                con.Open();
                con.ChangeDatabase(databaseName);
                SqlDataAdapter sda = new SqlDataAdapter(sqlQueryToFillTable, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Feil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region Properties
        //Egenskap for å kunne se og endre connectionstringen i klassen. 
        static public string ConnectionString
        {
            get { return conString; }
            set { conString = value; }
        }
        static public bool SuccessfullLogin { get; set; }
        static public bool DatabaseExist { get; set; }
        static public string DataSource { get; set; }
        #endregion
    }

}
