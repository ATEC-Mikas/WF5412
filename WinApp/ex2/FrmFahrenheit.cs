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
            if(!Char.IsDigit(e.KeyChar) && !(e.KeyChar==',' && txtFah.Text.IndexOf(',')==-1) && !(e.KeyChar==(char)8))
            {
                e.Handled = true;
            }

        }

        private void frmFahrenheit_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtCel.Text = Math.Round((Double.Parse(txtFah.Text) - 32) / 1.8,2).ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCel.Text = string.Empty;
            txtFah.Text = string.Empty;
        }
    }
}
