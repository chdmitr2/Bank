using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Globalization;
using System.IO;


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
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("SELECT * FROM Debitors Order By Name Asc", con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allDebitors.Add(result);
                    
                }
                catch
                {

                }
            }
            return allDebitors;
        }

        //Searching Debitor
       internal ArrayList SearchDebitors(string DebName,string DebPostNumber,string DebPhoneNumber)
        {
            ArrayList SearchedDebitors = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand("[dbo].[SearchDebitor]", con);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@DebName";
                param.Value = DebName;
                param.SqlDbType = System.Data.SqlDbType.NVarChar;
                param.Direction = System.Data.ParameterDirection.Input;
                com.Parameters.Add(param);

               
                param = new SqlParameter();
                param.ParameterName = "@DebPostNumber";
                param.Value = DebPostNumber;
                param.SqlDbType = System.Data.SqlDbType.NVarChar;
                param.Direction = System.Data.ParameterDirection.Input;
                com.Parameters.Add(param);

                
                param = new SqlParameter();
                param.ParameterName = "@DebPhoneNumber";
                param.Value = DebPhoneNumber;
                param.SqlDbType = System.Data.SqlDbType.NVarChar;
                param.Direction = System.Data.ParameterDirection.Input;
                com.Parameters.Add(param);


                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            SearchedDebitors.Add(result);
                }
                catch
                {

                }

            }
            return SearchedDebitors;
        }
    
        //Take from DB all credits
        internal ArrayList  GetAllCreditsForDebitor(string DebitorID)
        {
            ArrayList allCredits = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                
                SqlCommand com = new SqlCommand("[dbo].[Procedure]",con);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@DebitorID";
                param.Value = new Guid(DebitorID);
                param.SqlDbType = System.Data.SqlDbType.UniqueIdentifier;
                param.Direction = System.Data.ParameterDirection.Input;
                com.Parameters.Add(param);


                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allCredits.Add(result);
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

        //Create new Debitor and save in DB
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
        //Create new Payment and save in DB - Transaction 
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
                    string query = string.Format("INSERT INTO Payments (Id,CreditsID,Amount,PaymantDate) VALUES" +
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
        //Save File csv
        internal bool SaveDBToLocalFile()
        {
            bool result = true;
            StreamWriter file;
            
            string query;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
              
                try
                {
                    file = new StreamWriter(new FileStream("Debitors.csv", FileMode.Create), Encoding.GetEncoding(1251) ); 
                    query = "SELECT * FROM Debitors";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = com.ExecuteReader();
                    file.WriteLine("Start of file");
                    file.WriteLine(@"""Id"";""Name"";""PostNumber"";""PhoneNumber""");
                    if(reader.HasRows )
                    {
                        while(reader.Read())
                        {
                            file.WriteLine(@"""" + reader[0].ToString() + @""";""" +
                               reader[1].ToString() + @""";""" +
                               reader[2].ToString() + @""";""" +
                               reader[3].ToString() + @"""", Encoding.ASCII);
                        }
                    }

                    else
                    {
                        file.WriteLine("No one row to save");
                    }

                    file.WriteLine("End of file");
                    result = true;

                    file.Dispose();

                }
                catch (Exception)
                {
                    result = false;
                    return result;
                }

            }
           
      
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                try
                {
                    file = new StreamWriter(new FileStream("Credits.csv", FileMode.Create), Encoding.GetEncoding(1251));
                    query = "SELECT * FROM Credits";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = com.ExecuteReader();
                    file.WriteLine("Start of file");
                    file.WriteLine(@"""Id"";""DebitorID"";""Amount"";""Balance"";""OpenDate""");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            file.WriteLine(@"""" + reader[0].ToString() + @""";""" +
                                reader[1].ToString() + @""";""" + 
                                reader[2].ToString() + @""";""" +
                                reader[3].ToString() + @""";""" +
                                reader[4].ToString() + @"""", Encoding.ASCII);
                        }
                    }

                    else
                    {
                        file.WriteLine("No one row to save");
                    }

                    file.WriteLine("End of file");
                    result = true;

                    file.Dispose();

                }
                catch (Exception)
                {
                    result = false;
                    return result;
                }

            }
           

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                try
                {
                    file = new StreamWriter(new FileStream("Payments.csv", FileMode.Create), Encoding.GetEncoding(1251));
                    query = "SELECT * FROM Payments";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = com.ExecuteReader();
                    file.WriteLine("Start of file");
                    file.WriteLine(@"""Id"";""CreditsID"";""Amount"";""PaymentDate""");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            file.WriteLine(@"""" + reader[0].ToString() + @""";""" +
                                reader[1].ToString() + @""";""" +
                                reader[2].ToString() + @""";""" +
                                reader[3].ToString() + @"""", Encoding.ASCII);
                        }
                    }

                    else
                    {
                        file.WriteLine("No one row to save");
                    }

                    file.WriteLine("End of file");
                    result = true;

                    file.Dispose();

                }
                catch (Exception)
                {
                    result = false;
                    return result;
                }

            }
            return result;

        }

        //Create new Credit and save him in DB 
        public bool SaveNewCredit(Guid Id,Guid DebitorID,int Amount, int Balance,DateTime OpenDate)
        {
            string query = String.Format("INSERT INTO Credits (Id,DebitorID,Amount,Balance,OpenDate)" +
                "VALUES ( @Id,@DebitorID,@Amount,@Balance,@OpenDate)");
            bool flagResult = false;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Id";
                param.Value = Id;
                param.SqlDbType = System.Data.SqlDbType.UniqueIdentifier;
                com.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@DebitorID";
                param.Value = DebitorID;
                param.SqlDbType = System.Data.SqlDbType.UniqueIdentifier;
                com.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Amount";
                param.Value = Amount;
                param.SqlDbType = System.Data.SqlDbType.Money;
                com.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Balance";
                param.Value = Balance;
                param.SqlDbType = System.Data.SqlDbType.Money;
                com.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@OpenDate";
                param.Value = OpenDate;
                param.SqlDbType = System.Data.SqlDbType.DateTime ;
                com.Parameters.Add(param);

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

    
