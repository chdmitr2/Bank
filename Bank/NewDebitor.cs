using System;
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
    public partial class NewDebitor : Form
    {
        DAL dal = new DAL();
        public NewDebitor()
        {
            InitializeComponent();
            txbxDebitorId.Text = Guid.NewGuid().ToString();
        }

        private void btnSaveNewDebitor_Click(object sender, EventArgs e)
        {
          if(dal.SaveNewDebitor(txbxDebitorId.Text.Trim(),
                txbxDebitorName.Text.Trim(), txbxDebitorPostNumber.Text.Trim(),
                txbxPhoneNumber.Text.Trim()))
            this.DialogResult = DialogResult.OK;
          else
            this.DialogResult = DialogResult.No;
        }
    }
}
