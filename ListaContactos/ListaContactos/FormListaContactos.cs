﻿using System;
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

        public FormListaContactos()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            ListContacto.DisplayMember = "nome";
            using (FormLogin z = new FormLogin())
            {
                z.ShowDialog();
                if(z.Conta!=null)
                {
                    _conta = new Conta(z.Conta);
                }
            }
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
            Contacto c = ListContacto.SelectedItem as Contacto;
            using (FormContacto z = new FormContacto(c))
            {
                z.ShowDialog();
            }
            btnAtualizar_Click(null,null);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ListContacto.Items.Clear();
            foreach (Contacto c in Contactos.All(_conta))
                ListContacto.Items.Add(c);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FormContacto z = new FormContacto(_conta))
            {
                z.ShowDialog();
            }
            btnAtualizar_Click(null, null);
        }
    }
}
