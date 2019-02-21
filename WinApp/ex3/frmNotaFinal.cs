using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3
{
    public partial class frmNotaFinal : Form
    {
        public frmNotaFinal()
        {
            InitializeComponent();
        }

        private void frmNotaFinal_Load(object sender, EventArgs e)
        {
            btnLimpar.Visible = false;
            lblNota.Visible = false;
        }
        private void txtHandle(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
            if (Double.Parse(((TextBox)sender).Text+e.KeyChar.ToString())>20)
            {
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try {
            double r = Math.Round(Properties.Settings.Default.peso1 * (Double.Parse(txtTeste1.Text) + Double.Parse(txtTeste2.Text)) / 2
                    + Properties.Settings.Default.peso2 * (Double.Parse(txtTP1.Text) + Double.Parse(txtTP2.Text)) / 2
                    + Properties.Settings.Default.peso3 * Double.Parse(txtTF.Text),2);
            lblNota.Text = Properties.Settings.Default.resposta + r;
            lblNota.Visible = true;
            btnLimpar.Visible = true;
            } catch (Exception erro)
            {
                MessageBox.Show("Tem de introduzir em todos os campos!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblNota.Text = string.Empty;
            btnLimpar.Visible = false;
            lblNota.Visible = false;
        }
    }
}
