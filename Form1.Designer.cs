namespace WindowsFormsApp5
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
            this.valor1 = new System.Windows.Forms.TextBox();
            this.valor2 = new System.Windows.Forms.TextBox();
            this.Somar = new System.Windows.Forms.Button();
            this.Subtrair = new System.Windows.Forms.Button();
            this.Multiplicar = new System.Windows.Forms.Button();
            this.Dividir = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // valor1
            // 
            this.valor1.Location = new System.Drawing.Point(12, 12);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(100, 22);
            this.valor1.TabIndex = 0;
            // 
            // valor2
            // 
            this.valor2.Location = new System.Drawing.Point(230, 12);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(100, 22);
            this.valor2.TabIndex = 1;
            // 
            // Somar
            // 
            this.Somar.Location = new System.Drawing.Point(12, 82);
            this.Somar.Name = "Somar";
            this.Somar.Size = new System.Drawing.Size(75, 23);
            this.Somar.TabIndex = 2;
            this.Somar.Text = "+";
            this.Somar.UseVisualStyleBackColor = true;
            this.Somar.Click += new System.EventHandler(this.Somar_Click);
            // 
            // Subtrair
            // 
            this.Subtrair.Location = new System.Drawing.Point(93, 82);
            this.Subtrair.Name = "Subtrair";
            this.Subtrair.Size = new System.Drawing.Size(75, 23);
            this.Subtrair.TabIndex = 3;
            this.Subtrair.Text = "-";
            this.Subtrair.UseVisualStyleBackColor = true;
            this.Subtrair.Click += new System.EventHandler(this.Subtrair_Click);
            // 
            // Multiplicar
            // 
            this.Multiplicar.Location = new System.Drawing.Point(174, 82);
            this.Multiplicar.Name = "Multiplicar";
            this.Multiplicar.Size = new System.Drawing.Size(75, 23);
            this.Multiplicar.TabIndex = 4;
            this.Multiplicar.Text = "*";
            this.Multiplicar.UseVisualStyleBackColor = true;
            this.Multiplicar.Click += new System.EventHandler(this.Multiplicar_Click);
            // 
            // Dividir
            // 
            this.Dividir.Location = new System.Drawing.Point(255, 82);
            this.Dividir.Name = "Dividir";
            this.Dividir.Size = new System.Drawing.Size(75, 23);
            this.Dividir.TabIndex = 5;
            this.Dividir.Text = "/";
            this.Dividir.UseVisualStyleBackColor = true;
            this.Dividir.Click += new System.EventHandler(this.Dividir_Click);
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(118, 132);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(100, 22);
            this.resultado.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 166);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.Dividir);
            this.Controls.Add(this.Multiplicar);
            this.Controls.Add(this.Subtrair);
            this.Controls.Add(this.Somar);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.valor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valor1;
        private System.Windows.Forms.TextBox valor2;
        private System.Windows.Forms.Button Somar;
        private System.Windows.Forms.Button Subtrair;
        private System.Windows.Forms.Button Multiplicar;
        private System.Windows.Forms.Button Dividir;
        private System.Windows.Forms.TextBox resultado;
    }
}

