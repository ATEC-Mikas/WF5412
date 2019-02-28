namespace ex4
{
    partial class frmQuantoTempoPassou
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
            this.CalendarioInicio = new System.Windows.Forms.MonthCalendar();
            this.CalendarioFim = new System.Windows.Forms.MonthCalendar();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalendarioInicio
            // 
            this.CalendarioInicio.Location = new System.Drawing.Point(18, 18);
            this.CalendarioInicio.Name = "CalendarioInicio";
            this.CalendarioInicio.TabIndex = 0;
            this.CalendarioInicio.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalendarioChanged);
            // 
            // CalendarioFim
            // 
            this.CalendarioFim.Location = new System.Drawing.Point(263, 18);
            this.CalendarioFim.Name = "CalendarioFim";
            this.CalendarioFim.TabIndex = 1;
            this.CalendarioFim.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalendarioChanged);
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(503, 18);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(37, 13);
            this.lblDias.TabIndex = 2;
            this.lblDias.Text = "0 Dias";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(502, 31);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(47, 13);
            this.lblMes.TabIndex = 3;
            this.lblMes.Text = "0 Meses";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(503, 44);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(40, 13);
            this.lblAno.TabIndex = 4;
            this.lblAno.Text = "0 Anos";
            // 
            // frmQuantoTempoPassou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 198);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.CalendarioFim);
            this.Controls.Add(this.CalendarioInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmQuantoTempoPassou";
            this.Text = "frmQuantoTempoPassou";
            this.Load += new System.EventHandler(this.frmQuantoTempoPassou_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar CalendarioInicio;
        private System.Windows.Forms.MonthCalendar CalendarioFim;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAno;
    }
}