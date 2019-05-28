using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteWebService
{
    public partial class Form1 : Form
    {
        private WebServiceTeste.WebServiceTeste WebService = new WebServiceTeste.WebServiceTeste();
        private WebServiceTeste.UtilizadorTestes Utilizador = null;

        public Form1()
        {
            InitializeComponent();
            Atualizar();
            button2_Click(null, null);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Atualizar ()
        {
           List<WebServiceTeste.UtilizadorTestes> utilizadorTestes = WebService.ObterListaUtilizadoresTestes().ToList();
            dataGridView1.DataSource = utilizadorTestes;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Utilizador!=null)
            {
                WebService.ApagarUtilizadorTestes(Utilizador.Id);
                Utilizador = null;
                Atualizar();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Utilizador!=null)
            {
                Utilizador.Name = textBox1.Text;
                Utilizador.Email = textBox2.Text;
                if (Utilizador.Id == -1)
                {
                    Utilizador.Id = WebService.ObterListaUtilizadoresTestes().Max(x => x.Id) + 1;
                    WebService.GuardarUtilizadorTestes(Utilizador);
                }
                else
                    if (!WebService.AtualizarUtilizadorTestes(Utilizador))
                        MessageBox.Show("Tá partido!");
                //WebService.
                Atualizar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utilizador = new WebServiceTeste.UtilizadorTestes();
            Utilizador.Id = -1;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.SelectedCells[0]!=null)
            {
                Utilizador = WebService.ObterUtilizadorTestes((int)dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value);
                textBox1.Text = Utilizador.Name;
                textBox2.Text = Utilizador.Email;
            }
        }
    }
}
