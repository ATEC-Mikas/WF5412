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
    public partial class frmCambioDropdown : Form
    {
        public frmCambioDropdown()
        {
            InitializeComponent();
        }

        private void frmCambioDropdown_Load(object sender, EventArgs e)
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
            if (String.Compare(cbMoeda.Text,"Dollar")==0)
                r += String.Format("{0} Dollar\n", Math.Round(Double.Parse(txtEur.Text) * Properties.Settings.Default.dollar,2));
            else if (String.Compare(cbMoeda.Text, "Iéne") == 0)
                r += String.Format("{0} Ienes\n", Math.Round(Double.Parse(txtEur.Text) * Properties.Settings.Default.lene,2));
            else if (String.Compare(cbMoeda.Text, "Libra") == 0)
                r += String.Format("{0} Libras\n", Math.Round(Double.Parse(txtEur.Text) * Properties.Settings.Default.libra,2));
            else if (String.Compare(cbMoeda.Text, "Sek") == 0)
                r += String.Format("{0} SEK\n", Math.Round(Double.Parse(txtEur.Text) * Properties.Settings.Default.sek,2));
            lblResposta.Visible = true;
            lblResposta.Text = r;
        }

        private void cbMoeda_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
