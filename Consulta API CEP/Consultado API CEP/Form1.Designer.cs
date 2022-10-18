namespace Consultado_API_CEP
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.formCepTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.formTextEstado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.formTextCidade = new System.Windows.Forms.TextBox();
            this.formTextEndereco = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.formTextComplemento1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.formTextBairro = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEP";
            // 
            // formCepTxt
            // 
            this.formCepTxt.Location = new System.Drawing.Point(46, 9);
            this.formCepTxt.Name = "formCepTxt";
            this.formCepTxt.Size = new System.Drawing.Size(153, 20);
            this.formCepTxt.TabIndex = 1;
            this.formCepTxt.TextChanged += new System.EventHandler(this.formCepTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Estado:";
            // 
            // formTextEstado
            // 
            this.formTextEstado.Location = new System.Drawing.Point(152, 58);
            this.formTextEstado.Name = "formTextEstado";
            this.formTextEstado.Size = new System.Drawing.Size(153, 20);
            this.formTextEstado.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Endereço:";
            // 
            // formTextCidade
            // 
            this.formTextCidade.Location = new System.Drawing.Point(152, 103);
            this.formTextCidade.Name = "formTextCidade";
            this.formTextCidade.Size = new System.Drawing.Size(153, 20);
            this.formTextCidade.TabIndex = 2;
            // 
            // formTextEndereco
            // 
            this.formTextEndereco.Location = new System.Drawing.Point(152, 148);
            this.formTextEndereco.Multiline = true;
            this.formTextEndereco.Name = "formTextEndereco";
            this.formTextEndereco.Size = new System.Drawing.Size(296, 28);
            this.formTextEndereco.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Consultar CEP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Complemento 1:";
            // 
            // formTextComplemento1
            // 
            this.formTextComplemento1.Location = new System.Drawing.Point(152, 199);
            this.formTextComplemento1.Name = "formTextComplemento1";
            this.formTextComplemento1.Size = new System.Drawing.Size(153, 20);
            this.formTextComplemento1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Bairro:";
            // 
            // formTextBairro
            // 
            this.formTextBairro.Location = new System.Drawing.Point(152, 247);
            this.formTextBairro.Name = "formTextBairro";
            this.formTextBairro.Size = new System.Drawing.Size(153, 20);
            this.formTextBairro.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(459, 358);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.formTextEndereco);
            this.Controls.Add(this.formTextBairro);
            this.Controls.Add(this.formTextComplemento1);
            this.Controls.Add(this.formTextCidade);
            this.Controls.Add(this.formTextEstado);
            this.Controls.Add(this.formCepTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Consultando CEP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox formCepTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox formTextEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox formTextCidade;
        private System.Windows.Forms.TextBox formTextEndereco;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox formTextComplemento1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox formTextBairro;
        private System.Windows.Forms.Button button2;
    }
}

