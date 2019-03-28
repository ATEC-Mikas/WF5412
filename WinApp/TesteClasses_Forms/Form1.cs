using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinhasClasses;

namespace TesteClasses_Forms
{
    public partial class FormTeste : Form
    {
        public FormTeste()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCriarEditora_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtEditora.Text) || !String.IsNullOrWhiteSpace(txtEditora.Text)) {
                ListEditora.Items.Add(new Editora(txtEditora.Text));
                ListEditora.DisplayMember = "Nome";
            }
        }
    }
}
