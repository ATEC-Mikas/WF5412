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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelBlock = new System.Windows.Forms.Panel();
            this.labelR = new System.Windows.Forms.Label();
            this.btnLogs = new System.Windows.Forms.Button();
            this.dataGridComunicacoes = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Informação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.btnMudarFoto = new System.Windows.Forms.Button();
            this.panelBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComunicacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(148, 28);
            this.txtNome.MaxLength = 90;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(204, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(148, 67);
            this.txtNif.MaxLength = 9;
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(100, 20);
            this.txtNif.TabIndex = 2;
            this.txtNif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNif_KeyPress);
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(377, 67);
            this.txtMorada.MaxLength = 90;
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(211, 20);
            this.txtMorada.TabIndex = 3;
            // 
            // checkPublico
            // 
            this.checkPublico.AutoSize = true;
            this.checkPublico.Location = new System.Drawing.Point(148, 93);
            this.checkPublico.Name = "checkPublico";
            this.checkPublico.Size = new System.Drawing.Size(61, 17);
            this.checkPublico.TabIndex = 6;
            this.checkPublico.Text = "Publico";
            this.checkPublico.UseVisualStyleBackColor = true;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(377, 28);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(211, 20);
            this.txtTitulo.TabIndex = 7;
            // 
            // ListEmpresas
            // 
            this.ListEmpresas.FormattingEnabled = true;
            this.ListEmpresas.Location = new System.Drawing.Point(148, 179);
            this.ListEmpresas.Name = "ListEmpresas";
            this.ListEmpresas.Size = new System.Drawing.Size(165, 95);
            this.ListEmpresas.TabIndex = 8;
            // 
            // btnERemov
            // 
            this.btnERemov.Location = new System.Drawing.Point(148, 280);
            this.btnERemov.Name = "btnERemov";
            this.btnERemov.Size = new System.Drawing.Size(85, 23);
            this.btnERemov.TabIndex = 10;
            this.btnERemov.Text = "Remover";
            this.btnERemov.UseVisualStyleBackColor = true;
            this.btnERemov.Click += new System.EventHandler(this.btnERemov_Click);
            // 
            // btnEAdd
            // 
            this.btnEAdd.Location = new System.Drawing.Point(239, 280);
            this.btnEAdd.Name = "btnEAdd";
            this.btnEAdd.Size = new System.Drawing.Size(74, 23);
            this.btnEAdd.TabIndex = 11;
            this.btnEAdd.Text = "Adicionar";
            this.btnEAdd.UseVisualStyleBackColor = true;
            this.btnEAdd.Click += new System.EventHandler(this.btnEAdd_Click);
            // 
            // btnCAdd
            // 
            this.btnCAdd.Location = new System.Drawing.Point(849, 280);
            this.btnCAdd.Name = "btnCAdd";
            this.btnCAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCAdd.TabIndex = 13;
            this.btnCAdd.Text = "Adicionar";
            this.btnCAdd.UseVisualStyleBackColor = true;
            this.btnCAdd.Click += new System.EventHandler(this.btnCAdd_Click);
            // 
            // btnCRemov
            // 
            this.btnCRemov.Location = new System.Drawing.Point(765, 280);
            this.btnCRemov.Name = "btnCRemov";
            this.btnCRemov.Size = new System.Drawing.Size(78, 23);
            this.btnCRemov.TabIndex = 12;
            this.btnCRemov.Text = "Remover";
            this.btnCRemov.UseVisualStyleBackColor = true;
            this.btnCRemov.Click += new System.EventHandler(this.btnCRemov_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "NIF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Titulo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Morada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Empresas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Comunicações";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(836, 41);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(88, 23);
            this.btnFechar.TabIndex = 20;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(742, 41);
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
            this.lblUltimaModific.Location = new System.Drawing.Point(12, 309);
            this.lblUltimaModific.Name = "lblUltimaModific";
            this.lblUltimaModific.Size = new System.Drawing.Size(158, 13);
            this.lblUltimaModific.TabIndex = 22;
            this.lblUltimaModific.Text = "Ultima Vez modificado por: X [Y]\r\n";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(836, 70);
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
            this.lblCriador.Location = new System.Drawing.Point(771, 309);
            this.lblCriador.Name = "lblCriador";
            this.lblCriador.Size = new System.Drawing.Size(59, 13);
            this.lblCriador.TabIndex = 24;
            this.lblCriador.Text = "LBLCriador";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(742, 70);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 23);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelBlock
            // 
            this.panelBlock.Controls.Add(this.labelR);
            this.panelBlock.Location = new System.Drawing.Point(0, 0);
            this.panelBlock.Name = "panelBlock";
            this.panelBlock.Size = new System.Drawing.Size(945, 327);
            this.panelBlock.TabIndex = 27;
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.labelR.Location = new System.Drawing.Point(52, 130);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(164, 39);
            this.labelR.TabIndex = 0;
            this.labelR.Text = "Resposta";
            // 
            // btnLogs
            // 
            this.btnLogs.Location = new System.Drawing.Point(836, 99);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(88, 23);
            this.btnLogs.TabIndex = 28;
            this.btnLogs.Text = "Logs";
            this.btnLogs.UseVisualStyleBackColor = true;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // dataGridComunicacoes
            // 
            this.dataGridComunicacoes.AllowUserToAddRows = false;
            this.dataGridComunicacoes.AllowUserToDeleteRows = false;
            this.dataGridComunicacoes.AllowUserToOrderColumns = true;
            this.dataGridComunicacoes.AllowUserToResizeColumns = false;
            this.dataGridComunicacoes.AllowUserToResizeRows = false;
            this.dataGridComunicacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridComunicacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridComunicacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Informação});
            this.dataGridComunicacoes.Location = new System.Drawing.Point(332, 179);
            this.dataGridComunicacoes.MultiSelect = false;
            this.dataGridComunicacoes.Name = "dataGridComunicacoes";
            this.dataGridComunicacoes.ReadOnly = true;
            this.dataGridComunicacoes.RowHeadersVisible = false;
            this.dataGridComunicacoes.ShowCellErrors = false;
            this.dataGridComunicacoes.ShowCellToolTips = false;
            this.dataGridComunicacoes.ShowEditingIcon = false;
            this.dataGridComunicacoes.ShowRowErrors = false;
            this.dataGridComunicacoes.Size = new System.Drawing.Size(592, 95);
            this.dataGridComunicacoes.TabIndex = 29;
            this.dataGridComunicacoes.TabStop = false;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Informação
            // 
            this.Informação.HeaderText = "Informação";
            this.Informação.Name = "Informação";
            this.Informação.ReadOnly = true;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(12, 14);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(128, 128);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 30;
            this.PictureBox.TabStop = false;
            // 
            // btnMudarFoto
            // 
            this.btnMudarFoto.Location = new System.Drawing.Point(12, 154);
            this.btnMudarFoto.Name = "btnMudarFoto";
            this.btnMudarFoto.Size = new System.Drawing.Size(128, 23);
            this.btnMudarFoto.TabIndex = 31;
            this.btnMudarFoto.Text = "Mudar Fotografia";
            this.btnMudarFoto.UseVisualStyleBackColor = true;
            this.btnMudarFoto.Click += new System.EventHandler(this.btnMudarFoto_Click);
            // 
            // FormContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 329);
            this.Controls.Add(this.panelBlock);
            this.Controls.Add(this.dataGridComunicacoes);
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
            this.Controls.Add(this.ListEmpresas);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.checkPublico);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.txtNif);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLogs);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.btnMudarFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormContacto";
            this.Text = "Contacto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormContacto_FormClosing);
            this.panelBlock.ResumeLayout(false);
            this.panelBlock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComunicacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
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
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panelBlock;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.DataGridView dataGridComunicacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Informação;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button btnMudarFoto;
    }
}