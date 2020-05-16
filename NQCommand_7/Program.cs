using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace NQCommand_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"Data Source=DESKTOP-JL06NCI\SQLEXPRESS;Initial Catalog=Bank2020;Integrated Security=True;"; 

            SqlConnection connection = new SqlConnection(conStr); 
            connection.Open();

            // DELETE command

            SqlCommand deleteCommand = connection.CreateCommand(); 
            deleteCommand.CommandText = "DELETE Debitors WHERE PostNumber = '77777'";

            int rowAffected = deleteCommand.ExecuteNonQuery(); 
            Console.WriteLine("DELETE command rows affected: " + rowAffected);

            connection.Close();
            Console.ReadLine();
          
        }
    }
}
