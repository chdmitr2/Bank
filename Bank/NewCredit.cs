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
    public partial class NewCredit : Form
    {
        ArrayList allDebitors;
        DAL dal = new DAL();
        public NewCredit()
        {
            InitializeComponent();
            txbxCreditId.Text = Guid.NewGuid().ToString();
            allDebitors = dal.GetAllDebitors();

            if (allDebitors == null || allDebitors.Count == 0)
            txbxCreditBalance.Enabled = txbxCreditAmount.Enabled = btnSaveNewCredit.Enabled = false;
            ltbxDebitorId.DataSource = allDebitors;
            ltbxDebitorName.DataSource = allDebitors;

        }

        private void txbxCreditAmount_TextChanged(object sender, EventArgs e)
        {
            txbxCreditBalance.Text = txbxCreditAmount.Text;
        }

        private void btnSaveNewCredit_Click(object sender, EventArgs e)
        {
            if (dal.SaveNewCredit(new Guid(txbxCreditId.Text), new Guid(ltbxDebitorId.SelectedValue.ToString()),
                  Int32.Parse(txbxCreditAmount.Text), Int32.Parse(txbxCreditBalance.Text), dtpCreditOpenDate.Value))
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;
        }

        private void txbxCreditAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txbxCreditAmount_Leave(object sender, EventArgs e)
        {
            if (txbxCreditAmount.Text == string.Empty || 
                Int64.Parse(txbxCreditAmount.Text.Trim()) < 100 ||
                Int64.Parse(txbxCreditAmount.Text.Trim()) > 100000000)
            {
                lblMessageCreditAmount.Text  = "Wrong value of credit!!!";
                lblMessageCreditAmount.ForeColor  = Color.Red;
                btnSaveNewCredit.Enabled = false;
            }
            else
            {
                lblMessageCreditAmount.Text = "Credit in range";
                lblMessageCreditAmount.ForeColor = Color.Green;
                btnSaveNewCredit.Enabled = true;
            }
        }
    }
}
