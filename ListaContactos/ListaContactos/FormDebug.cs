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


            Conta teste = new Conta();
            teste.User = "Manteiga";
            teste.Nome = "Mikas ok";
            teste.Password = "123+qwe";
            teste.save();
            
            labelR.Text = string.Empty;
            List<Conta> lt = Contas.all();
            if(lt.Count==0)
            {
                MessageBox.Show("BUG");
            }
            foreach (Conta testing in lt)
            {
                labelR.Text += "Nome: " + testing.Nome + " Username: " + testing.User+" Password: "+testing.Password+"\n";
            }

            
        }
    }
}
