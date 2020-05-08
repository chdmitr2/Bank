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
    public partial class NewCredit : Form
    {
        public NewCredit()
        {
            InitializeComponent();
            txbxCreditId.Text = Guid.NewGuid().ToString();

        }

        
    }
}
