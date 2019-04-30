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
    public partial class FormListaContactos : Form
    {
        private Conta _conta;
        private bool _logout;
        public bool Logout { get { return _logout; } }

        private FormListaContactos()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            ListContacto.DisplayMember = "value";
            _logout = false;
        }

        public FormListaContactos(Conta c) : this()
        {
            _conta = new Conta(c);
            lblConta.Text = lblConta.Text.Replace("%Conta%", c.Nome);
        }

        private void FormListaContactos_Load(object sender, EventArgs e)
        {
            if (_conta == null)
            {
                this.Close();
            } else
            {
                btnAtualizar_Click(null, null);
            }
        }

        private void ListContacto_DoubleClick(object sender, EventArgs e)
        {
            if(ListContacto.SelectedItem!=null)
            {
                Contacto c = new Contacto(Contactos.FindById((ListContacto.SelectedItem as KeyValuePair<string,string>?).Value.Key));
                using (FormContacto z = new FormContacto(c,_conta))
                {
                    z.ShowDialog();
                }
                btnAtualizar_Click(null,null);
            }
        }
        private bool validarString(string s)
        {
            return !string.IsNullOrEmpty(s) && !string.IsNullOrWhiteSpace(s);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if(checkFiltros.Checked)
            {
                List<KeyValuePair<string, string>> filtros = new List<KeyValuePair<string, string>>();
                if (validarString(txtNome.Text))
                    filtros.Add(new KeyValuePair<string, string>("nome", txtNome.Text));
                if (validarString(txtTitulo.Text))
                    filtros.Add(new KeyValuePair<string, string>("titulo", txtTitulo.Text));
                if (validarString(txtMorada.Text))
                    filtros.Add(new KeyValuePair<string, string>("morada", txtMorada.Text));
                if(validarString(txtNif.Text))
                    filtros.Add(new KeyValuePair<string, string>("nif", txtNif.Text));
                if (validarString(txtComunicacao.Text))
                    filtros.Add(new KeyValuePair<string, string>("comunicacao", txtComunicacao.Text));
                if (validarString(txtEmpresa.Text))
                    filtros.Add(new KeyValuePair<string, string>("empresa", txtEmpresa.Text));
                if(checkPub.Checked)
                    filtros.Add(new KeyValuePair<string, string>("publico", checkPublico.Checked.ToString()));

                ListContacto.Items.Clear();
                foreach (KeyValuePair<string, string> c in Contactos.AllForListFiltered(_conta, filtros))
                    ListContacto.Items.Add(c);
            }
            else
            {
            ListContacto.Items.Clear();
            foreach (KeyValuePair<string,string> c in Contactos.AllForList(_conta))
                ListContacto.Items.Add(c);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FormContacto z = new FormContacto(_conta))
            {
                z.ShowDialog();
            }
            btnAtualizar_Click(null, null);
        }

        private void checkPub_CheckedChanged(object sender, EventArgs e)
        {
            checkPublico.Enabled = checkPub.Checked;
        }

        private void checkFiltros_CheckedChanged(object sender, EventArgs e)
        {
            panelFiltros.Visible = !checkFiltros.Checked;
        }

        private void Nif_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char)0x08;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _logout = true;
            this.Close();
        }

        private void btnDefinicoes_Click(object sender, EventArgs e)
        {
            
        }
    }
}
