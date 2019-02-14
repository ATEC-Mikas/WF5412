namespace ex1
{
    partial class frmCumprimentos
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
            this.btnAcao = new System.Windows.Forms.Button();
            this.txtSaudacao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAcao
            // 
            this.btnAcao.Location = new System.Drawing.Point(176, 23);
            this.btnAcao.Name = "btnAcao";
            this.btnAcao.Size = new System.Drawing.Size(75, 23);
            this.btnAcao.TabIndex = 0;
            this.btnAcao.Text = "Clique";
            this.btnAcao.UseVisualStyleBackColor = true;
            this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
            // 
            // txtSaudacao
            // 
            this.txtSaudacao.Location = new System.Drawing.Point(12, 12);
            this.txtSaudacao.Name = "txtSaudacao";
            this.txtSaudacao.Size = new System.Drawing.Size(158, 20);
            this.txtSaudacao.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(158, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(12, 78);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(35, 13);
            this.lblResposta.TabIndex = 3;
            this.lblResposta.Text = "label1";
            this.lblResposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(95, 103);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // frmCumprimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 138);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSaudacao);
            this.Controls.Add(this.btnAcao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmCumprimentos";
            this.Text = "Cumprimentos";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmCumprimentos_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcao;
        private System.Windows.Forms.TextBox txtSaudacao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Button btnLimpar;
        private System.Diagnostics.EventLog eventLog1;
    }
}