namespace TesteClasses_Forms
{
    partial class FormTeste
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
            this.GRPEditora = new System.Windows.Forms.GroupBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.btnCriarEditora = new System.Windows.Forms.Button();
            this.ListEditora = new System.Windows.Forms.ListBox();
            this.GRPEditora.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRPEditora
            // 
            this.GRPEditora.Controls.Add(this.ListEditora);
            this.GRPEditora.Controls.Add(this.btnCriarEditora);
            this.GRPEditora.Controls.Add(this.txtEditora);
            this.GRPEditora.Location = new System.Drawing.Point(12, 12);
            this.GRPEditora.Name = "GRPEditora";
            this.GRPEditora.Size = new System.Drawing.Size(231, 149);
            this.GRPEditora.TabIndex = 1;
            this.GRPEditora.TabStop = false;
            this.GRPEditora.Text = "Editoras";
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(7, 20);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(137, 20);
            this.txtEditora.TabIndex = 0;
            // 
            // btnCriarEditora
            // 
            this.btnCriarEditora.Location = new System.Drawing.Point(150, 18);
            this.btnCriarEditora.Name = "btnCriarEditora";
            this.btnCriarEditora.Size = new System.Drawing.Size(75, 23);
            this.btnCriarEditora.TabIndex = 1;
            this.btnCriarEditora.Text = "Criar";
            this.btnCriarEditora.UseVisualStyleBackColor = true;
            this.btnCriarEditora.Click += new System.EventHandler(this.btnCriarEditora_Click);
            // 
            // ListEditora
            // 
            this.ListEditora.FormattingEnabled = true;
            this.ListEditora.Location = new System.Drawing.Point(7, 47);
            this.ListEditora.Name = "ListEditora";
            this.ListEditora.Size = new System.Drawing.Size(218, 95);
            this.ListEditora.TabIndex = 2;
            // 
            // FormTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 451);
            this.Controls.Add(this.GRPEditora);
            this.Name = "FormTeste";
            this.Text = "Form Teste Classes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GRPEditora.ResumeLayout(false);
            this.GRPEditora.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GRPEditora;
        private System.Windows.Forms.ListBox ListEditora;
        private System.Windows.Forms.Button btnCriarEditora;
        private System.Windows.Forms.TextBox txtEditora;
    }
}

