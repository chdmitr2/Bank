using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Globalization;


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
        internal ArrayList  GetAllCreditsForDebitor(string debitorID)
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

            using (SqlConnection con = new SqlConnection(connectionString))
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

        internal bool SaveNewPayment(Guid Id , Guid CreditId, decimal PaymentAmount, DateTime DateTime)
        {
            bool flag = true;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlTransaction sqlTransact = con.BeginTransaction();
                SqlCommand com = con.CreateCommand();
                com.Transaction = sqlTransact;
                try
                {
                    string PayAmount = PaymentAmount.ToString(CultureInfo.InvariantCulture.NumberFormat);
                    string query = string.Format("INSERT INTO Payments (Id,CreditsId,Amount,PaymentDate) VALUES" +
                       "('{0}','{1}','{2}','{3}')",Id,CreditId,PayAmount, DateTime);
                    com.CommandText = query;
                    com.ExecuteNonQuery();
                    query = string.Format("UPDATE Credits SET Balance = (Balance - {0}) WHERE Id = '{1}'",PayAmount,CreditId);
                    com.CommandText = query;
                    com.ExecuteNonQuery();
                    sqlTransact.Commit();


                }
                catch(Exception )
                {
                    sqlTransact.Rollback();
                    flag = false;
                }
                finally
                {
                    if (con.State == System.Data.ConnectionState.Open)
                        con.Dispose();
                }

            }
            return flag;
        }

        //Create new Credit and save him in DB
        public bool SaveNewCredit(Guid Id,Guid debitorId,int amount, int balance,DateTime openDate)
        {
            string query = String.Format("INSERT INTO Credits (Id,debitorId,Amount,Balance,OpenDate)" +
                "VALUES ( '{0}','{1}','{2}','{3}','{4}')",Id, debitorId, amount, balance, openDate);
            bool flagResult = false;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1) ;
                    flagResult = true;


                }
                catch(Exception)
                {

                }

            }
            return flagResult;
        }
    }

}

    
