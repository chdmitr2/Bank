using System;
using System.Data.SqlClient;

namespace ConnectionUsing_2
{
    class Program
    {

            static void connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
            {
                SqlConnection connection = sender as SqlConnection;

                Console.WriteLine();

                Console.WriteLine                 
                    (
                    "Connection to" + Environment.NewLine +
                    "Data Source: " + connection.DataSource + Environment.NewLine +
                    "Database: " + connection.Database + Environment.NewLine +
                    "State: " + connection.State
                    );
            }

        static void Main(string[] args)
        {
            string conStr = @"Data Source=DESKTOP-JL06NCI\SQLEXPRESS; DataBase=Bank2020; Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(conStr))

            {
                connection.StateChange += connection_StateChange;

                try
                {
                    connection.Open();
                  //  throw new Exception("error");
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            } // connection.Dispose();

            Console.ReadLine();
        }    
    }
}
