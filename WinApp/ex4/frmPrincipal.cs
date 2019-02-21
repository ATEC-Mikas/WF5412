using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ex1;
using ex2;
using ex3;

namespace ex4
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cumprimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCumprimentos f = this.MdiChildren.FirstOrDefault(xpto => xpto.GetType()==typeof(frmCumprimentos)) as frmCumprimentos;
            if(f==null)
            {
                f = new frmCumprimentos();
                f.MdiParent = this;
            }
            f.Show();
        }

        private void fahrenheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFahrenheit f = this.MdiChildren.FirstOrDefault(xpto => xpto.GetType() == typeof(frmFahrenheit)) as frmFahrenheit;
            if (f == null)
            {
                f = new frmFahrenheit();
                f.MdiParent = this;
            }
            f.Show();
        }

        private void calcularNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotaFinal f = this.MdiChildren.FirstOrDefault(xpto => xpto.GetType() == typeof(frmNotaFinal)) as frmNotaFinal;
            if (f == null)
            {
                f = new frmNotaFinal();
                f.MdiParent = this;
            }
            f.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("De certeza que deseja sair", "Aviso",MessageBoxButtons.YesNo)==DialogResult.Yes)
                Environment.Exit(0);
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNomeEmail f = this.MdiChildren.FirstOrDefault(xpto => xpto.GetType() == typeof(frmNomeEmail)) as frmNomeEmail;
            if (f == null)
            {
                f = new frmNomeEmail();
                f.MdiParent = this;
            }
            f.Show();
        }
    }
}
