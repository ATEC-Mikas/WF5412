namespace ListaContactos
{
    partial class FormPopUpContaDef
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.grpBoxConta = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.grpBoxMudarPass = new System.Windows.Forms.GroupBox();
            this.btnAlterarP = new System.Windows.Forms.Button();
            this.txtNPass = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNCPass = new System.Windows.Forms.TextBox();
            this.grpBoxConta.SuspendLayout();
            this.grpBoxMudarPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(29, 85);
            this.txtNome.MaxLength = 90;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(148, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(305, 220);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username";
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(29, 42);
            this.txtUser.MaxLength = 90;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(148, 20);
            this.txtUser.TabIndex = 0;
            // 
            // grpBoxConta
            // 
            this.grpBoxConta.Controls.Add(this.btnCancelar);
            this.grpBoxConta.Controls.Add(this.btnEditar);
            this.grpBoxConta.Controls.Add(this.grpBoxMudarPass);
            this.grpBoxConta.Controls.Add(this.label2);
            this.grpBoxConta.Controls.Add(this.btnFechar);
            this.grpBoxConta.Controls.Add(this.txtNome);
            this.grpBoxConta.Controls.Add(this.txtUser);
            this.grpBoxConta.Controls.Add(this.label1);
            this.grpBoxConta.Location = new System.Drawing.Point(1, 0);
            this.grpBoxConta.Name = "grpBoxConta";
            this.grpBoxConta.Size = new System.Drawing.Size(406, 252);
            this.grpBoxConta.TabIndex = 11;
            this.grpBoxConta.TabStop = false;
            this.grpBoxConta.Text = "Conta";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(143, 220);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(224, 220);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // grpBoxMudarPass
            // 
            this.grpBoxMudarPass.Controls.Add(this.btnAlterarP);
            this.grpBoxMudarPass.Controls.Add(this.txtNPass);
            this.grpBoxMudarPass.Controls.Add(this.txtConfirmPass);
            this.grpBoxMudarPass.Controls.Add(this.label3);
            this.grpBoxMudarPass.Controls.Add(this.label5);
            this.grpBoxMudarPass.Controls.Add(this.label4);
            this.grpBoxMudarPass.Controls.Add(this.txtNCPass);
            this.grpBoxMudarPass.Location = new System.Drawing.Point(200, 19);
            this.grpBoxMudarPass.Name = "grpBoxMudarPass";
            this.grpBoxMudarPass.Size = new System.Drawing.Size(180, 178);
            this.grpBoxMudarPass.TabIndex = 17;
            this.grpBoxMudarPass.TabStop = false;
            this.grpBoxMudarPass.Text = "Mudar Password";
            // 
            // btnAlterarP
            // 
            this.btnAlterarP.Location = new System.Drawing.Point(99, 150);
            this.btnAlterarP.Name = "btnAlterarP";
            this.btnAlterarP.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarP.TabIndex = 5;
            this.btnAlterarP.Text = "Alterar";
            this.btnAlterarP.UseVisualStyleBackColor = true;
            this.btnAlterarP.Click += new System.EventHandler(this.btnAlterarP_Click);
            // 
            // txtNPass
            // 
            this.txtNPass.Location = new System.Drawing.Point(20, 42);
            this.txtNPass.MaxLength = 90;
            this.txtNPass.Name = "txtNPass";
            this.txtNPass.Size = new System.Drawing.Size(154, 20);
            this.txtNPass.TabIndex = 2;
            this.txtNPass.UseSystemPasswordChar = true;
            this.txtNPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarTextEntry);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(20, 124);
            this.txtConfirmPass.MaxLength = 90;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(154, 20);
            this.txtConfirmPass.TabIndex = 4;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Palavra passe nova";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Palavra passe antiga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Confirmar Palavra passe";
            // 
            // txtNCPass
            // 
            this.txtNCPass.Location = new System.Drawing.Point(20, 85);
            this.txtNCPass.MaxLength = 90;
            this.txtNCPass.Name = "txtNCPass";
            this.txtNCPass.Size = new System.Drawing.Size(154, 20);
            this.txtNCPass.TabIndex = 3;
            this.txtNCPass.UseSystemPasswordChar = true;
            // 
            // FormPopUpContaDef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 255);
            this.Controls.Add(this.grpBoxConta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPopUpContaDef";
            this.Text = "Defenições de Conta";
            this.grpBoxConta.ResumeLayout(false);
            this.grpBoxConta.PerformLayout();
            this.grpBoxMudarPass.ResumeLayout(false);
            this.grpBoxMudarPass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.GroupBox grpBoxConta;
        private System.Windows.Forms.GroupBox grpBoxMudarPass;
        private System.Windows.Forms.TextBox txtNPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNCPass;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAlterarP;
        private System.Windows.Forms.Button btnCancelar;
    }
}