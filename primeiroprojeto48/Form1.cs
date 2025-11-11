using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiroprojeto48
{
    public partial class Form1 : Form
    {
        private object texBox;

        public object TexBox1 { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Calculadora.Text = "Ola texto";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double soma1 = double.Parse(valor1.Text);
            double soma2 = double.Parse(valor2.Text);

            double resultado = soma1 + soma2;

            resp.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double soma1 = double.Parse(valor1.Text);
            double soma2 = double.Parse(valor2.Text);

            double resultado = soma1 * soma2;

            resp.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double soma1 = double.Parse(valor1.Text);
            double soma2 = double.Parse(valor2.Text);

            double resultado = soma1 - soma2;

            resp.Text = resultado.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double soma1 = double.Parse(valor1.Text);
            double soma2 = double.Parse(valor2.Text);

            double resultado = soma1 / soma2;

            resp.Text = resultado.ToString("F2");
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void valor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void valor2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
