namespace ListaContactos
{
    partial class FormListaContactos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.ListContacto = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.checkFiltros = new System.Windows.Forms.CheckBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.checkPublico = new System.Windows.Forms.CheckBox();
            this.checkPub = new System.Windows.Forms.CheckBox();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtComunicacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.lblConta = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDefinicoes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione um contacto";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(247, 494);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // ListContacto
            // 
            this.ListContacto.FormattingEnabled = true;
            this.ListContacto.Location = new System.Drawing.Point(-1, 33);
            this.ListContacto.Name = "ListContacto";
            this.ListContacto.Size = new System.Drawing.Size(323, 459);
            this.ListContacto.TabIndex = 2;
            this.ListContacto.DoubleClick += new System.EventHandler(this.ListContacto_DoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(166, 494);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // checkFiltros
            // 
            this.checkFiltros.AutoSize = true;
            this.checkFiltros.Location = new System.Drawing.Point(328, 33);
            this.checkFiltros.Name = "checkFiltros";
            this.checkFiltros.Size = new System.Drawing.Size(53, 17);
            this.checkFiltros.TabIndex = 4;
            this.checkFiltros.Text = "Filtros";
            this.checkFiltros.UseVisualStyleBackColor = true;
            this.checkFiltros.CheckedChanged += new System.EventHandler(this.checkFiltros_CheckedChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(409, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(409, 82);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 6;
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(409, 108);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(100, 20);
            this.txtMorada.TabIndex = 7;
            // 
            // checkPublico
            // 
            this.checkPublico.AutoSize = true;
            this.checkPublico.Enabled = false;
            this.checkPublico.Location = new System.Drawing.Point(409, 160);
            this.checkPublico.Name = "checkPublico";
            this.checkPublico.Size = new System.Drawing.Size(61, 17);
            this.checkPublico.TabIndex = 8;
            this.checkPublico.Text = "Publico";
            this.checkPublico.UseVisualStyleBackColor = true;
            // 
            // checkPub
            // 
            this.checkPub.AutoSize = true;
            this.checkPub.Location = new System.Drawing.Point(386, 161);
            this.checkPub.Name = "checkPub";
            this.checkPub.Size = new System.Drawing.Size(15, 14);
            this.checkPub.TabIndex = 9;
            this.checkPub.UseVisualStyleBackColor = true;
            this.checkPub.CheckedChanged += new System.EventHandler(this.checkPub_CheckedChanged);
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(409, 134);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(100, 20);
            this.txtNif.TabIndex = 10;
            this.txtNif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nif_KeyPress);
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(409, 192);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(100, 20);
            this.txtEmpresa.TabIndex = 11;
            // 
            // txtComunicacao
            // 
            this.txtComunicacao.Location = new System.Drawing.Point(409, 234);
            this.txtComunicacao.Name = "txtComunicacao";
            this.txtComunicacao.Size = new System.Drawing.Size(100, 20);
            this.txtComunicacao.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Titulo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Morada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "NIF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Empresa \r\nAssociada:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 26);
            this.label7.TabIndex = 18;
            this.label7.Text = "Comunicacao\r\nAssociada:";
            // 
            // panelFiltros
            // 
            this.panelFiltros.Location = new System.Drawing.Point(328, 50);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(192, 246);
            this.panelFiltros.TabIndex = 19;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(332, 273);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(177, 23);
            this.btnProcurar.TabIndex = 20;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(329, 341);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(111, 13);
            this.lblConta.TabIndex = 21;
            this.lblConta.Text = "Bem Vindo %Conta% !";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(332, 494);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(177, 23);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDefinicoes
            // 
            this.btnDefinicoes.Location = new System.Drawing.Point(332, 465);
            this.btnDefinicoes.Name = "btnDefinicoes";
            this.btnDefinicoes.Size = new System.Drawing.Size(177, 23);
            this.btnDefinicoes.TabIndex = 23;
            this.btnDefinicoes.Text = "Definições de Conta";
            this.btnDefinicoes.UseVisualStyleBackColor = true;
            this.btnDefinicoes.Click += new System.EventHandler(this.btnDefinicoes_Click);
            // 
            // FormListaContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 519);
            this.Controls.Add(this.btnDefinicoes);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtComunicacao);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.txtNif);
            this.Controls.Add(this.checkPub);
            this.Controls.Add(this.checkPublico);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.checkFiltros);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ListContacto);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProcurar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormListaContactos";
            this.Text = "Lista de Contactos";
            this.Load += new System.EventHandler(this.FormListaContactos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.ListBox ListContacto;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox checkFiltros;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.CheckBox checkPublico;
        private System.Windows.Forms.CheckBox checkPub;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtComunicacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDefinicoes;
    }
}