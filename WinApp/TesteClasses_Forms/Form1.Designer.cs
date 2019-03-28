namespace TesteClasses_Forms
{
    partial class FormTeste
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
            this.GRPEditora = new System.Windows.Forms.GroupBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.btnCriarEditora = new System.Windows.Forms.Button();
            this.ListEditora = new System.Windows.Forms.ListBox();
            this.GRPAutores = new System.Windows.Forms.GroupBox();
            this.ListAutores = new System.Windows.Forms.ListBox();
            this.btnCriarAutor = new System.Windows.Forms.Button();
            this.txtAutores = new System.Windows.Forms.TextBox();
            this.GRPGeneros = new System.Windows.Forms.GroupBox();
            this.ListGeneros = new System.Windows.Forms.ListBox();
            this.btnCriarGeneros = new System.Windows.Forms.Button();
            this.txtGeneros = new System.Windows.Forms.TextBox();
            this.GRPLivro = new System.Windows.Forms.GroupBox();
            this.ListLivro = new System.Windows.Forms.ListBox();
            this.btnCriarLivro = new System.Windows.Forms.Button();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.DateLivro = new System.Windows.Forms.DateTimePicker();
            this.GRPEditora.SuspendLayout();
            this.GRPAutores.SuspendLayout();
            this.GRPGeneros.SuspendLayout();
            this.GRPLivro.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRPEditora
            // 
            this.GRPEditora.Controls.Add(this.ListEditora);
            this.GRPEditora.Controls.Add(this.btnCriarEditora);
            this.GRPEditora.Controls.Add(this.txtEditora);
            this.GRPEditora.Location = new System.Drawing.Point(12, 12);
            this.GRPEditora.Name = "GRPEditora";
            this.GRPEditora.Size = new System.Drawing.Size(231, 149);
            this.GRPEditora.TabIndex = 1;
            this.GRPEditora.TabStop = false;
            this.GRPEditora.Text = "Editoras";
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(7, 20);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(137, 20);
            this.txtEditora.TabIndex = 0;
            // 
            // btnCriarEditora
            // 
            this.btnCriarEditora.Location = new System.Drawing.Point(150, 18);
            this.btnCriarEditora.Name = "btnCriarEditora";
            this.btnCriarEditora.Size = new System.Drawing.Size(75, 23);
            this.btnCriarEditora.TabIndex = 1;
            this.btnCriarEditora.Text = "Criar";
            this.btnCriarEditora.UseVisualStyleBackColor = true;
            this.btnCriarEditora.Click += new System.EventHandler(this.btnCriarEditora_Click);
            // 
            // ListEditora
            // 
            this.ListEditora.FormattingEnabled = true;
            this.ListEditora.Location = new System.Drawing.Point(7, 47);
            this.ListEditora.Name = "ListEditora";
            this.ListEditora.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListEditora.Size = new System.Drawing.Size(218, 95);
            this.ListEditora.TabIndex = 2;
            // 
            // GRPAutores
            // 
            this.GRPAutores.Controls.Add(this.ListAutores);
            this.GRPAutores.Controls.Add(this.btnCriarAutor);
            this.GRPAutores.Controls.Add(this.txtAutores);
            this.GRPAutores.Location = new System.Drawing.Point(260, 12);
            this.GRPAutores.Name = "GRPAutores";
            this.GRPAutores.Size = new System.Drawing.Size(231, 149);
            this.GRPAutores.TabIndex = 3;
            this.GRPAutores.TabStop = false;
            this.GRPAutores.Text = "Autores";
            // 
            // ListAutores
            // 
            this.ListAutores.FormattingEnabled = true;
            this.ListAutores.Location = new System.Drawing.Point(7, 47);
            this.ListAutores.Name = "ListAutores";
            this.ListAutores.Size = new System.Drawing.Size(218, 95);
            this.ListAutores.TabIndex = 2;
            // 
            // btnCriarAutor
            // 
            this.btnCriarAutor.Location = new System.Drawing.Point(150, 18);
            this.btnCriarAutor.Name = "btnCriarAutor";
            this.btnCriarAutor.Size = new System.Drawing.Size(75, 23);
            this.btnCriarAutor.TabIndex = 1;
            this.btnCriarAutor.Text = "Criar";
            this.btnCriarAutor.UseVisualStyleBackColor = true;
            this.btnCriarAutor.Click += new System.EventHandler(this.btnCriarAutor_Click);
            // 
            // txtAutores
            // 
            this.txtAutores.Location = new System.Drawing.Point(7, 20);
            this.txtAutores.Name = "txtAutores";
            this.txtAutores.Size = new System.Drawing.Size(137, 20);
            this.txtAutores.TabIndex = 0;
            // 
            // GRPGeneros
            // 
            this.GRPGeneros.Controls.Add(this.ListGeneros);
            this.GRPGeneros.Controls.Add(this.btnCriarGeneros);
            this.GRPGeneros.Controls.Add(this.txtGeneros);
            this.GRPGeneros.Location = new System.Drawing.Point(12, 167);
            this.GRPGeneros.Name = "GRPGeneros";
            this.GRPGeneros.Size = new System.Drawing.Size(231, 149);
            this.GRPGeneros.TabIndex = 4;
            this.GRPGeneros.TabStop = false;
            this.GRPGeneros.Text = "Generos Livro";
            // 
            // ListGeneros
            // 
            this.ListGeneros.FormattingEnabled = true;
            this.ListGeneros.Location = new System.Drawing.Point(7, 47);
            this.ListGeneros.Name = "ListGeneros";
            this.ListGeneros.Size = new System.Drawing.Size(218, 95);
            this.ListGeneros.TabIndex = 2;
            // 
            // btnCriarGeneros
            // 
            this.btnCriarGeneros.Location = new System.Drawing.Point(150, 17);
            this.btnCriarGeneros.Name = "btnCriarGeneros";
            this.btnCriarGeneros.Size = new System.Drawing.Size(75, 23);
            this.btnCriarGeneros.TabIndex = 1;
            this.btnCriarGeneros.Text = "Criar";
            this.btnCriarGeneros.UseVisualStyleBackColor = true;
            this.btnCriarGeneros.Click += new System.EventHandler(this.btnCriarGeneros_Click);
            // 
            // txtGeneros
            // 
            this.txtGeneros.Location = new System.Drawing.Point(7, 20);
            this.txtGeneros.Name = "txtGeneros";
            this.txtGeneros.Size = new System.Drawing.Size(137, 20);
            this.txtGeneros.TabIndex = 0;
            // 
            // GRPLivro
            // 
            this.GRPLivro.Controls.Add(this.DateLivro);
            this.GRPLivro.Controls.Add(this.lblTitulo);
            this.GRPLivro.Controls.Add(this.txtTitulo);
            this.GRPLivro.Controls.Add(this.lblIsbn);
            this.GRPLivro.Controls.Add(this.ListLivro);
            this.GRPLivro.Controls.Add(this.btnCriarLivro);
            this.GRPLivro.Controls.Add(this.txtISBN);
            this.GRPLivro.Location = new System.Drawing.Point(260, 167);
            this.GRPLivro.Name = "GRPLivro";
            this.GRPLivro.Size = new System.Drawing.Size(245, 196);
            this.GRPLivro.TabIndex = 5;
            this.GRPLivro.TabStop = false;
            this.GRPLivro.Text = "Livro";
            // 
            // ListLivro
            // 
            this.ListLivro.FormattingEnabled = true;
            this.ListLivro.Location = new System.Drawing.Point(6, 92);
            this.ListLivro.Name = "ListLivro";
            this.ListLivro.Size = new System.Drawing.Size(218, 95);
            this.ListLivro.TabIndex = 2;
            this.ListLivro.DoubleClick += new System.EventHandler(this.ListLivro_DoubleClick);
            // 
            // btnCriarLivro
            // 
            this.btnCriarLivro.Location = new System.Drawing.Point(150, 63);
            this.btnCriarLivro.Name = "btnCriarLivro";
            this.btnCriarLivro.Size = new System.Drawing.Size(81, 23);
            this.btnCriarLivro.TabIndex = 1;
            this.btnCriarLivro.Text = "Criar";
            this.btnCriarLivro.UseVisualStyleBackColor = true;
            this.btnCriarLivro.Click += new System.EventHandler(this.btnCriarLivro_Click);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(7, 30);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(137, 20);
            this.txtISBN.TabIndex = 0;
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(7, 17);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(32, 13);
            this.lblIsbn.TabIndex = 3;
            this.lblIsbn.Text = "ISBN";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(7, 53);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(7, 66);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(137, 20);
            this.txtTitulo.TabIndex = 4;
            // 
            // DateLivro
            // 
            this.DateLivro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateLivro.Location = new System.Drawing.Point(150, 30);
            this.DateLivro.MaxDate = new System.DateTime(2019, 3, 28, 0, 0, 0, 0);
            this.DateLivro.Name = "DateLivro";
            this.DateLivro.Size = new System.Drawing.Size(81, 20);
            this.DateLivro.TabIndex = 6;
            this.DateLivro.Value = new System.DateTime(2019, 3, 28, 0, 0, 0, 0);
            // 
            // FormTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 372);
            this.Controls.Add(this.GRPLivro);
            this.Controls.Add(this.GRPGeneros);
            this.Controls.Add(this.GRPAutores);
            this.Controls.Add(this.GRPEditora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormTeste";
            this.Text = "Form Teste Classes";
            this.Load += new System.EventHandler(this.FormTeste_Load);
            this.GRPEditora.ResumeLayout(false);
            this.GRPEditora.PerformLayout();
            this.GRPAutores.ResumeLayout(false);
            this.GRPAutores.PerformLayout();
            this.GRPGeneros.ResumeLayout(false);
            this.GRPGeneros.PerformLayout();
            this.GRPLivro.ResumeLayout(false);
            this.GRPLivro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GRPEditora;
        private System.Windows.Forms.ListBox ListEditora;
        private System.Windows.Forms.Button btnCriarEditora;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.GroupBox GRPAutores;
        private System.Windows.Forms.ListBox ListAutores;
        private System.Windows.Forms.Button btnCriarAutor;
        private System.Windows.Forms.TextBox txtAutores;
        private System.Windows.Forms.GroupBox GRPGeneros;
        private System.Windows.Forms.ListBox ListGeneros;
        private System.Windows.Forms.Button btnCriarGeneros;
        private System.Windows.Forms.TextBox txtGeneros;
        private System.Windows.Forms.GroupBox GRPLivro;
        private System.Windows.Forms.ListBox ListLivro;
        private System.Windows.Forms.Button btnCriarLivro;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.DateTimePicker DateLivro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
    }
}

