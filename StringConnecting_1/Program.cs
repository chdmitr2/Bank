using System;
using System.Data.SqlClient;

namespace StringConnecting_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"Data Source=DESKTOP-JL06NCI\SQLEXPRESS; Initial Catalog=Bank2020; Integrated Security=True";
            //string conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Bank2020; Integrated Security=True";              
            // string conStr = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Bank2020; Integrated Security=True"; 
            // string conStr = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Bank2020; Integrated Security=True"; 

            SqlConnection connection = new SqlConnection(conStr);

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
