namespace ListaContactos
{
    partial class FormDebug
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
            this.lblETC1 = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblETC1
            // 
            this.lblETC1.AutoSize = true;
            this.lblETC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblETC1.Location = new System.Drawing.Point(124, 9);
            this.lblETC1.Name = "lblETC1";
            this.lblETC1.Size = new System.Drawing.Size(524, 108);
            this.lblETC1.TabIndex = 0;
            this.lblETC1.Text = "Fun Times.";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(12, 206);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(73, 13);
            this.labelR.TabIndex = 1;
            this.labelR.Text = "RESULTADO";
            // 
            // FormDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.lblETC1);
            this.Name = "FormDebug";
            this.Text = "Form de Debug";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblETC1;
        private System.Windows.Forms.Label labelR;
    }
}

