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

        private void FormTeste_Load(object sender, EventArgs e)
        {
            ListEditora.DisplayMember = "Nome";
            ListAutores.DisplayMember = "Nome";
            ListGeneros.DisplayMember = "Descricao";
            ListLivro.DisplayMember = "Titulo";
        }

        private void btnCriarEditora_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtEditora.Text) || !String.IsNullOrWhiteSpace(txtEditora.Text)) {
                ListEditora.Items.Add(new Editora(txtEditora.Text));
                txtEditora.Clear();
            }
        }

        private void btnCriarAutor_Click(object sender, EventArgs e)
        {
            if((!String.IsNullOrEmpty(txtAutores.Text) || 
               !String.IsNullOrWhiteSpace(txtAutores.Text)) &&
               ListEditora.SelectedItems.Count!=0
               )
            {
                List<Editora> y = new List<Editora>();
                foreach(Editora x in ListEditora.SelectedItems)
                {
                    y.Add(x);
                }
                ListAutores.Items.Add(new Autor(txtAutores.Text,y));
                txtAutores.Clear();
                ListEditora.ClearSelected();
            }
        }


        private void btnCriarGeneros_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtGeneros.Text) || !string.IsNullOrEmpty(txtGeneros.Text))
            {
                ListGeneros.Items.Add(new GeneroLivro(txtGeneros.Text));
                txtGeneros.Clear();
            }
        }

        private bool validarStringGen(string s)
        {
            return !string.IsNullOrEmpty(s) || !string.IsNullOrWhiteSpace(s);
        }


        private void btnCriarLivro_Click(object sender, EventArgs e)
        {
            if (validarStringGen(txtISBN.Text) && 
                validarStringGen(txtTitulo.Text) &&
                ListGeneros.SelectedItem != null &&
                DateLivro.Value!=null &&
                //ListEditora.SelectedItems.Count==1 &&
                ListAutores.SelectedItem!=null)
            {
                Editora x = new Editora();
                Autor y = ListAutores.SelectedItem as Autor;
                if (y.EditorasUsadas.Count > 1)
                {
                    using (escolhaAutor z = new escolhaAutor(y))
                    {
                        z.ShowDialog();
                        x = new Editora(z.EditoraEscolhida);
                    }
                }
                else if (y.EditorasUsadas.Count == 1)
                    x = y.EditorasUsadas[0];
                else
                    x = null;

                if(x!=null)
                {

                ListLivro.Items.Add(new Livro(txtISBN.Text, txtTitulo.Text, ListGeneros.SelectedItem as GeneroLivro,
                                              DateLivro.Value, new Editora(x), ListAutores.SelectedItem as Autor));
                txtISBN.Clear();
                txtTitulo.Clear();
                ListGeneros.ClearSelected();
                DateLivro.Value = DateTime.Today;
                ListEditora.ClearSelected();
                } 
            }
        }

        private void ListLivro_DoubleClick(object sender, EventArgs e)
        {
            Livro x = ListLivro.SelectedItem as Livro;
            MessageBox.Show(string.Format("Titulo do livro: {0}\nISBN: {1}\nGénero: {2}\nData Publicação: {3}\nEditora: {4}",
                                          x.Titulo, x.Isbn, x.Genero.Descricao, x.DataPublicacao.ToShortDateString(), x.Editora.Nome),
                            "Sobre o livro");
        }
    }
}
