using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;

namespace PackageCommand_10
{
    class Program
    {
        public static void WriteReaderData(DbDataReader reader)
        {
            while (reader.Read())                      
            {
                for (int i = 0; i < reader.FieldCount; i++)
                    Console.WriteLine(reader.GetName(i) + ": " + reader[i]);
                Console.WriteLine(new string('_', 20));
            }
        }
        static void Main(string[] args)
        {
            string conStr = @"Data Source=DESKTOP-JL06NCI\SQLEXPRESS; Initial Catalog=Bank2020; Integrated Security=True";

            SqlConnection connection = new SqlConnection(conStr); 
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Credits WHERE Amount > 1000000; SELECT * FROM Payments WHERE Amount < 50000;", connection);  

            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("Press any key to see data taking Credits more than 1000000 dollars");
            Console.ReadKey();

            WriteReaderData(reader);  

            Console.WriteLine("Press any key to see data Payments less  than 50000 dollars");
            Console.ReadKey();

            reader.NextResult();      

            WriteReaderData(reader); 

            connection.Close();
            reader.Close();         
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}
