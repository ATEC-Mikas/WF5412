using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void mnuSomaDeNumeros_Click(object sender, EventArgs e)
        {
            Outros.frmSomaDeNumeros f = this.MdiChildren.FirstOrDefault(xpto => xpto.GetType() == typeof(Outros.frmSomaDeNumeros)) as Outros.frmSomaDeNumeros;
            if (f == null)
            {
                f = new Outros.frmSomaDeNumeros();
                f.MdiParent = this;
            }
            f.Show();
        }
        private void mnuListarEncomendasDeClientes_Click(object sender, EventArgs e)
        {
            AcessoADados.frmListarEncomendasClientes f = this.MdiChildren.FirstOrDefault(xpto => xpto.GetType() == typeof(AcessoADados.frmListarEncomendasClientes)) as AcessoADados.frmListarEncomendasClientes;
            if (f == null)
            {
                f = new AcessoADados.frmListarEncomendasClientes();
                f.MdiParent = this;
            }
            f.Show();
        }
    }
}
