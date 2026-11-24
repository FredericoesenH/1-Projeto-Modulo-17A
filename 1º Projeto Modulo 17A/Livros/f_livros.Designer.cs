namespace _1º_Projeto_Modulo_17A.Livros
{
    partial class f_livros
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_data_entrada = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.ckb_disponivel = new System.Windows.Forms.CheckBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(61, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // txt_isbn
            // 
            this.txt_isbn.Location = new System.Drawing.Point(143, 54);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(135, 20);
            this.txt_isbn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(61, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Titulo";
            // 
            // txt_titulo
            // 
            this.txt_titulo.Location = new System.Drawing.Point(143, 105);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(135, 20);
            this.txt_titulo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(61, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Autor";
            // 
            // txt_autor
            // 
            this.txt_autor.Location = new System.Drawing.Point(143, 161);
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(135, 20);
            this.txt_autor.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(61, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo";
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Items.AddRange(new object[] {
            "Manual Escolar",
            "Romance",
            "BD",
            "Ação",
            "Outros"});
            this.cmb_tipo.Location = new System.Drawing.Point(143, 212);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(135, 21);
            this.cmb_tipo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(61, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Data Entrada";
            // 
            // dtp_data_entrada
            // 
            this.dtp_data_entrada.Location = new System.Drawing.Point(190, 267);
            this.dtp_data_entrada.Name = "dtp_data_entrada";
            this.dtp_data_entrada.Size = new System.Drawing.Size(200, 20);
            this.dtp_data_entrada.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(61, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Estado";
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(143, 313);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(247, 20);
            this.txt_estado.TabIndex = 1;
            // 
            // ckb_disponivel
            // 
            this.ckb_disponivel.AutoSize = true;
            this.ckb_disponivel.Checked = true;
            this.ckb_disponivel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_disponivel.Location = new System.Drawing.Point(143, 352);
            this.ckb_disponivel.Name = "ckb_disponivel";
            this.ckb_disponivel.Size = new System.Drawing.Size(77, 17);
            this.ckb_disponivel.TabIndex = 4;
            this.ckb_disponivel.Text = "Disponível";
            this.ckb_disponivel.UseVisualStyleBackColor = true;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_adicionar.Location = new System.Drawing.Point(101, 390);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(289, 36);
            this.btn_adicionar.TabIndex = 5;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // f_livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 484);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.ckb_disponivel);
            this.Controls.Add(this.dtp_data_entrada);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.txt_autor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_isbn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "f_livros";
            this.Text = "f_livros";
            this.Load += new System.EventHandler(this.f_livros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_data_entrada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.CheckBox ckb_disponivel;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}