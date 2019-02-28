namespace ex4
{
    partial class frmCambioRadioButton
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
            this.radDollar = new System.Windows.Forms.RadioButton();
            this.radSek = new System.Windows.Forms.RadioButton();
            this.radLen = new System.Windows.Forms.RadioButton();
            this.radLib = new System.Windows.Forms.RadioButton();
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
            this.grpModeda.Controls.Add(this.radSek);
            this.grpModeda.Controls.Add(this.radLen);
            this.grpModeda.Controls.Add(this.radLib);
            this.grpModeda.Controls.Add(this.radDollar);
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
            // radDollar
            // 
            this.radDollar.AutoSize = true;
            this.radDollar.Location = new System.Drawing.Point(6, 19);
            this.radDollar.Name = "radDollar";
            this.radDollar.Size = new System.Drawing.Size(52, 17);
            this.radDollar.TabIndex = 5;
            this.radDollar.TabStop = true;
            this.radDollar.Text = "Dollar";
            this.radDollar.UseVisualStyleBackColor = true;
            // 
            // radSek
            // 
            this.radSek.AutoSize = true;
            this.radSek.Location = new System.Drawing.Point(6, 87);
            this.radSek.Name = "radSek";
            this.radSek.Size = new System.Drawing.Size(46, 17);
            this.radSek.TabIndex = 6;
            this.radSek.TabStop = true;
            this.radSek.Text = "SEK";
            this.radSek.UseVisualStyleBackColor = true;
            // 
            // radLen
            // 
            this.radLen.AutoSize = true;
            this.radLen.Location = new System.Drawing.Point(6, 64);
            this.radLen.Name = "radLen";
            this.radLen.Size = new System.Drawing.Size(49, 17);
            this.radLen.TabIndex = 7;
            this.radLen.TabStop = true;
            this.radLen.Text = "Léne";
            this.radLen.UseVisualStyleBackColor = true;
            // 
            // radLib
            // 
            this.radLib.AutoSize = true;
            this.radLib.Location = new System.Drawing.Point(6, 41);
            this.radLib.Name = "radLib";
            this.radLib.Size = new System.Drawing.Size(48, 17);
            this.radLib.TabIndex = 8;
            this.radLib.TabStop = true;
            this.radLib.Text = "Libra";
            this.radLib.UseVisualStyleBackColor = true;
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
            this.Load += new System.EventHandler(this.frmCambioRadioButton_Load);
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
        private System.Windows.Forms.RadioButton radSek;
        private System.Windows.Forms.RadioButton radLen;
        private System.Windows.Forms.RadioButton radLib;
        private System.Windows.Forms.RadioButton radDollar;
        private System.Windows.Forms.Button btnConverter;
    }
}