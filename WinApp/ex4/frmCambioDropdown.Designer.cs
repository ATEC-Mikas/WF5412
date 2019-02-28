namespace ex4
{
    partial class frmCambioDropdown
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
            this.btnConverter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMoeda = new System.Windows.Forms.ComboBox();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Moeda";
            // 
            // cbMoeda
            // 
            this.cbMoeda.FormattingEnabled = true;
            this.cbMoeda.Items.AddRange(new object[] {
            "Dollar",
            "Iéne",
            "Libra",
            "Sek"});
            this.cbMoeda.Location = new System.Drawing.Point(163, 34);
            this.cbMoeda.Name = "cbMoeda";
            this.cbMoeda.Size = new System.Drawing.Size(121, 21);
            this.cbMoeda.TabIndex = 6;
            this.cbMoeda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMoeda_KeyPress);
            // 
            // frmCambioDropdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 175);
            this.Controls.Add(this.cbMoeda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtEur);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblMisc1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCambioDropdown";
            this.Text = "frmCambioCheckbox";
            this.Load += new System.EventHandler(this.frmCambioDropdown_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMisc1;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.TextBox txtEur;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMoeda;
    }
}