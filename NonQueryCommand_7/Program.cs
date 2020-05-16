using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NonQueryCommand_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"Data Source=DESKTOP-JL06NCI\SQLEXPRESS;Initial Catalog=Bank2020;Integrated Security=True;"; 

            SqlConnection connection = new SqlConnection(conStr); 
            connection.Open();

            // INSERT command

            SqlCommand insertCommand = connection.CreateCommand(); 
            insertCommand.CommandText = "INSERT Customers VALUES ('ed6fbe06-54b0-4k9c-acc4-0ba6c12f4c71', 'Naama', '77777',  '0544323456')";

            int rowAffected = insertCommand.ExecuteNonQuery(); 
            Console.WriteLine("INSERT command rows affected: " + rowAffected);


            // DELETE command

            SqlCommand deleteCommand = connection.CreateCommand(); 
            deleteCommand.CommandText = "DELETE Debitors WHERE PostNumber = '888888'";

            rowAffected = deleteCommand.ExecuteNonQuery(); 
            Console.WriteLine("DELETE command rows affected: " + rowAffected);

            connection.Close();
        }
    }
}
