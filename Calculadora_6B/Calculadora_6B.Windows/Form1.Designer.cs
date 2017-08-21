namespace Calculadora_6B.Windows
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Calcular = new System.Windows.Forms.Button();
            this.TxtValor1 = new System.Windows.Forms.TextBox();
            this.TxtValor2 = new System.Windows.Forms.TextBox();
            this.LblResultado = new System.Windows.Forms.Label();
            this.LblSuma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblResta = new System.Windows.Forms.Label();
            this.LblMultiplicacion = new System.Windows.Forms.Label();
            this.LblDivision = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(121, 42);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 0;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtValor1
            // 
            this.TxtValor1.Location = new System.Drawing.Point(15, 21);
            this.TxtValor1.Name = "TxtValor1";
            this.TxtValor1.Size = new System.Drawing.Size(100, 20);
            this.TxtValor1.TabIndex = 1;
            // 
            // TxtValor2
            // 
            this.TxtValor2.Location = new System.Drawing.Point(15, 63);
            this.TxtValor2.Name = "TxtValor2";
            this.TxtValor2.Size = new System.Drawing.Size(100, 20);
            this.TxtValor2.TabIndex = 2;
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Location = new System.Drawing.Point(52, 105);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(63, 13);
            this.LblResultado.TabIndex = 3;
            this.LblResultado.Text = "Resultados:";
            // 
            // LblSuma
            // 
            this.LblSuma.AutoSize = true;
            this.LblSuma.Location = new System.Drawing.Point(118, 133);
            this.LblSuma.Name = "LblSuma";
            this.LblSuma.Size = new System.Drawing.Size(60, 13);
            this.LblSuma.TabIndex = 4;
            this.LblSuma.Text = "Resultados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Suma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Multiplicaion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Division:";
            // 
            // LblResta
            // 
            this.LblResta.AutoSize = true;
            this.LblResta.Location = new System.Drawing.Point(118, 162);
            this.LblResta.Name = "LblResta";
            this.LblResta.Size = new System.Drawing.Size(60, 13);
            this.LblResta.TabIndex = 9;
            this.LblResta.Text = "Resultados";
            // 
            // LblMultiplicacion
            // 
            this.LblMultiplicacion.AutoSize = true;
            this.LblMultiplicacion.Location = new System.Drawing.Point(118, 190);
            this.LblMultiplicacion.Name = "LblMultiplicacion";
            this.LblMultiplicacion.Size = new System.Drawing.Size(60, 13);
            this.LblMultiplicacion.TabIndex = 10;
            this.LblMultiplicacion.Text = "Resultados";
            // 
            // LblDivision
            // 
            this.LblDivision.AutoSize = true;
            this.LblDivision.Location = new System.Drawing.Point(118, 218);
            this.LblDivision.Name = "LblDivision";
            this.LblDivision.Size = new System.Drawing.Size(60, 13);
            this.LblDivision.TabIndex = 11;
            this.LblDivision.Text = "Resultados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Valor 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Valor 2:";
            // 
            // Form1
            // 
            this.AcceptButton = this.Calcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 239);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblDivision);
            this.Controls.Add(this.LblMultiplicacion);
            this.Controls.Add(this.LblResta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblSuma);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.TxtValor2);
            this.Controls.Add(this.TxtValor1);
            this.Controls.Add(this.Calcular);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.TextBox TxtValor1;
        private System.Windows.Forms.TextBox TxtValor2;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Label LblSuma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblResta;
        private System.Windows.Forms.Label LblMultiplicacion;
        private System.Windows.Forms.Label LblDivision;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

