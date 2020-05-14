using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace App.Config_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var setting = new ConnectionStringSettings
            {
                Name = "MyConnectionString1",     
                ConnectionString = @"Data Source=DESKTOP-JL06NCI\SQLEXPRESS;
                                     Initial Catalog=Bank2020;
                                     Integrated Security=True;"
            };

            Configuration config;  
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);  
            config.ConnectionStrings.ConnectionStrings.Add(setting);
            config.Save();

            Console.WriteLine("Connection string in configuration file");

            Console.WriteLine(ConfigurationManager.ConnectionStrings["MyConnectionString1"].ConnectionString);
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString1"].ConnectionString);
            try
            {
                connection.Open();
                Console.WriteLine(connection.State);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
                Console.WriteLine(connection.State);
            }
            Console.ReadLine();
        }
    }
}
