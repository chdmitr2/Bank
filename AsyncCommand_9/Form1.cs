using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AsyncCommand_9
{
    public partial class Form1 : Form
    {
        string conStr = @"Data Source=DESKTOP-JL06NCI\SQLEXPRESS; DataBase=Bank2020; Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void getDataButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();      

                SqlCommand cmd = new SqlCommand("WAITFOR DELAY '00:00:10'", connection); 

                cmd.ExecuteNonQuery();
                MessageBox.Show("Simple command executed");
            }

        }

        async private void getdataAsyncButtom_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                await connection.OpenAsync();  

                SqlCommand cmd = new SqlCommand("WAITFOR DELAY '00:00:10'", connection); 

                await cmd.ExecuteNonQueryAsync();
                MessageBox.Show("Command executed async");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value >= 100)
                progressBar1.Value = 0;

            if (progressBar2.Value >= 100)
                progressBar2.Value = 0;

            if (progressBar3.Value >= 100)
                progressBar3.Value = 0;

            progressBar1.Value += 1;
            progressBar2.Value += 5;
            progressBar3.Value += 2;
        }
    }
}
