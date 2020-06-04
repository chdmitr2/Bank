using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ScalarCommand_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"Data Source=DESKTOP-JL06NCI\SQLEXPRESS; Initial Catalog=Bank2020; Integrated Security=True;"; 
            SqlConnection connection = new SqlConnection(conStr);
            connection.Open(); 

            SqlCommand cmd = new SqlCommand("SELECT PhoneNumber FROM Debitors WHERE Name = 'Dima'", connection); 

            var phoneNumber = cmd.ExecuteScalar(); 

            Console.WriteLine(phoneNumber);
            Console.ReadLine();
        }
    }
}
