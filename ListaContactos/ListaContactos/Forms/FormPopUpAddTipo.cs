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
    public partial class FormPopUpAddTipo : Form
    {

        public FormPopUpAddTipo()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTipo.Text) && !string.IsNullOrWhiteSpace(txtTipo.Text))
            {
                Comunicacoes.AddTipo(txtTipo.Text);
                this.Close();
            }
        }
    }
}
