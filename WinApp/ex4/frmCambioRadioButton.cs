using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex4
{
    public partial class frmCambioRadioButton : Form
    {
        public frmCambioRadioButton()
        {
            InitializeComponent();
        }

        private void frmCambioRadioButton_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            lblResposta.Visible = false;
        }

        private void txtHandle(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)8) && !((e.KeyChar==(char)44) && ((TextBox)sender).Text.IndexOf(',')==-1))
            {
                e.Handled = true;
            }
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            
            string r = String.Empty;
            if (radDollar.Checked)
                r += String.Format("{0} Dollar\n", Math.Round(Double.Parse(txtEur.Text) * Properties.Settings.Default.dollar,2));
            else if (radLen.Checked)
                r += String.Format("{0} Ienes\n", Math.Round(Double.Parse(txtEur.Text) * Properties.Settings.Default.lene,2));
            else if (radLib.Checked)
                r += String.Format("{0} Libras\n", Math.Round(Double.Parse(txtEur.Text) * Properties.Settings.Default.libra,2));
            else if (radSek.Checked)
                r += String.Format("{0} SEK\n", Math.Round(Double.Parse(txtEur.Text) * Properties.Settings.Default.sek,2));
            lblResposta.Visible = true;
            lblResposta.Text = r;
        }
    }
}
