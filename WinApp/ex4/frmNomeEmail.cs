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
    public partial class frmNomeEmail : Form
    {
        public frmNomeEmail()
        {
            InitializeComponent();
        }

        private void frmNomeEmail_Load(object sender, EventArgs e)
        {
            //290
            this.Height = 155;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            lblEm1.Visible = false;
            lblEm2.Visible = false;
            lblNome.Visible = false;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtNome.Text) && txtNome.Text.Split(' ').Length>1)
            {
                    this.Height = 290;
                    string[] r = txtNome.Text.Split(' ');
                    lblNome.Visible = true;
                    lblNome.Text = string.Format("{0} {1}", r[0], r[r.Length-1]);
                    lblEm1.Visible = true;
                    lblEm1.Text = string.Format("{0}.{1}@xpto.pt", r[0].ToLower(),r[r.Length-1].ToLower());
                    lblEm2.Visible = true;
                    lblEm2.Text = string.Format("{0}{1}@xpto.pt", r[0].ToLower()[0], r[r.Length - 1].ToLower());
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.Height = 155;
            lblEm1.Visible = false;
            lblEm2.Visible = false;
            lblNome.Visible = false;
            lblEm1.Text = string.Empty;
            lblEm2.Text = string.Empty;
            lblNome.Text = string.Empty;
            txtNome.Clear();
        }
    }
}
