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

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvDebitors.CellEnter += new DataGridViewCellEventHandler(dgvDebitors_CellEnter);
            dgvCredits.CellEnter += new DataGridViewCellEventHandler(dgvCredits_CellEnter);
        }

        private void dgvCredits_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string creditorId = dgvCredits.CurrentRow.Cells[0].Value.ToString();
            dgvPayments.DataSource = dal.GetAllPaymentsForCredit(creditorId);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           if(MessageBox.Show("Are you really want to exit?","Bank Manager",MessageBoxButtons.OKCancel) == DialogResult.OK)
            e.Cancel = false;
            else
            e.Cancel = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDebitor newDebitor = new NewDebitor();
            if (newDebitor.ShowDialog() == DialogResult.OK)
            {
                dgvDebitors.DataSource = dal.GetAllDebitors();
                MessageBox.Show("New Debitor saved successfully", "Bank Manager", MessageBoxButtons.OK);
                
            }
            else
                MessageBox.Show("New Debitor not saved!!!", "Bank Manager", MessageBoxButtons.OK);

        }

        private void openNewCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCredit newCredit = new NewCredit();
            if (newCredit.ShowDialog() == DialogResult.OK)
            {
                dgvCredits.DataSource = dal.GetAllCreditsForDebitor(dgvDebitors.CurrentRow.Cells["ID"].Value.ToString());
                MessageBox.Show("New Credit saved successfully", "Bank Manager", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("New Credit not saved!!!", "Bank Manager", MessageBoxButtons.OK);

        }

        private void passNewPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPayment newPayment = new NewPayment();
            if (newPayment.ShowDialog() == DialogResult.OK)
            {
                dgvCredits.DataSource = dal.GetAllCreditsForDebitor(dgvDebitors.CurrentRow.Cells["ID"].Value.ToString());
                MessageBox.Show("New Payment accepted", "Bank Manager", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("New Payment not accepted!!!", "Bank Manager", MessageBoxButtons.OK);
        }
    } 
}
