namespace ListaContactos
{
    partial class FormLogin
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
            this.txtLUser = new System.Windows.Forms.TextBox();
            this.txtLPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.txtRConfirmP = new System.Windows.Forms.TextBox();
            this.txtRPass = new System.Windows.Forms.TextBox();
            this.txtRNome = new System.Windows.Forms.TextBox();
            this.txtRUser = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSeed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLUser
            // 
            this.txtLUser.Location = new System.Drawing.Point(114, 100);
            this.txtLUser.MaxLength = 90;
            this.txtLUser.Name = "txtLUser";
            this.txtLUser.Size = new System.Drawing.Size(151, 20);
            this.txtLUser.TabIndex = 0;
            // 
            // txtLPassword
            // 
            this.txtLPassword.Location = new System.Drawing.Point(114, 139);
            this.txtLPassword.MaxLength = 90;
            this.txtLPassword.Name = "txtLPassword";
            this.txtLPassword.Size = new System.Drawing.Size(151, 20);
            this.txtLPassword.TabIndex = 1;
            this.txtLPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(114, 179);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(151, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(446, 239);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(161, 23);
            this.btnRegistar.TabIndex = 7;
            this.btnRegistar.Text = "Registar";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // txtRConfirmP
            // 
            this.txtRConfirmP.Location = new System.Drawing.Point(446, 196);
            this.txtRConfirmP.MaxLength = 90;
            this.txtRConfirmP.Name = "txtRConfirmP";
            this.txtRConfirmP.Size = new System.Drawing.Size(161, 20);
            this.txtRConfirmP.TabIndex = 6;
            this.txtRConfirmP.UseSystemPasswordChar = true;
            // 
            // txtRPass
            // 
            this.txtRPass.Location = new System.Drawing.Point(446, 157);
            this.txtRPass.MaxLength = 90;
            this.txtRPass.Name = "txtRPass";
            this.txtRPass.Size = new System.Drawing.Size(161, 20);
            this.txtRPass.TabIndex = 5;
            this.txtRPass.UseSystemPasswordChar = true;
            // 
            // txtRNome
            // 
            this.txtRNome.Location = new System.Drawing.Point(446, 119);
            this.txtRNome.MaxLength = 90;
            this.txtRNome.Name = "txtRNome";
            this.txtRNome.Size = new System.Drawing.Size(161, 20);
            this.txtRNome.TabIndex = 4;
            // 
            // txtRUser
            // 
            this.txtRUser.Location = new System.Drawing.Point(446, 80);
            this.txtRUser.MaxLength = 90;
            this.txtRUser.Name = "txtRUser";
            this.txtRUser.Size = new System.Drawing.Size(161, 20);
            this.txtRUser.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Confirmar password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label7.Location = new System.Drawing.Point(144, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 39);
            this.label7.TabIndex = 14;
            this.label7.Text = "Login";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.label8.Location = new System.Drawing.Point(445, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 44);
            this.label8.TabIndex = 15;
            this.label8.Text = "Registar";
            // 
            // btnSeed
            // 
            this.btnSeed.Location = new System.Drawing.Point(12, 254);
            this.btnSeed.Name = "btnSeed";
            this.btnSeed.Size = new System.Drawing.Size(75, 23);
            this.btnSeed.TabIndex = 16;
            this.btnSeed.Text = "[Dev] Seed";
            this.btnSeed.UseVisualStyleBackColor = true;
            this.btnSeed.Click += new System.EventHandler(this.btnSeed_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 289);
            this.Controls.Add(this.btnSeed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRNome);
            this.Controls.Add(this.txtRUser);
            this.Controls.Add(this.txtRConfirmP);
            this.Controls.Add(this.txtRPass);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLPassword);
            this.Controls.Add(this.txtLUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLUser;
        private System.Windows.Forms.TextBox txtLPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.TextBox txtRConfirmP;
        private System.Windows.Forms.TextBox txtRPass;
        private System.Windows.Forms.TextBox txtRNome;
        private System.Windows.Forms.TextBox txtRUser;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSeed;
    }
}