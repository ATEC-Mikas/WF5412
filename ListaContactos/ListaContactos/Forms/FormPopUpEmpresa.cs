using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaContactos
{
    public partial class FormPopUpEmpresa : Form
    {
        private string _empresa;
        public string Empresa { get { return _empresa; } }

        public FormPopUpEmpresa()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            _empresa = null;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtEmpresa.Text) && !string.IsNullOrWhiteSpace(txtEmpresa.Text))
            {
                _empresa = txtEmpresa.Text;
            }
            this.Close();
        }
    }
}
