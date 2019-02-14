namespace ex2
{
    partial class frmFahrenheit
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
            this.lblMisc2 = new System.Windows.Forms.Label();
            this.txtFah = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMisc1
            // 
            this.lblMisc1.AutoSize = true;
            this.lblMisc1.Location = new System.Drawing.Point(37, 58);
            this.lblMisc1.Name = "lblMisc1";
            this.lblMisc1.Size = new System.Drawing.Size(57, 13);
            this.lblMisc1.TabIndex = 0;
            this.lblMisc1.Text = "Fahrenheit";
            // 
            // lblMisc2
            // 
            this.lblMisc2.AutoSize = true;
            this.lblMisc2.Location = new System.Drawing.Point(40, 132);
            this.lblMisc2.Name = "lblMisc2";
            this.lblMisc2.Size = new System.Drawing.Size(40, 13);
            this.lblMisc2.TabIndex = 1;
            this.lblMisc2.Text = "Celsius";
            // 
            // txtFah
            // 
            this.txtFah.Location = new System.Drawing.Point(100, 55);
            this.txtFah.Name = "txtFah";
            this.txtFah.Size = new System.Drawing.Size(100, 20);
            this.txtFah.TabIndex = 2;
            this.txtFah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFah_KeyPress);
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(100, 129);
            this.txtCel.Name = "txtCel";
            this.txtCel.ReadOnly = true;
            this.txtCel.Size = new System.Drawing.Size(100, 20);
            this.txtCel.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(100, 82);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(100, 156);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar cálculo";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // frmFahrenheit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 218);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.txtFah);
            this.Controls.Add(this.lblMisc2);
            this.Controls.Add(this.lblMisc1);
            this.Name = "frmFahrenheit";
            this.Text = "Celsius - Fahrenheit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMisc1;
        private System.Windows.Forms.Label lblMisc2;
        private System.Windows.Forms.TextBox txtFah;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
    }
}

