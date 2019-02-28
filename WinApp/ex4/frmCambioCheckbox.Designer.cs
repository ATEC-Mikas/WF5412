namespace ex4
{
    partial class frmCambioCheckbox
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
            this.lblMisc1 = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.txtEur = new System.Windows.Forms.TextBox();
            this.grpModeda = new System.Windows.Forms.GroupBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.cbDollar = new System.Windows.Forms.CheckBox();
            this.cbLibra = new System.Windows.Forms.CheckBox();
            this.cbIene = new System.Windows.Forms.CheckBox();
            this.cbSek = new System.Windows.Forms.CheckBox();
            this.grpModeda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMisc1
            // 
            this.lblMisc1.AutoSize = true;
            this.lblMisc1.Location = new System.Drawing.Point(12, 12);
            this.lblMisc1.Name = "lblMisc1";
            this.lblMisc1.Size = new System.Drawing.Size(57, 13);
            this.lblMisc1.TabIndex = 0;
            this.lblMisc1.Text = "Valor em €";
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(12, 101);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(35, 13);
            this.lblResposta.TabIndex = 1;
            this.lblResposta.Text = "label2";
            // 
            // txtEur
            // 
            this.txtEur.Location = new System.Drawing.Point(12, 34);
            this.txtEur.Name = "txtEur";
            this.txtEur.Size = new System.Drawing.Size(100, 20);
            this.txtEur.TabIndex = 2;
            this.txtEur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHandle);
            // 
            // grpModeda
            // 
            this.grpModeda.Controls.Add(this.cbSek);
            this.grpModeda.Controls.Add(this.cbIene);
            this.grpModeda.Controls.Add(this.cbLibra);
            this.grpModeda.Controls.Add(this.cbDollar);
            this.grpModeda.Location = new System.Drawing.Point(171, 12);
            this.grpModeda.Name = "grpModeda";
            this.grpModeda.Size = new System.Drawing.Size(113, 128);
            this.grpModeda.TabIndex = 3;
            this.grpModeda.TabStop = false;
            this.grpModeda.Text = "Moeda";
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(12, 70);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(100, 23);
            this.btnConverter.TabIndex = 4;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // cbDollar
            // 
            this.cbDollar.AutoSize = true;
            this.cbDollar.Location = new System.Drawing.Point(7, 22);
            this.cbDollar.Name = "cbDollar";
            this.cbDollar.Size = new System.Drawing.Size(53, 17);
            this.cbDollar.TabIndex = 0;
            this.cbDollar.Text = "Dollar";
            this.cbDollar.UseVisualStyleBackColor = true;
            // 
            // cbLibra
            // 
            this.cbLibra.AutoSize = true;
            this.cbLibra.Location = new System.Drawing.Point(7, 41);
            this.cbLibra.Name = "cbLibra";
            this.cbLibra.Size = new System.Drawing.Size(49, 17);
            this.cbLibra.TabIndex = 1;
            this.cbLibra.Text = "Libra";
            this.cbLibra.UseVisualStyleBackColor = true;
            // 
            // cbIene
            // 
            this.cbIene.AutoSize = true;
            this.cbIene.Location = new System.Drawing.Point(7, 64);
            this.cbIene.Name = "cbIene";
            this.cbIene.Size = new System.Drawing.Size(47, 17);
            this.cbIene.TabIndex = 2;
            this.cbIene.Text = "Iéne";
            this.cbIene.UseVisualStyleBackColor = true;
            // 
            // cbSek
            // 
            this.cbSek.AutoSize = true;
            this.cbSek.Location = new System.Drawing.Point(7, 87);
            this.cbSek.Name = "cbSek";
            this.cbSek.Size = new System.Drawing.Size(47, 17);
            this.cbSek.TabIndex = 3;
            this.cbSek.Text = "SEK";
            this.cbSek.UseVisualStyleBackColor = true;
            // 
            // frmCambioCheckbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 175);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.grpModeda);
            this.Controls.Add(this.txtEur);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblMisc1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCambioCheckbox";
            this.Text = "frmCambioCheckbox";
            this.Load += new System.EventHandler(this.frmCambioCheckbox_Load);
            this.grpModeda.ResumeLayout(false);
            this.grpModeda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMisc1;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.TextBox txtEur;
        private System.Windows.Forms.GroupBox grpModeda;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.CheckBox cbSek;
        private System.Windows.Forms.CheckBox cbIene;
        private System.Windows.Forms.CheckBox cbLibra;
        private System.Windows.Forms.CheckBox cbDollar;
    }
}