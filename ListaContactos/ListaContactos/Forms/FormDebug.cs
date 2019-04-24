using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using System.Windows.Forms;

namespace ListaContactos
{
    public partial class FormDebug : Form
    {
        public FormDebug()
        {
            InitializeComponent();
            //https://github.com/BcryptNet/bcrypt.net
            //continuar contacto.cs
            labelR.Text = string.Empty;


            Conta teste = new Conta();
            teste.User = "Manteiga";
            teste.Nome = "Mikas ok";
            teste.Password = "123+qwe";
            teste.save();

            Comunicacoes.AddTipo("teste");

            //Contacto t = new Contacto(teste);
            //t.Nome = "Sr Teste";
            //t.Nif = 123456789;
            //t.Morada = "Rua dos sins";
            //t.Publico = false;
            //t.Titulo = "Mestre dos testes";
            //t.AdicionarEmpresa("Testes Inc.");
            //t.AdicionarComunicacao("teste", "123");
            //t.save();

            //t.AdicionarEmpresa("Testadinho");
            //t.save();
            //t.RemoverEmpresa("Testadinho");
            //t.save();


            List<Contacto> lt = Contactos.All(teste);
            if (lt.Count == 0)
            {
                MessageBox.Show("BUG!");
            }
            else foreach (Contacto testing in lt)
                {
                    labelR.Text += $"ID: {testing.ID}\n" +
                                  $"Nome: {testing.Nome}\n" +
                                  $"Nif: {testing.Nif}\n" +
                                  $"Morada: {testing.Morada}\n" +
                                  $"Publico: {testing.Publico}\n" +
                                  $"Titulo: {testing.Titulo}\nEmpresas:\n";

                    foreach (string s in testing.Empresas)
                    {
                        labelR.Text += $"{s} \n";
                    }
                    labelR.Text += "Comunicacoes:\n";
                    foreach (KeyValuePair<string, string> kv in testing.Comunicacoes)
                    {
                        labelR.Text += $"{kv.Key} - {kv.Value}";
                    }
                }


            //DAL t = new DAL("Contato");

            //OleDbDataReader dr = t.find("nome,criador", $"where id='a2bfff52-312d-4c78-8753-f670d4d8f00b'");
            //if(dr.HasRows)
            //{
            //    while(dr.Read()) {
            //        MessageBox.Show(dr.GetString(1));
            //    }
            //    dr.Close();
            //}

            //List<Conta> lt = Contas.all();
            //if(lt.Count==0)
            //{
            //    MessageBox.Show("BUG");
            //}
            //foreach (Conta testing in lt)
            //{
            //    labelR.Text += "Nome: " + testing.Nome + " Username: " + testing.User+" Password: "+testing.Password+"\n";
            //}


        }
    }
}
