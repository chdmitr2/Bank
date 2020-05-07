using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Bank
{
    public partial class MainForm : Form
    {
        DAL dal = new DAL();
        public MainForm()
        {
            InitializeComponent();
            ArrayList allDebitors = dal.GetAllDebitors();
            dgvDebitors.DataSource = allDebitors;
            SettingsDGVDebitors();
        }

        void SettingsDGVDebitors()
        {
            try { 
            dgvDebitors.Columns[0].Visible = false;
            dgvDebitors.Columns[2].Visible = false;
            dgvDebitors.Columns[3].Visible = false;
            dgvDebitors.TopLeftHeaderCell.Value = "#";


            }
            catch
            {

            }
        }

        private void dgvDebitors_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txbxDebitorId.Text = dgvDebitors.Rows[e.RowIndex].Cells[0].Value.ToString();
            txbxDebitorName.Text = dgvDebitors.Rows[e.RowIndex].Cells[1].Value.ToString();
            txbxDebitorPostNumber.Text = dgvDebitors.Rows[e.RowIndex].Cells[2].Value.ToString();
            String phone = dgvDebitors.Rows[e.RowIndex].Cells[3].Value.ToString();
            txbxPhoneNumber.Text = (phone == String.Empty) ? "No details" : phone;
            //חשוב לרשום NULL בטבלה 
            dgvCredits.DataSource = dal.GetAllCreditsForDebitor(dgvDebitors.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
