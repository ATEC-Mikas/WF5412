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
    public partial class frmCambioCheckbox : Form
    {
        public frmCambioCheckbox()
        {
            InitializeComponent();
        }

        private void frmCambioCheckbox_Load(object sender, EventArgs e)
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
            if (cbDollar.Checked)
                r += String.Format("{0} Dollar\n", Math.Round(Double.Parse(txtEur.Text) * Properties.Settings.Default.dollar,2));
            if (cbIene.Checked)
                r += String.Format("{0} Ienes\n", Math.Round(Double.Parse(txtEur.Text) * Properties.Settings.Default.lene,2));
            if (cbLibra.Checked)
                r += String.Format("{0} Libras\n", Math.Round(Double.Parse(txtEur.Text) * Properties.Settings.Default.libra,2));
            if (cbSek.Checked)
                r += String.Format("{0} SEK\n", Math.Round(Double.Parse(txtEur.Text) * Properties.Settings.Default.sek,2));
            lblResposta.Visible = true;
            lblResposta.Text = r;
        }
    }
}
