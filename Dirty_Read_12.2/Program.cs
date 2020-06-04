using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Dirty_Read_12._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"Data Source=DESKTOP-JL06NCI\SQLEXPRESS; DataBase=Bank2020; Integrated Security=True";

            SqlConnection connection = new SqlConnection(conStr);

            SqlCommand cmd = new SqlCommand("SELECT Name, PhoneNumber FROM Debitors", connection);

            Console.WriteLine("Step 2. Press any key to read Debitors");
            Console.ReadKey();

            connection.Open();
            cmd.Transaction = connection.BeginTransaction(IsolationLevel.ReadUncommitted);//ReadCommitted  ReadUncommitted
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine("{0} : {1}", reader[0], reader[1]);
            }

            connection.Close();
            Console.ReadLine();
        }
    }
}
