using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ParametrizedCommand_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"Data Source=DESKTOP-JL06NCI\SQLEXPRESS; DataBase=Bank2020; Integrated Security=True";

            Console.WriteLine("Enter PostNumber of Debitor please : ");

            var DebPostNum = Console.ReadLine();

          
            string commandStr = string.Format("SELECT * FROM Debitors WHERE PostNumber = {0};", DebPostNum); 

            using (SqlConnection connection = new SqlConnection(conStr)) 
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(commandStr, connection);

                using (SqlDataReader reader = cmd.ExecuteReader()) 
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                            Console.WriteLine("{0}: {1}", reader.GetName(i), reader[i]);
                        Console.WriteLine(new string('-', 20));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
