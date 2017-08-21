using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora_6B.Libreria;

namespace Calculadora_6B.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TxtValor1.Focus();
            this.LblSuma.Text = "";
            this.LblResta.Text = "";
            this.LblMultiplicacion.Text = "";
            this.LblDivision.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Metodos MisMetodos = new Metodos();
            //MessageBox.Show(MisMetodos.Saludar());
            string Valor1 = string.Empty;
            //TxtValor1.Text = Valor1;
            Valor1 = TxtValor1.Text;
            string Valor2 = string.Empty;
            //TxtValor2.Text = Valor2;
            Valor2 = TxtValor2.Text;
            float Valor1F = float.Parse(Valor1);
            float Valor2F = float.Parse(Valor2);
            //MessageBox.Show(Valor1 + Valor2);
            this.LblSuma.Text = Convert.ToString(MisMetodos.Sumar(Valor1F, Valor2F));
            this.LblResta.Text = Convert.ToString(MisMetodos.Restar(Valor1F, Valor2F));
            this.LblMultiplicacion.Text = Convert.ToString(MisMetodos.Multiplicar(Valor1F, Valor2F));
            this.LblDivision.Text = Convert.ToString(MisMetodos.Dividir(Valor1F, Valor2F));
            TxtValor1.Focus();
            /*
             * string text = string.Empty;
                txtTextBox.Text = text;
                text = txtTextBox.Text;
             */
        }
    }
}
