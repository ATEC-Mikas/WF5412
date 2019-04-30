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
        private Contacto _contactoBackup;
        private Conta _conta;
        private bool _deleted;
        private bool _criado;

        public FormContacto()
        {
            InitializeComponent();
            panelBlock.Visible = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            btnCancelar.Visible = false;
            btnCancelar.Enabled = false;
            _deleted = false;
        }

        public FormContacto(Conta c) : this()
        {
            _conta = new Conta(c);
            _contacto = new Contacto(c);
            btnEdit.Text = "Guardar";
            lblUltimaModific.Text = Modificacoes.UltimaMod(_contacto) ?? "";
            lblCriador.Text = $"Criado por {_contacto.Criador.User}";
            _criado = true;
            btnLogs.Visible = false;
            btnDelete.Visible = false;
        }

        public FormContacto(Contacto c,Conta conta)  : this()
        {
            _conta = new Conta(conta);
            _contacto = new Contacto(c);
            _contactoBackup = new Contacto(c);
            txtNome.Text = _contacto.Nome;
            txtTitulo.Text = _contacto.Titulo;
            txtMorada.Text = _contacto.Morada;
            if (_contacto.Nif != -1)
                txtNif.Text = _contacto.Nif.ToString();
            else
                txtNif.Text = string.Empty;
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

            if (_contacto.Criador.User != _conta.User)
            {
                btnLogs.Enabled = false;
                btnDelete.Enabled = false;
                btnDelete.Visible = false;
            }

            lblUltimaModific.Text = Modificacoes.UltimaMod(_contacto) ?? "";
            lblCriador.Text = $"Criado por {_contacto.Criador.User}";

            _criado = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(btnEdit.Text=="Editar")
            {
                txtNome.Enabled = true;
                txtMorada.Enabled = true;
                txtNif.Enabled = true;
                txtTitulo.Enabled = true;
                if (_contacto.Criador.User == _conta.User)
                    checkPublico.Enabled = true;
                btnCAdd.Enabled = true;
                btnCRemov.Enabled = true;
                btnEAdd.Enabled = true;
                btnERemov.Enabled = true;
                btnEdit.Text = "Guardar";
                btnCancelar.Visible = true;
                btnCancelar.Enabled = true;
            } else
            {
                if(validarEntradas())
                {
                    _contacto.Nome = txtNome.Text;
                    _contacto.Morada = txtMorada.Text;
                    if(int.TryParse(txtNif.Text, out int i))
                        _contacto.Nif = int.Parse(txtNif.Text);
                    else
                    {
                        _contacto.Nif = -1;
                    }
                    _contacto.Titulo = txtTitulo.Text;
                    _contacto.Publico = checkPublico.Checked;
                    AtualizarEmpresas();
                    AtualizarComunicacoes();
                    if(_contacto.save(_conta))
                    {
                        txtNome.Enabled = false;
                        txtMorada.Enabled = false;
                        txtNif.Enabled = false;
                        txtTitulo.Enabled = false;
                        checkPublico.Enabled = false;
                        btnCAdd.Enabled = false;
                        btnCRemov.Enabled = false;
                        btnEAdd.Enabled = false;
                        btnERemov.Enabled = false;
                        btnCancelar.Enabled = false;
                        btnCancelar.Visible = false;
                        btnLogs.Visible = true;
                        btnDelete.Visible = true;
                        btnEdit.Text = "Editar";
                        MessageBox.Show("Salvo com sucesso!");
                        lblUltimaModific.Text = Modificacoes.UltimaMod(_contacto);
                        _contactoBackup = new Contacto(_contacto);
                    }
                }
            }
        }

        private void AtualizarComunicacoes()
        {
            foreach(KeyValuePair<string,string> kv in _contacto.Comunicacoes)
                if (!ListComunicacoes.Items.Contains(kv))
                    _contacto.RemoverComunicacao(kv.Key, kv.Value);

            foreach (KeyValuePair<string, string> kv in ListComunicacoes.Items)
                if (!_contacto.Comunicacoes.Contains(kv))
                    _contacto.AdicionarComunicacao(kv.Key, kv.Value);
        }

        private void AtualizarEmpresas()
        {
            foreach(string s in _contacto.Empresas)
            {
                if (!ListEmpresas.Items.Contains(s))
                    _contacto.RemoverEmpresa(s);
            }
            foreach (string s in ListEmpresas.Items)
            {
                if (!_contacto.Empresas.Contains(s))
                    _contacto.AdicionarEmpresa(s);
            }
        }

        private bool validarString(string s)
        {
            return !string.IsNullOrWhiteSpace(s) && !string.IsNullOrEmpty(s);
        }

        private bool validarNif(string s)
        {
            int i = 0;
            if (int.TryParse(txtNif.Text, out i))
                if (!(i > 100000000 && i < 999999999))
                {
                    MessageBox.Show("Nif incorreto");
                    return false;
                }
                else
                    return true;
            else
                return string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s);
        }

        private bool validarEntradas()
        {
            if (!validarString(txtNome.Text) || txtNome.Text.Count()<3)
                MessageBox.Show("Tem de ter um Nome com pelo menos três letras");
            return validarNif(txtNif.Text) && validarString(txtNome.Text) && txtNome.Text.Count() >= 3;
        }

        private void txtNif_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar!=(char)0x08;
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
                ShowPanel("A apagar o contacto...");
                _deleted = true;
                while(Contactos.Existe(_contacto.ID))
                    System.Threading.Thread.Sleep(1000);
                this.Close();
            }
        }

        private void btnEAdd_Click(object sender, EventArgs e)
        {
            using (FormPopUpEmpresa z = new FormPopUpEmpresa())
            {
                z.ShowDialog();
                if (z.Empresa != null)
                    if(!ListEmpresas.Items.Contains(z.Empresa))
                        ListEmpresas.Items.Add(z.Empresa);
            }
        }

        private void btnERemov_Click(object sender, EventArgs e)
        {
            if (ListEmpresas.SelectedItem != null)
                ListEmpresas.Items.Remove(ListEmpresas.SelectedItem);
        }

        private void btnCAdd_Click(object sender, EventArgs e)
        {
            using (FormPopUpComunicacao z = new FormPopUpComunicacao())
            {
                z.ShowDialog();
                if (z.Comunicacao != null)
                    if (!ListComunicacoes.Items.Contains(z.Comunicacao))
                        ListComunicacoes.Items.Add(z.Comunicacao);
            }
        }

        private void btnCRemov_Click(object sender, EventArgs e)
        {
            if (ListComunicacoes.SelectedItem !=null)
                ListComunicacoes.Items.Remove(ListComunicacoes.SelectedItem as KeyValuePair<string,string>?);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = _contactoBackup.Nome;
            txtTitulo.Text = _contactoBackup.Titulo;
            txtMorada.Text = _contactoBackup.Morada;
            if (_contactoBackup.Nif != -1)
                txtNif.Text = _contactoBackup.Nif.ToString();
            else
                txtNif.Text = string.Empty;
            checkPublico.Checked = _contactoBackup.Publico;
            ListEmpresas.Items.Clear();
            foreach (string s in Empresas.FindById(_contactoBackup.ID))
                ListEmpresas.Items.Add(s);
            ListComunicacoes.Items.Clear();
            foreach (KeyValuePair<string, string> kv in Comunicacoes.FindById(_contactoBackup.ID))
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
            btnEdit.Text = "Editar";
            btnCancelar.Enabled = false;
            btnCancelar.Visible = false;
            _contacto = new Contacto(_contactoBackup);
        }

        private void FormContacto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!_deleted && !_criado)
            {
                ShowPanel("A guardar alterações...");
                while (!Contactos.Existe(_contacto.ID))
                    System.Threading.Thread.Sleep(1000);
            }
        }

        private void ShowPanel(string s)
        {
            panelBlock.Show();
            panelBlock.Update();
            panelBlock.Location = new Point(0, 0);
            labelR.Text = s;
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            using (FormPopUpLogs z = new FormPopUpLogs(_contacto))
            {
                z.ShowDialog();
            }
        }
    }
}
