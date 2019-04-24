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
    public partial class FormContacto : Form
    {
        private Contacto _contacto;
        private Contacto _contactoBackup;
        private Conta _conta;

        public FormContacto()
        {
            InitializeComponent();
            grpboxDelete.Visible = false;
            grpboxDelete.Enabled = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            btnCancelar.Visible = false;
            btnCancelar.Enabled = false;
        }

        public FormContacto(Conta c) : this()
        {
            _conta = new Conta(c);
            _contacto = new Contacto(c);
            btnEdit.Text = "Guardar";
            lblUltimaModific.Text = Modificacoes.UltimaMod(_contacto) ?? "";
            lblCriador.Text = $"Criado por {_contacto.Criador.User}";
        }

        public FormContacto(Contacto c,Conta conta)  : this()
        {
            _conta = new Conta(conta);
            _contacto = new Contacto(c);
            _contactoBackup = new Contacto(c);
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

            lblUltimaModific.Text = Modificacoes.UltimaMod(_contacto) ?? "";
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
                btnCancelar.Visible = true;
                btnCancelar.Enabled = true;
            } else
            {
                if(validarEntradas())
                {
                    _contacto.Nome = txtNome.Text;
                    _contacto.Morada = txtMorada.Text;
                    _contacto.Nif = int.Parse(txtNif.Text);
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
                grpboxDelete.Visible = true;
                grpboxDelete.Enabled = true;
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
            if (ListComunicacoes.SelectedIndex != -1)
                ListComunicacoes.Items.RemoveAt(ListEmpresas.SelectedIndex+1);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = _contactoBackup.Nome;
            txtTitulo.Text = _contactoBackup.Titulo;
            txtMorada.Text = _contactoBackup.Morada;
            txtNif.Text = _contactoBackup.Nif.ToString();
            checkPublico.Checked = _contactoBackup.Publico;
            foreach (string s in Empresas.FindById(_contactoBackup.ID))
                ListEmpresas.Items.Add(s);
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
            _contacto = new Contacto(_contactoBackup);
        }
    }
}