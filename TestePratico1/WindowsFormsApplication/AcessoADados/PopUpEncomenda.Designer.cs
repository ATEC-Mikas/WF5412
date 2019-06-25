namespace WindowsFormsApplication.AcessoADados
{
    partial class PopUpEncomenda
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
            this.dgvEncomenda = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncomenda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEncomenda
            // 
            this.dgvEncomenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEncomenda.Location = new System.Drawing.Point(8, 12);
            this.dgvEncomenda.Name = "dgvEncomenda";
            this.dgvEncomenda.Size = new System.Drawing.Size(969, 426);
            this.dgvEncomenda.TabIndex = 0;
            // 
            // PopUpEncomenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.dgvEncomenda);
            this.Name = "PopUpEncomenda";
            this.Text = "PopUpEncomenda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncomenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEncomenda;
    }
}