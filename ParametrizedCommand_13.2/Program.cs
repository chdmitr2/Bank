using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ParametrizedCommand_13._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var conStr = @"Data Source=DESKTOP-JL06NCI\SQLEXPRESS; DataBase=Bank2020; Integrated Security=True";

            var commandStr = "SELECT * FROM Debitors WHERE PostNumber = @PostNumber;"; 

            Console.WriteLine("Enter Post Number Of Debitor Please : ");
            var customerNo = Console.ReadLine(); 

            SqlConnection connection = new SqlConnection(conStr); 
            SqlCommand cmd = new SqlCommand(commandStr, connection);

            cmd.Parameters.AddWithValue("PostNumber", customerNo);   
            connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                    Console.WriteLine("{0}: {1}", reader.GetName(i), reader[i]);

                Console.WriteLine(new string('-', 20));
            }

            reader.Close();
            connection.Close();
            Console.ReadLine();
        }
    }
}
