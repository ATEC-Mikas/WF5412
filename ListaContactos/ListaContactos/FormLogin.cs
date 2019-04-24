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
    public partial class FormLogin : Form
    {
        private Conta _conta;
        public Conta Conta { get { return _conta; } }

        public FormLogin()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            _conta = null;
        }

        private bool validarString(string s)
        {
            return !string.IsNullOrWhiteSpace(s) || !string.IsNullOrEmpty(s) || !s.Any(char.IsWhiteSpace);
        }

        private bool validarNome(string s)
        {
            return !string.IsNullOrWhiteSpace(s) || !string.IsNullOrEmpty(s);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(validarString(txtLPassword.Text) && validarString(txtLUser.Text))
            {
                Conta t = Contas.FindByUser(txtLUser.Text);
                if(t!=null)
                {
                    if (t.comparePassword(txtLPassword.Text))
                    {
                        this._conta = t;
                        MessageBox.Show("Fez Login com sucesso!");
                        this.Close();
                    }
                }
            }
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            if(validarString(txtRPass.Text) && validarString(txtRConfirmP.Text) && validarString(txtRUser.Text) && txtRPass.Text==txtRConfirmP.Text && validarNome(txtRNome.Text))
            {
                Conta t = new Conta();
                t.User = txtRUser.Text;
                t.Password = txtRPass.Text;
                t.Nome = txtRNome.Text;
                t.save();
                txtRNome.Clear();
                txtRUser.Clear();
                txtRPass.Clear();
                txtRConfirmP.Clear();
                MessageBox.Show("Registado com sucesso!");
                btnRegistar.Enabled = false;
            }
        }

        private void btnSeed_Click(object sender, EventArgs e)
        {
            Seed.Create();
        }
    }
}
