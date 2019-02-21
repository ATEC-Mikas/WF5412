namespace ex3
{
    partial class frmNotaFinal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTF = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtTeste1 = new System.Windows.Forms.TextBox();
            this.txtTeste2 = new System.Windows.Forms.TextBox();
            this.txtTP1 = new System.Windows.Forms.TextBox();
            this.txtTP2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTeste2);
            this.groupBox1.Controls.Add(this.txtTeste1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Testes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTP2);
            this.groupBox2.Controls.Add(this.txtTP1);
            this.groupBox2.Location = new System.Drawing.Point(243, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trab Práticos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trabalho Final";
            // 
            // txtTF
            // 
            this.txtTF.Location = new System.Drawing.Point(89, 135);
            this.txtTF.MaxLength = 2;
            this.txtTF.Name = "txtTF";
            this.txtTF.Size = new System.Drawing.Size(35, 20);
            this.txtTF.TabIndex = 3;
            this.txtTF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHandle);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 171);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtTeste1
            // 
            this.txtTeste1.Location = new System.Drawing.Point(96, 23);
            this.txtTeste1.MaxLength = 2;
            this.txtTeste1.Name = "txtTeste1";
            this.txtTeste1.Size = new System.Drawing.Size(37, 20);
            this.txtTeste1.TabIndex = 0;
            this.txtTeste1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHandle);
            // 
            // txtTeste2
            // 
            this.txtTeste2.Location = new System.Drawing.Point(96, 56);
            this.txtTeste2.MaxLength = 2;
            this.txtTeste2.Name = "txtTeste2";
            this.txtTeste2.Size = new System.Drawing.Size(37, 20);
            this.txtTeste2.TabIndex = 1;
            this.txtTeste2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHandle);
            // 
            // txtTP1
            // 
            this.txtTP1.Location = new System.Drawing.Point(105, 30);
            this.txtTP1.MaxLength = 2;
            this.txtTP1.Name = "txtTP1";
            this.txtTP1.Size = new System.Drawing.Size(37, 20);
            this.txtTP1.TabIndex = 0;
            this.txtTP1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHandle);
            // 
            // txtTP2
            // 
            this.txtTP2.Location = new System.Drawing.Point(105, 56);
            this.txtTP2.MaxLength = 2;
            this.txtTP2.Name = "txtTP2";
            this.txtTP2.Size = new System.Drawing.Size(37, 20);
            this.txtTP2.TabIndex = 1;
            this.txtTP2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHandle);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "1º Teste";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "2º Teste";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "1º Trab. Prático";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "2º Trab. Prático";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(249, 135);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(32, 13);
            this.lblNota.TabIndex = 5;
            this.lblNota.Text = "vazio";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(252, 170);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmNotaFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 206);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNotaFinal";
            this.Text = "Nota Final";
            this.Load += new System.EventHandler(this.frmNotaFinal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTF;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTeste2;
        private System.Windows.Forms.TextBox txtTeste1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTP2;
        private System.Windows.Forms.TextBox txtTP1;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Button btnLimpar;
    }
}

