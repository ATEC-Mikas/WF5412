using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListaContactos
{
    public partial class FormContacto : Form
    {
        private Contacto _contacto;
        private Contacto _contactoBackup;
        private Conta _conta;
        private bool _deleted;
        private bool _criado;
        private bool _fotonova;

        public FormContacto()
        {
            InitializeComponent();
            panelBlock.Visible = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            btnCancelar.Visible = false;
            btnCancelar.Enabled = false;
            _deleted = false;
            openFile.Filter = "JPEG Picture (*.jpg)|*.jpg|PNG (*.png)|*.png";
            _fotonova = false;
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
            CarregarFoto(_contacto.Foto);
        }

        public FormContacto(Contacto c,Conta conta)  : this()
        {
            _conta = new Conta(conta);
            _contacto = new Contacto(c);
            _contactoBackup = new Contacto(c);
            txtNome.Text = _contacto.Nome;
            txtTitulo.Text = _contacto.Titulo;
            txtMorada.Text = _contacto.Morada;
            CarregarFoto(c.Foto);
            if (_contacto.Nif != -1)
                txtNif.Text = _contacto.Nif.ToString();
            else
                txtNif.Text = string.Empty;
            checkPublico.Checked = _contacto.Publico;
            foreach (string s in Empresas.FindById(_contacto.ID))
                ListEmpresas.Items.Add(s);
            foreach (KeyValuePair<string, string> kv in Comunicacoes.FindById(_contacto.ID))
                //ListComunicacoes.Items.Add(kv);
                dataGridComunicacoes.Rows.Add(kv.Key, kv.Value);
            txtNome.Enabled = false;
            txtMorada.Enabled = false;
            txtNif.Enabled = false;
            txtTitulo.Enabled = false;
            checkPublico.Enabled = false;
            btnCAdd.Enabled = false;
            btnCRemov.Enabled = false;
            btnEAdd.Enabled = false;
            btnERemov.Enabled = false;
            btnMudarFoto.Enabled = false;

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
        
        private void CarregarFoto(string l)
        {
            PictureBox.ImageLocation = $"db\\imgs\\{l}";
            PictureBox.Load();
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
                {
                    checkPublico.Enabled = true;
                    btnMudarFoto.Enabled = true;
                }
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
                    if(isEntradasIguais())
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
                        btnMudarFoto.Enabled = false;
                        btnEdit.Text = "Editar";
                        MessageBox.Show("Não houve nenhuma alteração.");
                    } else 
                    if(_contacto.save(_conta))
                    {
                        _criado = false;
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
                        btnMudarFoto.Enabled = false; ;
                        if (_fotonova)
                        {
                            GuardarFoto();
                            CarregarFoto(_contacto.Foto);
                        }
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
                if (!GetKVFromDataGrid().Contains(kv))
                    _contacto.RemoverComunicacao(kv.Key, kv.Value);

            foreach (KeyValuePair<string, string> kv in GetKVFromDataGrid())
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

        private List<KeyValuePair<string,string>> GetKVFromDataGrid()
        {
            List<KeyValuePair<string, string>> kv = new List<KeyValuePair<string, string>>();

            foreach (DataGridViewRow c in dataGridComunicacoes.Rows)
                kv.Add(new KeyValuePair<string, string>(c.Cells[0].Value as string, c.Cells[1].Value as string));

            return kv;
        }

        private void btnCAdd_Click(object sender, EventArgs e)
        {
            using (FormPopUpComunicacao z = new FormPopUpComunicacao())
            {
                z.ShowDialog();
                if (z.Comunicacao != null)
                    if (!GetKVFromDataGrid().Contains(z.Comunicacao.Value))
                        dataGridComunicacoes.Rows.Add(z.Comunicacao.Value.Key, z.Comunicacao.Value.Value);
                        //ListComunicacoes.Items.Add(z.Comunicacao);
            }
        }

        private void btnCRemov_Click(object sender, EventArgs e)
        {
            if (dataGridComunicacoes.SelectedCells != null)
                dataGridComunicacoes.Rows.Remove(dataGridComunicacoes.SelectedCells[0].OwningRow);
                //ListComunicacoes.Items.Remove(ListComunicacoes.SelectedItem as KeyValuePair<string,string>?);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CarregarFoto(_contactoBackup.Foto);
            ApagarFotoTemp();
            _fotonova = false;
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
            dataGridComunicacoes.Rows.Clear();
            foreach (KeyValuePair<string, string> kv in Comunicacoes.FindById(_contactoBackup.ID))
                dataGridComunicacoes.Rows.Add(kv.Key, kv.Value);
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
            labelR.Text = s;
            panelBlock.Show();
            panelBlock.Update();
            panelBlock.Location = new Point(0, 0);
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            using (FormPopUpLogs z = new FormPopUpLogs(_contacto))
            {
                z.ShowDialog();
            }
        }

        private bool CompareList<T>(List<T> x,List<T> y)
        {
            var a = x.Except(y).ToList();
            var b = y.Except(x).ToList();

            return !a.Any() && !b.Any(); 
        }

        private bool isEntradasIguais()
        {
            if (_criado)
                return false;
            return _contacto.Nome == _contactoBackup.Nome
                   && _contacto.Morada == _contactoBackup.Morada
                   && _contacto.Nif == _contactoBackup.Nif
                   && _contacto.Titulo == _contactoBackup.Titulo
                   && _contacto.Publico == _contactoBackup.Publico
                   && CompareList(_contacto.Empresas, _contactoBackup.Empresas)
                   && CompareList(_contacto.Comunicacoes, _contactoBackup.Comunicacoes)
                   && !_fotonova;
        }

        private void btnMudarFoto_Click(object sender, EventArgs e)
        {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    _fotonova = true;
                    string[] r = openFile.SafeFileName.Split('.');

                    if(!Directory.Exists("db/imgs/temp/"))
                        Directory.CreateDirectory("db/imgs/temp/");

                    _contacto.Foto = $"{_contacto.ID}.{r[r.Length - 1]}";
                    MessageBox.Show(_contacto.Foto);
                    ApagarFotoTemp();
                    File.Copy(openFile.FileName, $"db/imgs/temp/{_contacto.Foto}");
                    CarregarFoto($"temp/{_contacto.Foto}");
                }

        }

        private void ApagarFotoTemp()
        {
            if (File.Exists($"db/imgs/temp/{_contacto.Foto}"))
                File.Delete($"db/imgs/temp/{_contacto.Foto}");
        }

        private void GuardarFoto()
        {
            if (File.Exists($"db/imgs/{_contacto.ID}.png"))
                File.Delete($"db/imgs/{_contacto.ID}.png");
            if (File.Exists($"db/imgs/{_contacto.ID}.jpg"))
                File.Delete($"db/imgs/{_contacto.ID}.jpg");
            File.Copy($"db/imgs/temp/{_contacto.Foto}", $"db/imgs/{_contacto.Foto}");
            CarregarFoto(_contactoBackup.Foto);
            ApagarFotoTemp();
        }
    }
}
