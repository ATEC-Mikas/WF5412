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
    public partial class escolhaAutor : Form
    {
        private Editora _editoraEscolhida;
        public Editora EditoraEscolhida
        {
            get{return _editoraEscolhida;}
        }


        public escolhaAutor()
        {
            InitializeComponent();
        }
        public escolhaAutor(Autor a) : this()
        {
            _editoraEscolhida = null;
            foreach (Editora x in a.EditorasUsadas)
            {
                ListEditora.Items.Add(x);
            }
            ListEditora.DisplayMember = "Nome";
        }


        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if(ListEditora.SelectedItem!=null)
            {
                _editoraEscolhida = ListEditora.SelectedItem as Editora;
                this.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            _editoraEscolhida = null;
            this.Close();
        }
    }
}
