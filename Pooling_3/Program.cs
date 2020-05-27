using System;
using System.Data.SqlClient;

namespace Pooling_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"Data Source=DESKTOP-JL06NCI\SQLEXPRESS;Initial Catalog=Bank2020; Integrated Security=true; Pooling=true"; 

            DateTime start = DateTime.Now;

            for (int i = 0; i < 1000; i++)
            {
                SqlConnection connection = new SqlConnection(conStr);
                connection.Open();    
                connection.Close();   
            }

            TimeSpan stop = DateTime.Now - start;

            Console.WriteLine(stop.TotalSeconds);
            Console.ReadLine();
        }
    }
}
