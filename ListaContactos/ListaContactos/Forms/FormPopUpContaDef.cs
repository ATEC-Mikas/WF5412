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
    public partial class FormPopUpContaDef : Form
    {
        private Conta _conta;
        private Conta _contabackup;
        public Conta Conta { get { return _conta; } }

        private FormPopUpContaDef()
        {
            InitializeComponent();
            txtNPass.Enabled = false;
            txtConfirmPass.Enabled = false;
            txtNCPass.Enabled = false;
            txtUser.Enabled = false;
            txtNome.Enabled = false;
            btnCancelar.Visible = false;
            btnAlterarP.Enabled = false;
        }

        public FormPopUpContaDef(Conta c) : this()
        {
            _conta = new Conta(c);
            txtUser.Text = _conta.User;
            txtNome.Text = _conta.Nome;
        }

        private void ValidarTextEntry(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAlterarP_Click(object sender, EventArgs e)
        {
            if(!(txtNCPass.Text == txtNPass.Text))
            {
                MessageBox.Show("Palavras passes não coincidem!");
            }else
            if(!_conta.comparePassword(txtConfirmPass.Text))
            {
                MessageBox.Show("Palavra passe não equivale á palavra pass antiga!");
            } else
            {
                _conta.Password = txtNCPass.Text;
                txtNPass.Clear();
                txtConfirmPass.Clear();
                txtNCPass.Clear();
                MessageBox.Show("Password alterada!");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(btnEditar.Text=="Editar")
            {
                _contabackup = new Conta(_conta);
                txtNPass.Enabled = true;
                txtConfirmPass.Enabled = true;
                txtNCPass.Enabled = true;
                txtNome.Enabled = true;
                btnAlterarP.Enabled = true;
                btnCancelar.Visible = true;
                btnEditar.Text = "Guardar";
            }
            else
            {
                if(_conta.Nome!=txtNome.Text)
                    _conta.Nome = txtNome.Text;
                if (isEntradasIguais())
                {
                    txtNPass.Enabled = false;
                    txtConfirmPass.Enabled = false;
                    txtNCPass.Enabled = false;
                    txtNome.Enabled = false;
                    btnCancelar.Visible = false;
                    btnAlterarP.Enabled = false;
                    btnEditar.Text = "Editar";
                    MessageBox.Show("Não alterou nada.");
                }
                else
                    if (_conta.save())
                {
                    txtNPass.Enabled = false;
                    txtConfirmPass.Enabled = false;
                    txtNCPass.Enabled = false;
                    txtNome.Enabled = false;
                    btnCancelar.Visible = false;
                    btnAlterarP.Enabled = false;
                    btnEditar.Text = "Editar";
                    _contabackup = new Conta(_conta);
                    MessageBox.Show("Guardado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Falha a guardar!");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _conta = new Conta(_contabackup);
            txtUser.Text = _conta.User;
            txtNome.Text = _conta.Nome;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool isEntradasIguais()
        {
            return _conta.Nome == _contabackup.Nome && _conta.Password == _contabackup.Password;
        }
    }
}
