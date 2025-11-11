namespace primeiroprojeto48
{
    partial class Form1
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
            this.Calculadora = new System.Windows.Forms.Label();
            this.Soma = new System.Windows.Forms.Button();
            this.Subtrair = new System.Windows.Forms.Button();
            this.Multiplicar = new System.Windows.Forms.Button();
            this.Dividir = new System.Windows.Forms.Button();
            this.valor1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.resp = new System.Windows.Forms.TextBox();
            this.valor2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Calculadora
            // 
            this.Calculadora.AutoSize = true;
            this.Calculadora.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Calculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculadora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Calculadora.Location = new System.Drawing.Point(239, 9);
            this.Calculadora.Name = "Calculadora";
            this.Calculadora.Size = new System.Drawing.Size(310, 42);
            this.Calculadora.TabIndex = 0;
            this.Calculadora.Text = "CALCULADORA";
            this.Calculadora.Click += new System.EventHandler(this.label1_Click);
            // 
            // Soma
            // 
            this.Soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soma.Location = new System.Drawing.Point(202, 296);
            this.Soma.Name = "Soma";
            this.Soma.Size = new System.Drawing.Size(75, 62);
            this.Soma.TabIndex = 1;
            this.Soma.Text = "+";
            this.Soma.UseVisualStyleBackColor = true;
            this.Soma.Click += new System.EventHandler(this.button1_Click);
            // 
            // Subtrair
            // 
            this.Subtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtrair.Location = new System.Drawing.Point(291, 296);
            this.Subtrair.Name = "Subtrair";
            this.Subtrair.Size = new System.Drawing.Size(75, 62);
            this.Subtrair.TabIndex = 2;
            this.Subtrair.Text = "-";
            this.Subtrair.UseVisualStyleBackColor = true;
            this.Subtrair.Click += new System.EventHandler(this.button2_Click);
            // 
            // Multiplicar
            // 
            this.Multiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicar.Location = new System.Drawing.Point(385, 296);
            this.Multiplicar.Name = "Multiplicar";
            this.Multiplicar.Size = new System.Drawing.Size(75, 62);
            this.Multiplicar.TabIndex = 3;
            this.Multiplicar.Text = "X";
            this.Multiplicar.UseVisualStyleBackColor = true;
            this.Multiplicar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Dividir
            // 
            this.Dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dividir.Location = new System.Drawing.Point(474, 296);
            this.Dividir.Name = "Dividir";
            this.Dividir.Size = new System.Drawing.Size(75, 62);
            this.Dividir.TabIndex = 4;
            this.Dividir.Text = "/";
            this.Dividir.UseVisualStyleBackColor = true;
            this.Dividir.Click += new System.EventHandler(this.button4_Click);
            // 
            // valor1
            // 
            this.valor1.Location = new System.Drawing.Point(201, 178);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(165, 20);
            this.valor1.TabIndex = 5;
            this.valor1.TextChanged += new System.EventHandler(this.valor1_TextChanged);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(567, 320);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 38);
            this.button5.TabIndex = 6;
            this.button5.Text = "C";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // resp
            // 
            this.resp.Location = new System.Drawing.Point(201, 235);
            this.resp.Name = "resp";
            this.resp.Size = new System.Drawing.Size(404, 20);
            this.resp.TabIndex = 7;
            // 
            // valor2
            // 
            this.valor2.Location = new System.Drawing.Point(440, 178);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(165, 20);
            this.valor2.TabIndex = 8;
            this.valor2.TextChanged += new System.EventHandler(this.valor2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.resp);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.valor1);
            this.Controls.Add(this.Dividir);
            this.Controls.Add(this.Multiplicar);
            this.Controls.Add(this.Subtrair);
            this.Controls.Add(this.Soma);
            this.Controls.Add(this.Calculadora);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Calculadora;
        private System.Windows.Forms.Button Soma;
        private System.Windows.Forms.Button Subtrair;
        private System.Windows.Forms.Button Multiplicar;
        private System.Windows.Forms.Button Dividir;
        private System.Windows.Forms.TextBox valor1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox resp;
        private System.Windows.Forms.TextBox valor2;
    }
}

