using System;
using System.Data.SqlClient;

namespace Transaction_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"Data Source=DESKTOP-JL06NCI\SQLEXPRESS; Initial Catalog=Bank2020; Integrated Security=True";  

            SqlConnection connection = new SqlConnection(conStr);

            SqlCommand cmd = new SqlCommand("UPDATE Debitors SET PhoneNumber = 'TEST' WHERE Name = 'Dima'", connection);
            //cmd = new SqlCommand("UPDATE Debitors SET PhoneNumber = '0555456654' WHERE Name = 'Dima'", connection);

            try
            {
                connection.Open();

                cmd.Transaction = connection.BeginTransaction();
                cmd.ExecuteNonQuery();

               //throw new Exception();

                cmd.Transaction.Commit();

                Console.WriteLine("Transaction commited");
            }
            catch (Exception)
            {
                cmd.Transaction.Rollback();
                Console.WriteLine("Transaction rollback");
            }
            Console.ReadLine();
        }
    }
}
