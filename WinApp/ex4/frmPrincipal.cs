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

        private void queHorasSaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoras f = this.MdiChildren.FirstOrDefault(xpto => xpto.GetType() == typeof(frmHoras)) as frmHoras;
            if (f == null)
            {
                f = new frmHoras();
                f.MdiParent = this;
            }
            f.Show();
        }

        private void quantoTempoPassouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuantoTempoPassou f = this.MdiChildren.FirstOrDefault(xpto => xpto.GetType() == typeof(frmQuantoTempoPassou)) as frmQuantoTempoPassou;
            if (f == null)
            {
                f = new frmQuantoTempoPassou();
                f.MdiParent = this;
            }
            f.Show();
        }

        private void cambioRadioButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioRadioButton f = this.MdiChildren.FirstOrDefault(xpto => xpto.GetType() == typeof(frmCambioRadioButton)) as frmCambioRadioButton;
            if (f == null)
            {
                f = new frmCambioRadioButton();
                f.MdiParent = this;
            }
            f.Show();
        }

        private void cambioCheckboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioCheckbox f = this.MdiChildren.FirstOrDefault(xpto => xpto.GetType() == typeof(frmCambioCheckbox)) as frmCambioCheckbox;
            if (f == null)
            {
                f = new frmCambioCheckbox();
                f.MdiParent = this;
            }
            f.Show();
        }

        private void cambioDropDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioDropdown f = this.MdiChildren.FirstOrDefault(xpto => xpto.GetType() == typeof(frmCambioDropdown)) as frmCambioDropdown;
            if (f == null)
            {
                f = new frmCambioDropdown();
                f.MdiParent = this;
            }
            f.Show();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("De certeza que quer fechar o programa", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            e.Cancel = !(r == DialogResult.Yes);
        }
    }
}
