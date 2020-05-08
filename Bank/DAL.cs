using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;

namespace Bank
{
    class DAL
    {
        //Connectig String
        string connectionString = @"Data Source=DESKTOP-JL06NCI\SQLEXPRESS;Initial Catalog=Bank2020;Integrated Security=True;";

        //Take from DB all debitors
        public ArrayList GetAllDebitors()
        {
            ArrayList allDebitors = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))//using - Dispose
            {
                SqlCommand com = new SqlCommand("SELECT * FROM Debitors Order By Name Desc", con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();//(System.Data.CommandBehavior.CloseConnection)
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allDebitors.Add(result);
                    //con.Close();con.Dispose();
                }
                catch
                {

                }
            }
            return allDebitors;
        }

        //Take from DB all credits
        internal object GetAllCreditsForDebitor(string debitorID)
        {
            ArrayList allCredits = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))//using - Dispose
            {
                string query = String.Format("SELECT * FROM Credits Where DebitorID = '{0}' Order By OpenDate", debitorID);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();//(System.Data.CommandBehavior.CloseConnection)
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allCredits.Add(result);
                    //con.Close();con.Dispose();
                }
                catch
                {

                }

            }
            return allCredits;
        }

        //Take from DB all payments
        internal ArrayList GetAllPaymentsForCredit(string creditId)
        {
            ArrayList allPayments = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))//using - Dispose
            {
                string query = String.Format("SELECT * FROM Payments Where CreditsID = '{0}' Order By PaymantDate", creditId);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();//(System.Data.CommandBehavior.CloseConnection)
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allPayments.Add(result);
                    //con.Close();con.Dispose();
                }
                catch
                {

                }

            }
            return allPayments;
        }

        //Create new Debitor and save him in DB
        public bool SaveNewDebitor(string Id,string Name,string PostNumber,string PhoneNumber)
        {
            bool flagResult = false;
            String query = String.Format("INSERT INTO Debitors " +
                "([Id],[Name],[PostNumber],[PhoneNumber]) VALUES ('{0}','{1}','{2}','{3}')",
                Id,Name,PostNumber,(PhoneNumber != String.Empty) ? PhoneNumber : null);

            using (SqlConnection con = new SqlConnection(connectionString))//using - Dispose
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if(com.ExecuteNonQuery() == 1);
                    flagResult = true;

        
                }
                catch
                {

                }

            }
            return flagResult;
        }


    }

}

    
