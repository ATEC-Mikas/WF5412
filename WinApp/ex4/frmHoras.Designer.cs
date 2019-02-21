namespace ex4
{
    partial class frmHoras
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
            this.components = new System.ComponentModel.Container();
            this.pbHoras = new System.Windows.Forms.ProgressBar();
            this.pbMinutos = new System.Windows.Forms.ProgressBar();
            this.pbSegundos = new System.Windows.Forms.ProgressBar();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.radioAutomatico = new System.Windows.Forms.RadioButton();
            this.radioManual = new System.Windows.Forms.RadioButton();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pbHoras
            // 
            this.pbHoras.Location = new System.Drawing.Point(29, 12);
            this.pbHoras.Maximum = 23;
            this.pbHoras.Name = "pbHoras";
            this.pbHoras.Size = new System.Drawing.Size(213, 23);
            this.pbHoras.Step = 1;
            this.pbHoras.TabIndex = 0;
            // 
            // pbMinutos
            // 
            this.pbMinutos.Location = new System.Drawing.Point(29, 53);
            this.pbMinutos.Maximum = 59;
            this.pbMinutos.Name = "pbMinutos";
            this.pbMinutos.Size = new System.Drawing.Size(449, 23);
            this.pbMinutos.Step = 1;
            this.pbMinutos.TabIndex = 1;
            // 
            // pbSegundos
            // 
            this.pbSegundos.Location = new System.Drawing.Point(29, 92);
            this.pbSegundos.Maximum = 59;
            this.pbSegundos.Name = "pbSegundos";
            this.pbSegundos.Size = new System.Drawing.Size(449, 23);
            this.pbSegundos.Step = 1;
            this.pbSegundos.TabIndex = 2;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(261, 22);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(35, 13);
            this.lblHoras.TabIndex = 3;
            this.lblHoras.Text = "label1";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Location = new System.Drawing.Point(484, 63);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(35, 13);
            this.lblMinutos.TabIndex = 4;
            this.lblMinutos.Text = "label1";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Location = new System.Drawing.Point(484, 102);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(35, 13);
            this.lblSegundos.TabIndex = 5;
            this.lblSegundos.Text = "label2";
            // 
            // radioAutomatico
            // 
            this.radioAutomatico.AutoSize = true;
            this.radioAutomatico.Location = new System.Drawing.Point(29, 133);
            this.radioAutomatico.Name = "radioAutomatico";
            this.radioAutomatico.Size = new System.Drawing.Size(78, 17);
            this.radioAutomatico.TabIndex = 6;
            this.radioAutomatico.TabStop = true;
            this.radioAutomatico.Text = "Automático";
            this.radioAutomatico.UseVisualStyleBackColor = true;
            this.radioAutomatico.CheckedChanged += new System.EventHandler(this.radioAutomatico_CheckedChanged);
            // 
            // radioManual
            // 
            this.radioManual.AutoSize = true;
            this.radioManual.Location = new System.Drawing.Point(29, 157);
            this.radioManual.Name = "radioManual";
            this.radioManual.Size = new System.Drawing.Size(60, 17);
            this.radioManual.TabIndex = 7;
            this.radioManual.TabStop = true;
            this.radioManual.Text = "Manual";
            this.radioManual.UseVisualStyleBackColor = true;
            this.radioManual.CheckedChanged += new System.EventHandler(this.radioManual_CheckedChanged);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(182, 157);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // frmHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 199);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.radioManual);
            this.Controls.Add(this.radioAutomatico);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.pbSegundos);
            this.Controls.Add(this.pbMinutos);
            this.Controls.Add(this.pbHoras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHoras";
            this.Text = "QueHorasSao";
            this.Load += new System.EventHandler(this.QueHorasSao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbHoras;
        private System.Windows.Forms.ProgressBar pbMinutos;
        private System.Windows.Forms.ProgressBar pbSegundos;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.RadioButton radioAutomatico;
        private System.Windows.Forms.RadioButton radioManual;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Timer Timer;
    }
}