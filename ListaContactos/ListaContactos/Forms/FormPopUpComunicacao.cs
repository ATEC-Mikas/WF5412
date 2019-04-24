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
    public partial class FormPopUpComunicacao : Form
    {
        private KeyValuePair<string, string>? _kv;
        public KeyValuePair<string, string>? Comunicacao { get{ return _kv; } }
        public FormPopUpComunicacao()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            _kv = null;
            foreach(KeyValuePair<string,string> kv in Comunicacoes.GetTipos())
                cbTipo.Items.Add(kv.Value);
        }

        private void btnCAdd_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtCom.Text) && !string.IsNullOrWhiteSpace(txtCom.Text) && (cbTipo.SelectedItem!=null || (!string.IsNullOrEmpty(cbTipo.SelectedItem as string) && !string.IsNullOrWhiteSpace(cbTipo.SelectedItem as string)) ))
            {
                _kv = new KeyValuePair<string, string>(cbTipo.SelectedItem as string, txtCom.Text);
                this.Close();
            } 
        }

        private void btnTCriar_Click(object sender, EventArgs e)
        {
            using (FormPopUpAddTipo z = new FormPopUpAddTipo())
            {
                z.ShowDialog();
                cbTipo.Items.Clear();
                foreach (KeyValuePair<string, string> kv in Comunicacoes.GetTipos())
                    cbTipo.Items.Add(kv.Value);
            }
        }
    }
}
