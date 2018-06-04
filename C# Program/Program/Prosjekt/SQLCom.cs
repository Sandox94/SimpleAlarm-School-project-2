using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SQLCommunication;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SQLCommunication
{
    class SQLCom
    {
        private static string conString;
        private static string databaseName = "Alarmsystem";
        private static string dataSource;
        private static string databaseSuccessfullyCreatedString = "Opprettelse av database vellykket";
        private static string errorString;
        private static string logFile = @"Database\CreateDatabase.log";
        private static bool autoConnecting= false;
        private static bool successfulLogin = false;
        private static bool databaseExist = false;
        private static bool databaseSuccessfullyCreated = false;
        private static SqlConnection con;
        private static SqlCommand command;

        public static bool AutoConnect()
        {
            autoConnecting = true;
            dataSource = System.Environment.MachineName;
            StartCom(dataSource);

            if (successfulLogin == true)
            {
                autoConnecting = false;
                return successfulLogin;
            }
            else if (successfulLogin == false)
            {
                dataSource = @".\SQLEXPRESS";
                StartCom(dataSource);
                autoConnecting = false;
                return successfulLogin;
            }
            else
            {
                errorString = "En feil oppstod, kontakt programutvikler!";
                MessageBox.Show(errorString, "Feil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                autoConnecting = false;
                return successfulLogin;
            }
        }

        public static void StartCom (string serverName)
        {
            try
            {
                conString = string.Format("Data Source ={0}; Initial Catalog = master; Integrated Security = True; Connection Timeout=5", serverName);
                con = new SqlConnection(conString);
                con.Open();
                successfulLogin = true;
                dataSource = serverName;
                con.ChangeDatabase(databaseName);
                con.Close();
                conString = string.Format("Data Source ={0}; Initial Catalog ={1}; Integrated Security = True; Connection Timeout=5", dataSource, databaseName);
                databaseExist = true;

            }
            catch (Exception error)
            {
                //Don't display errormessage on autologin
                if (autoConnecting == true && error.Message.Contains("'Alarmsystem' does not exist"))
                {
                    CreateDatabase();
                }
                else if (error.Message.Contains("error: 26") || error.Message.Contains("error: 40") && autoConnecting == false)
                {
                    errorString = "Feil servernavn";
                    MessageBox.Show(errorString);
                }
                // Create database if it doesn't exist
                else if (error.Message.Contains("'Alarmsystem' does not exist"))
                {
                    errorString = "Databasen eksisterer ikke";
                    CreateDatabase();
                    MessageBox.Show("Databasen eksisterer ikke.", "Feil", MessageBoxButtons.OK);
                }
                else if (autoConnecting == true)
                {
                    //Don't display errormessage on autologin
                }

                else
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        /// <summary>
        /// Uses SQLCMD.exe to create database from sql file. Search for error-messages in log file afterwars and determines
        /// if it was successfully created
        /// </summary>
        static private void CreateDatabase()
        {
            errorString = "Error on creating database. Please do it manually.";
            try
            {
                Process sqlCreateDatabaseScript = new Process();
                sqlCreateDatabaseScript.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                sqlCreateDatabaseScript.StartInfo.FileName = "SQLCMD.EXE";
                sqlCreateDatabaseScript.StartInfo.Arguments = string.Format("-S {0} -E -w 166 -e -i Database\\CreateDatabase.sql -o Database\\CreateDatabase.log", dataSource);
                sqlCreateDatabaseScript.Start();
                if (File.Exists(logFile))
                {
                    StreamReader file = new StreamReader(logFile, true);
                    string fileContent = file.ReadToEnd();
                    if (fileContent.Contains(string.Format("Changed database context to '{0}'", databaseName)))
                    {
                        databaseExist = true;
                        if (fileContent.Contains("error") || fileContent.Contains("Error") || fileContent.Contains("unknown") || fileContent.Contains("Unknown"))
                        {
                            databaseSuccessfullyCreated = false;
                        }
                        else
                        {
                            databaseSuccessfullyCreated = true;
                            MessageBox.Show((databaseSuccessfullyCreatedString));
                        }
                    }
                }
                if (databaseExist == true && databaseSuccessfullyCreated == false)
                {
                    try
                    {
                        command = new SqlCommand(conString, con);
                        command.CommandText = string.Format("DROP DATABASE {0}", databaseName);
                        command.ExecuteNonQuery();
                        databaseExist = false;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(errorString);
                        //Console.WriteLine(errorString);
                    }
                }
                if (databaseExist == false || databaseSuccessfullyCreated == false)
                {
                    MessageBox.Show(errorString);
                    //Console.WriteLine(errorString);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                //Console.WriteLine(error.Message);
            }
        }

        #region Properties
        public static bool DatabaseExist
        {
            get { return databaseExist; }
        }
        public static bool SuccessfullLogin
        {
            get { return successfulLogin; }
        }
        public static string DatabaseName
        {
            get { return databaseName; }
        }
        public static string ConnectionString
        {
            get { return conString; }
            set { conString = value; }
        }
        public static string ServerName
        {
            get { return dataSource; }
        }
        #endregion 
    }
}