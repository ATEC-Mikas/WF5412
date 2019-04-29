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
            panelSeed.Visible = false;
        }

        private bool validarString(string s)
        {
            return !string.IsNullOrWhiteSpace(s) && !string.IsNullOrEmpty(s) && !s.Any(char.IsWhiteSpace) ;
        }

        private bool validarNome(string s)
        {
            return !string.IsNullOrWhiteSpace(s) && !string.IsNullOrEmpty(s);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(validarString(txtLPassword.Text) && validarString(txtLUser.Text))
            {
                Conta t = Contas.FindByUser(txtLUser.Text);
                if(t!=null)
                {
                    if (t.comparePassword(txtLPassword.Text)) {
                        this._conta = t;
                        MessageBox.Show("Fez Login com sucesso!");
                        this.Close();
                    } else
                    {
                        MessageBox.Show("Combinação Password/Username Incorreta!");
                    }
                } else
                {
                    MessageBox.Show("Combinação Password/Username Incorreta!");
                }
            }
            else
            {
                MessageBox.Show("Corrija o username e password e tente denovo!");
            }
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            if(validarString(txtRPass.Text) && validarString(txtRConfirmP.Text) && validarString(txtRUser.Text) && validarNome(txtRNome.Text))
            {
                if(!Contas.exists(txtRUser.Text))
                {
                    if(txtRPass.Text == txtRConfirmP.Text)
                    {
                        Conta t = new Conta();
                        t.User = txtRUser.Text;
                        t.Password = txtRPass.Text;
                        t.Nome = txtRNome.Text;
                        if (t.save())
                        {
                            txtRNome.Clear();
                            txtRUser.Clear();
                            txtRPass.Clear();
                            txtRConfirmP.Clear();
                            MessageBox.Show("Registado com sucesso!");
                            btnRegistar.Enabled = false;
                        } else
                        {
                            MessageBox.Show("Registo impossivel!");
                        }
                    } else
                    {
                        MessageBox.Show("As palavras passes não coincidem!");
                    }
                } else
                {
                    MessageBox.Show("Este Username já existe!");
                }
            }
            else
            {
                MessageBox.Show("Verifique as suas entradas!");
            }
        }

        private void btnSeed_Click(object sender, EventArgs e)
        {
            panelSeed.Visible = true;
            panelSeed.Update();
            if(Seed.Create())
                MessageBox.Show("Seeds geradas!");
            panelSeed.Visible = false;
        }

        private void UserCheck(object sender, KeyPressEventArgs e)
        {
            if(char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
