namespace ListaContactos
{
    partial class FormPopUpLogs
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
            this.DataGridLogs = new System.Windows.Forms.DataGridView();
            this.Modificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelNContacto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridLogs
            // 
            this.DataGridLogs.AllowUserToAddRows = false;
            this.DataGridLogs.AllowUserToDeleteRows = false;
            this.DataGridLogs.AllowUserToResizeColumns = false;
            this.DataGridLogs.AllowUserToResizeRows = false;
            this.DataGridLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificador,
            this.Hora});
            this.DataGridLogs.Location = new System.Drawing.Point(12, 82);
            this.DataGridLogs.MultiSelect = false;
            this.DataGridLogs.Name = "DataGridLogs";
            this.DataGridLogs.ReadOnly = true;
            this.DataGridLogs.RowHeadersVisible = false;
            this.DataGridLogs.Size = new System.Drawing.Size(776, 199);
            this.DataGridLogs.TabIndex = 0;
            // 
            // Modificador
            // 
            this.Modificador.HeaderText = "Modificador";
            this.Modificador.Name = "Modificador";
            this.Modificador.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // labelNContacto
            // 
            this.labelNContacto.AutoSize = true;
            this.labelNContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelNContacto.Location = new System.Drawing.Point(6, 25);
            this.labelNContacto.Name = "labelNContacto";
            this.labelNContacto.Size = new System.Drawing.Size(275, 31);
            this.labelNContacto.TabIndex = 1;
            this.labelNContacto.Text = "Logs do %Contacto%";
            // 
            // FormPopUpLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 293);
            this.Controls.Add(this.labelNContacto);
            this.Controls.Add(this.DataGridLogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPopUpLogs";
            this.Text = "Modificações do Contacto";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.Label labelNContacto;
    }
}