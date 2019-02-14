using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2
{
    public partial class frmFahrenheit : Form
    {
        public frmFahrenheit()
        {
            InitializeComponent();
        }

        private void txtFah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar) || e.KeyChar=='.')
            {
                txtFah.Text += e.KeyChar.ToString();
            }
            e.Handled = true;
        }
    }
}
