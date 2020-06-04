using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dirty_Read_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"Data Source=DESKTOP-JL06NCI\SQLEXPRESS; DataBase=Bank2020; Integrated Security=True";

            SqlConnection connection = new SqlConnection(conStr);

            SqlCommand cmd = new SqlCommand("UPDATE Debitors SET PhoneNumber = 'TEST' WHERE Name = 'Dima'", connection);
           // cmd = new SqlCommand("UPDATE Debitors SET PhoneNumber = '0555456654' WHERE Name = 'Dima'", connection);

            Console.WriteLine("Step 1. Press any key to execute command...");
            Console.ReadKey();

            connection.Open();

            cmd.Transaction = connection.BeginTransaction();
            cmd.ExecuteNonQuery();

            Console.WriteLine("Step 3. Press any key to rollback transaction...");
            Console.ReadKey();

            cmd.Transaction.Rollback();
            connection.Close();

            Console.WriteLine("Transaction rollback");
            Console.ReadLine();

        }
    }
}
