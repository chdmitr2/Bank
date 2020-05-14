using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;

namespace DataProviderFactory_5
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
            // Get Connection string/provider from *.config.
            Console.WriteLine("***** Fun with Data Provider Factories *****\n");
            string dp =
              ConfigurationManager.AppSettings["provider"];
            string cnStr =
              ConfigurationManager.AppSettings["cnStr"];

            // Get the factory provider.
            System.Data.Common.DbProviderFactory df = DbProviderFactories.GetFactory(dp);

           
            // Now make connection object.
            using (DbConnection cn = df.CreateConnection())
            {
                cn.ConnectionString = cnStr;
                cn.StateChange += connection_StateChange;

                try
                {

                    cn.Open();
                   
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
