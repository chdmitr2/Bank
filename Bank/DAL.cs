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

        internal object GetAllCreditsForDebitor(string debitorID)
        {
            ArrayList allCredits = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))//using - Dispose
            {
                string query = String.Format("SELECT * FROM Credits Where DebitorID = '{0}'", debitorID);
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
    }   }
}

    
