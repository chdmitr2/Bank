using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class NewPayment : Form
    {
        DAL dal = new DAL();
        ArrayList allDebitors;
        ArrayList allCredits;

        public NewPayment()
        {
            InitializeComponent();
            txbxPaymentId.Text = Guid.NewGuid().ToString();
            allDebitors = dal.GetAllDebitors();
            if (allDebitors == null || allDebitors .Count ==0)
            {
                btnSaveNewPayment.Enabled = false;
                txbxPaymentAmount.Enabled = false;
            }
            else
            {
                btnSaveNewPayment.Enabled = true;
                txbxPaymentAmount.Enabled = true;
            }
            ltbxDebitorId.DataSource = allDebitors;
            ltbxDebitorName.DataSource = allDebitors;
        }

        
        private void ltbxDebitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            allCredits = dal.GetAllCreditsForDebitor(ltbxDebitorId.SelectedValue.ToString());
            ltbxCreditId.DataSource = allCredits;
            if (allCredits == null || allCredits.Count == 0)
            {
                btnSaveNewPayment.Enabled = false;
                txbxPaymentAmount.Enabled = false;
            }
            else
            {
                btnSaveNewPayment.Enabled = true;
                txbxPaymentAmount.Enabled = true;
            }
            ltbxCreditAmount.DataSource = allCredits;
            ltbxCreditBalance.DataSource = allCredits;
            ltbxCreditId.DisplayMember = "ID";
            ltbxCreditId.ValueMember = "ID";
            ltbxCreditAmount.DisplayMember = "Amount";
            ltbxCreditAmount.ValueMember = "ID";
            ltbxCreditBalance.DisplayMember = "Balance";
            ltbxCreditBalance.ValueMember = "Balance";

        }

        private void txbxPaymentAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ',')
                if(txbxPaymentAmount .Text .Trim ().Contains (',') ||
                    txbxPaymentAmount .Text == String .Empty )
                {
                    e.Handled = true;
                    return;
                }
                else
                {
                    e.Handled = false;
                    return;
                }
            short res;
            if (Int16.TryParse(e.KeyChar.ToString(), out res))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txbxPaymentAmount_Leave(object sender, EventArgs e)
        {
            if (txbxPaymentAmount.Text.Trim()== String .Empty )
            {
                lblMessage.Text = "Wrong Payment!!!";
                lblMessage.ForeColor  = Color.Red ;
                btnSaveNewPayment.Enabled = false;
                return;
            }
            decimal payValue = decimal.Parse(txbxPaymentAmount.Text.Trim ());
            if(payValue < 100 || payValue  > decimal.Parse(ltbxCreditBalance.SelectedValue.ToString()))
            {
                lblMessage.Text = "Wrong Payment!!!";
                lblMessage.ForeColor = Color.Red;
                btnSaveNewPayment.Enabled = false;
            }
            else
            {
                lblMessage.Text = "Payment in range";
                lblMessage.ForeColor = Color.Green;
                btnSaveNewPayment.Enabled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txbxPaymentAmount.Text = "";
        }

        private void btnSaveNewPayment_Click(object sender, EventArgs e)
        {
            decimal paymentAmount;
            if(!decimal.TryParse(txbxPaymentAmount.Text.Trim (),out paymentAmount))
            {
                MessageBox.Show("Wrong Payment!!!");
                return;
            }
            if (dal.SaveNewPayment(new Guid(txbxPaymentId.Text.Trim()),
                new Guid(ltbxCreditId.SelectedValue.ToString()),
             paymentAmount, dtpPaymentPassDate.Value))
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.OK;
        }
    }
}
