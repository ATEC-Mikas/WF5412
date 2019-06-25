namespace WindowsFormsApplication.AcessoADados
{
    partial class frmListarEncomendasClientes
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
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.btnVerEncomendas = new System.Windows.Forms.Button();
            this.dgvEncomendas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerContacto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncomendas)).BeginInit();
            this.SuspendLayout();
            // 
            // cboClientes
            // 
            this.cboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(12, 57);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(324, 21);
            this.cboClientes.TabIndex = 0;
            // 
            // btnVerEncomendas
            // 
            this.btnVerEncomendas.Location = new System.Drawing.Point(342, 55);
            this.btnVerEncomendas.Name = "btnVerEncomendas";
            this.btnVerEncomendas.Size = new System.Drawing.Size(104, 23);
            this.btnVerEncomendas.TabIndex = 1;
            this.btnVerEncomendas.Text = "Ver Encomendas";
            this.btnVerEncomendas.UseVisualStyleBackColor = true;
            this.btnVerEncomendas.Click += new System.EventHandler(this.BtnVerEncomendas_Click);
            // 
            // dgvEncomendas
            // 
            this.dgvEncomendas.AllowUserToAddRows = false;
            this.dgvEncomendas.AllowUserToDeleteRows = false;
            this.dgvEncomendas.AllowUserToResizeRows = false;
            this.dgvEncomendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEncomendas.Location = new System.Drawing.Point(12, 84);
            this.dgvEncomendas.MultiSelect = false;
            this.dgvEncomendas.Name = "dgvEncomendas";
            this.dgvEncomendas.ReadOnly = true;
            this.dgvEncomendas.Size = new System.Drawing.Size(592, 289);
            this.dgvEncomendas.TabIndex = 2;
            this.dgvEncomendas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEncomendas_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Cliente";
            // 
            // btnVerContacto
            // 
            this.btnVerContacto.Location = new System.Drawing.Point(452, 55);
            this.btnVerContacto.Name = "btnVerContacto";
            this.btnVerContacto.Size = new System.Drawing.Size(104, 23);
            this.btnVerContacto.TabIndex = 4;
            this.btnVerContacto.Text = "Ver Contacto";
            this.btnVerContacto.UseVisualStyleBackColor = true;
            this.btnVerContacto.Click += new System.EventHandler(this.BtnVerContacto_Click);
            // 
            // frmListarEncomendasClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 385);
            this.Controls.Add(this.btnVerContacto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEncomendas);
            this.Controls.Add(this.btnVerEncomendas);
            this.Controls.Add(this.cboClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmListarEncomendasClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Encomendas de Clientes";
            this.Load += new System.EventHandler(this.frmListarEncomendasClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncomendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.Button btnVerEncomendas;
        private System.Windows.Forms.DataGridView dgvEncomendas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerContacto;
    }
}