namespace ListaContactos
{
    partial class FormPopUpComunicacao
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
            this.txtCom = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.btnCAdd = new System.Windows.Forms.Button();
            this.btnTCriar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCom
            // 
            this.txtCom.Location = new System.Drawing.Point(12, 39);
            this.txtCom.MaxLength = 90;
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(176, 20);
            this.txtCom.TabIndex = 0;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(12, 12);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(176, 21);
            this.cbTipo.TabIndex = 1;
            // 
            // btnCAdd
            // 
            this.btnCAdd.Location = new System.Drawing.Point(194, 37);
            this.btnCAdd.Name = "btnCAdd";
            this.btnCAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCAdd.TabIndex = 2;
            this.btnCAdd.Text = "Adicionar";
            this.btnCAdd.UseVisualStyleBackColor = true;
            this.btnCAdd.Click += new System.EventHandler(this.btnCAdd_Click);
            // 
            // btnTCriar
            // 
            this.btnTCriar.Location = new System.Drawing.Point(194, 10);
            this.btnTCriar.Name = "btnTCriar";
            this.btnTCriar.Size = new System.Drawing.Size(75, 23);
            this.btnTCriar.TabIndex = 3;
            this.btnTCriar.Text = "Criar Tipo";
            this.btnTCriar.UseVisualStyleBackColor = true;
            this.btnTCriar.Click += new System.EventHandler(this.btnTCriar_Click);
            // 
            // FormPopUpComunicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 67);
            this.Controls.Add(this.btnTCriar);
            this.Controls.Add(this.btnCAdd);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.txtCom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPopUpComunicacao";
            this.Text = "Adicionar Comunicacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCom;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Button btnCAdd;
        private System.Windows.Forms.Button btnTCriar;
    }
}