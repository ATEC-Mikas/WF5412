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
    public partial class FormContacto : Form
    {
        private Contacto _contacto;

        public FormContacto()
        {
            InitializeComponent();
        }

        public FormContacto(Conta c) : this()
        {
            _contacto = new Contacto(c);
            btnEdit.Text = "Guardar";
            lblCriador.Text = $"Criado por {_contacto.Criador.Nome}";
        }

        public FormContacto(Contacto c)  : this()
        {
            _contacto = c;
            txtNome.Text = _contacto.Nome;
            txtTitulo.Text = _contacto.Titulo;
            txtMorada.Text = _contacto.Morada;
            txtNif.Text = _contacto.Nif.ToString();
            checkPublico.Checked = _contacto.Publico;
            foreach (string s in Empresas.FindById(_contacto.ID))
                ListEmpresas.Items.Add(s);
            foreach (KeyValuePair<string, string> kv in Comunicacoes.FindById(_contacto.ID))
                ListComunicacoes.Items.Add(kv);
            txtNome.Enabled = false;
            txtMorada.Enabled = false;
            txtNif.Enabled = false;
            txtTitulo.Enabled = false;
            checkPublico.Enabled = false;
            btnCAdd.Enabled = false;
            btnCRemov.Enabled = false;
            btnEAdd.Enabled = false;
            btnERemov.Enabled = false;


            lblCriador.Text = $"Criado por {_contacto.Criador.Nome}";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(btnEdit.Text=="Editar")
            {
                txtNome.Enabled = true;
                txtMorada.Enabled = true;
                txtNif.Enabled = true;
                txtTitulo.Enabled = true;
                checkPublico.Enabled = true;
                btnCAdd.Enabled = true;
                btnCRemov.Enabled = true;
                btnEAdd.Enabled = true;
                btnERemov.Enabled = true;
                btnEdit.Text = "Guardar";
            } else
            {
                if(validarEntradas())
                {
                    _contacto.Nome = txtNome.Text;
                    _contacto.Morada = txtMorada.Text;
                    _contacto.Nif = int.Parse(txtNif.Text);
                    _contacto.Titulo = txtTitulo.Text;
                    _contacto.Publico = checkPublico.Checked;
                    foreach(string s in ListEmpresas.Items)
                        if (!_contacto.Empresas.Contains(s))
                            _contacto.AdicionarEmpresa(s);
                    foreach (KeyValuePair<string,string> kv in ListComunicacoes.Items)
                        if (!_contacto.Comunicacoes.Contains(kv))
                            _contacto.AdicionarComunicacao(kv.Key, kv.Value);
                    if(!_contacto.save())
                    {
                        MessageBox.Show("erro");
                    }
                    txtNome.Enabled = false;
                    txtMorada.Enabled = false;
                    txtNif.Enabled = false;
                    txtTitulo.Enabled = false;
                    checkPublico.Enabled = false;
                    btnCAdd.Enabled = false;
                    btnCRemov.Enabled = false;
                    btnEAdd.Enabled = false;
                    btnERemov.Enabled = false;
                    btnEdit.Text = "Editar";
                    MessageBox.Show("Salvo com sucesso!");
                }
            }
        }

        private bool validarString(string s)
        {
            return !string.IsNullOrWhiteSpace(s) || !string.IsNullOrEmpty(s);
        }
        private bool validarNif(int i)
        {
            return i > 100000000 && i < 999999999;
        }

        private bool validarEntradas()
        {
            if(int.TryParse(txtNif.Text,out int i))
                return validarString(txtMorada.Text) && validarString(txtNome.Text) && validarString(txtTitulo.Text) && validarNif(int.Parse(txtNif.Text));
            return false;
        }

        private void txtNif_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem a Certeza?", "Confirmação",MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                _contacto.delete();
                System.Threading.Thread.Sleep(2000);
                this.Close();
            }
        }
    }
}
