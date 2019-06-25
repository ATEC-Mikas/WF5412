namespace WindowsFormsApplication.Outros
{
    partial class frmSomaDeNumeros
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
            this.btnSomaNumeros = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbPar = new System.Windows.Forms.RadioButton();
            this.rdbImpar = new System.Windows.Forms.RadioButton();
            this.lblSoma = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSomaNumeros
            // 
            this.btnSomaNumeros.Location = new System.Drawing.Point(135, 27);
            this.btnSomaNumeros.Name = "btnSomaNumeros";
            this.btnSomaNumeros.Size = new System.Drawing.Size(100, 32);
            this.btnSomaNumeros.TabIndex = 0;
            this.btnSomaNumeros.Text = "Soma Números";
            this.btnSomaNumeros.UseVisualStyleBackColor = true;
            this.btnSomaNumeros.Click += new System.EventHandler(this.btnSomaNumeros_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbImpar);
            this.groupBox1.Controls.Add(this.rdbPar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Par / Ímpar";
            // 
            // rdbPar
            // 
            this.rdbPar.AutoSize = true;
            this.rdbPar.Location = new System.Drawing.Point(6, 30);
            this.rdbPar.Name = "rdbPar";
            this.rdbPar.Size = new System.Drawing.Size(41, 17);
            this.rdbPar.TabIndex = 0;
            this.rdbPar.TabStop = true;
            this.rdbPar.Text = "Par";
            this.rdbPar.UseVisualStyleBackColor = true;
            // 
            // rdbImpar
            // 
            this.rdbImpar.AutoSize = true;
            this.rdbImpar.Location = new System.Drawing.Point(6, 53);
            this.rdbImpar.Name = "rdbImpar";
            this.rdbImpar.Size = new System.Drawing.Size(51, 17);
            this.rdbImpar.TabIndex = 1;
            this.rdbImpar.TabStop = true;
            this.rdbImpar.Text = "Impar";
            this.rdbImpar.UseVisualStyleBackColor = true;
            // 
            // lblSoma
            // 
            this.lblSoma.AutoSize = true;
            this.lblSoma.Location = new System.Drawing.Point(132, 69);
            this.lblSoma.Name = "lblSoma";
            this.lblSoma.Size = new System.Drawing.Size(58, 13);
            this.lblSoma.TabIndex = 3;
            this.lblSoma.Text = "[Resposta]";
            // 
            // frmSomaDeNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 114);
            this.Controls.Add(this.lblSoma);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSomaNumeros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSomaDeNumeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soma De Números";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSomaNumeros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbImpar;
        private System.Windows.Forms.RadioButton rdbPar;
        private System.Windows.Forms.Label lblSoma;
    }
}