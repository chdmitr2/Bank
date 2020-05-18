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
        ArrayList allDebitors;
        public MainForm()
        {
            InitializeComponent();
             allDebitors = dal.GetAllDebitors();
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
                allDebitors.Clear();
                allDebitors = dal.GetAllDebitors();
                dgvDebitors.DataSource = allDebitors;
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

        private void saveDataToCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dal.SaveDBToLocalFile())
                MessageBox.Show("All data saved successfully in local files","Bank Manager",
                    MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
            else
                MessageBox.Show("All data not saved  in local files!!!", "Bank Manager",
                    MessageBoxButtons.OK, MessageBoxIcon.Error , MessageBoxDefaultButton.Button1);
        }

        private void dgvDebitors_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            object HeadValue = ((DataGridView)sender).Rows[e.RowIndex].HeaderCell.Value;
            if (HeadValue == null || !HeadValue.Equals((e.RowIndex + 1).ToString()))
                ((DataGridView)sender).Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }

        List<DataGridViewRow> searchedRows;
        int currentRow;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchedRows = new List<DataGridViewRow>();
            string DebName = txbxSearchedDebName.Text.Trim();
            string DebPostNumber = txbxSearchedDebPostNumber.Text.Trim();
            string DebPhoneNumber = txbxSearchedDebPhoneNumber.Text.Trim();

            if(!chbxDB .Checked )
            { 
                foreach (DataGridViewRow row in dgvDebitors.Rows)
                { 
                   if (row.Cells["Name"].FormattedValue.ToString().Contains(DebName) &&
                        row.Cells["PostNumber"].FormattedValue.ToString().Contains(DebPostNumber) &&
                          row.Cells["PhoneNumber"].FormattedValue.ToString().Contains(DebPhoneNumber))
                   {
                     searchedRows.Add(row);
                   }
                    
                }
                if (searchedRows.Count == 0)
                {
                    MessageBox.Show("No find results");
                    btnNextRow.Enabled = false;
                    return;
                }
                MessageBox.Show("Find " + searchedRows.Count + " results");
                btnNextRow.Enabled = true;
                currentRow = -1;
                btnNextRow_Click(null, null);
            }
            else
            {
                btnNextRow.Enabled = false;
               ArrayList SearchedDebitors = dal.SearchDebitors(DebName ,DebPostNumber ,DebPhoneNumber);
                if (SearchedDebitors == null || SearchedDebitors.Count == 0)
                {
                    MessageBox.Show("No Results");
                    return;
                }
                MessageBox.Show("Find " + SearchedDebitors.Count  +" results");
                dgvDebitors.DataSource = SearchedDebitors;
            }
            
        }

        private void btnNextRow_Click(object sender, EventArgs e)
        {
            if (currentRow == searchedRows.Count - 1)
            { 
                currentRow = 0;
            }
            else
            {
                currentRow++;
            }
            dgvDebitors.CurrentCell = searchedRows[currentRow].Cells[1];

        }
    } 
}
