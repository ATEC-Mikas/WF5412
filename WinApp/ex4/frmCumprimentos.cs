using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1
{
    public partial class frmCumprimentos : Form
    {
        public frmCumprimentos()
        {
            InitializeComponent();
            Height = 110;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            txtSaudacao.Focus();
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtNome.Text)&& !string.IsNullOrEmpty(txtSaudacao.Text))
            {
                //lblResposta.Text = txtSaudacao.Text + " " + txtNome.Text + "!!";
                lblResposta.Text = string.Format("{0} {1}!!", txtSaudacao.Text, txtNome.Text);
                Height=180;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSaudacao.Text = "";
            txtNome.Text = "";
            lblResposta.Text = "";
            Height = 110;
        }

        private void frmCumprimentos_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNome.Text) && !string.IsNullOrEmpty(txtSaudacao.Text) && e.KeyCode == Keys.Enter)
            {
                btnAcao.PerformClick();
            } else if (Height == 180 && e.KeyCode==Keys.Escape)
            {
                btnLimpar.PerformClick();
                txtSaudacao.Focus();
            }
        }
    }
}
