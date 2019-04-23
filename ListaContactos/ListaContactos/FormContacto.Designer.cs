namespace ListaContactos
{
    partial class FormContacto
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.checkPublico = new System.Windows.Forms.CheckBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.ListEmpresas = new System.Windows.Forms.ListBox();
            this.ListComunicacoes = new System.Windows.Forms.ListBox();
            this.btnERemov = new System.Windows.Forms.Button();
            this.btnEAdd = new System.Windows.Forms.Button();
            this.btnCAdd = new System.Windows.Forms.Button();
            this.btnCRemov = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblUltimaModific = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCriador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 25);
            this.txtNome.MaxLength = 90;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(204, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(12, 64);
            this.txtNif.MaxLength = 9;
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(100, 20);
            this.txtNif.TabIndex = 2;
            this.txtNif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNif_KeyPress);
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(241, 64);
            this.txtMorada.MaxLength = 90;
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(211, 20);
            this.txtMorada.TabIndex = 3;
            // 
            // checkPublico
            // 
            this.checkPublico.AutoSize = true;
            this.checkPublico.Location = new System.Drawing.Point(12, 90);
            this.checkPublico.Name = "checkPublico";
            this.checkPublico.Size = new System.Drawing.Size(61, 17);
            this.checkPublico.TabIndex = 6;
            this.checkPublico.Text = "Publico";
            this.checkPublico.UseVisualStyleBackColor = true;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(241, 25);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(211, 20);
            this.txtTitulo.TabIndex = 7;
            // 
            // ListEmpresas
            // 
            this.ListEmpresas.FormattingEnabled = true;
            this.ListEmpresas.Location = new System.Drawing.Point(12, 176);
            this.ListEmpresas.Name = "ListEmpresas";
            this.ListEmpresas.Size = new System.Drawing.Size(165, 95);
            this.ListEmpresas.TabIndex = 8;
            // 
            // ListComunicacoes
            // 
            this.ListComunicacoes.FormattingEnabled = true;
            this.ListComunicacoes.Location = new System.Drawing.Point(196, 176);
            this.ListComunicacoes.Name = "ListComunicacoes";
            this.ListComunicacoes.Size = new System.Drawing.Size(207, 95);
            this.ListComunicacoes.TabIndex = 9;
            // 
            // btnERemov
            // 
            this.btnERemov.Location = new System.Drawing.Point(12, 277);
            this.btnERemov.Name = "btnERemov";
            this.btnERemov.Size = new System.Drawing.Size(85, 23);
            this.btnERemov.TabIndex = 10;
            this.btnERemov.Text = "Remover";
            this.btnERemov.UseVisualStyleBackColor = true;
            // 
            // btnEAdd
            // 
            this.btnEAdd.Location = new System.Drawing.Point(103, 277);
            this.btnEAdd.Name = "btnEAdd";
            this.btnEAdd.Size = new System.Drawing.Size(74, 23);
            this.btnEAdd.TabIndex = 11;
            this.btnEAdd.Text = "Adicionar";
            this.btnEAdd.UseVisualStyleBackColor = true;
            // 
            // btnCAdd
            // 
            this.btnCAdd.Location = new System.Drawing.Point(328, 277);
            this.btnCAdd.Name = "btnCAdd";
            this.btnCAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCAdd.TabIndex = 13;
            this.btnCAdd.Text = "Adicionar";
            this.btnCAdd.UseVisualStyleBackColor = true;
            // 
            // btnCRemov
            // 
            this.btnCRemov.Location = new System.Drawing.Point(196, 277);
            this.btnCRemov.Name = "btnCRemov";
            this.btnCRemov.Size = new System.Drawing.Size(126, 23);
            this.btnCRemov.TabIndex = 12;
            this.btnCRemov.Text = "Remover";
            this.btnCRemov.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "NIF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Titulo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Morada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Empresas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Comunicações";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(700, 9);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(88, 23);
            this.btnFechar.TabIndex = 20;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(606, 9);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 23);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblUltimaModific
            // 
            this.lblUltimaModific.AutoSize = true;
            this.lblUltimaModific.Location = new System.Drawing.Point(417, 258);
            this.lblUltimaModific.Name = "lblUltimaModific";
            this.lblUltimaModific.Size = new System.Drawing.Size(158, 13);
            this.lblUltimaModific.TabIndex = 22;
            this.lblUltimaModific.Text = "Ultima Vez modificado por: X [Y]\r\n";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(700, 38);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblCriador
            // 
            this.lblCriador.AutoSize = true;
            this.lblCriador.Location = new System.Drawing.Point(417, 287);
            this.lblCriador.Name = "lblCriador";
            this.lblCriador.Size = new System.Drawing.Size(35, 13);
            this.lblCriador.TabIndex = 24;
            this.lblCriador.Text = "label1";
            // 
            // FormContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 313);
            this.Controls.Add(this.lblCriador);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblUltimaModific);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCAdd);
            this.Controls.Add(this.btnCRemov);
            this.Controls.Add(this.btnEAdd);
            this.Controls.Add(this.btnERemov);
            this.Controls.Add(this.ListComunicacoes);
            this.Controls.Add(this.ListEmpresas);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.checkPublico);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.txtNif);
            this.Controls.Add(this.txtNome);
            this.Name = "FormContacto";
            this.Text = "FormContacto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.CheckBox checkPublico;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ListBox ListEmpresas;
        private System.Windows.Forms.ListBox ListComunicacoes;
        private System.Windows.Forms.Button btnERemov;
        private System.Windows.Forms.Button btnEAdd;
        private System.Windows.Forms.Button btnCAdd;
        private System.Windows.Forms.Button btnCRemov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblUltimaModific;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblCriador;
    }
}