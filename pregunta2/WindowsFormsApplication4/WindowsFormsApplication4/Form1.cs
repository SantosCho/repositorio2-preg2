using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        int valor;
        double valor1;
        double valor2;
        double resultado;
        int operador;
        public Form1()
        {
            InitializeComponent();
            valor = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor = valor *10 + Convert.ToInt32(((Button)sender).Text);
            textBox1.Text = valor.ToString();
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        { 
            valor2 = Convert.ToDouble(textBox1.Text);
            
            if (operador == 1) {
                resultado = valor1 + valor2;
              
            }
            if (operador == 2)
            {
                resultado = valor1 - valor2;
              
            }
            if (operador == 3)
            {
                resultado = valor1 * valor2;
              
            }
            if (operador == 4)
            {
                resultado = valor1 / valor2;
               
            }
            textBox1.Text = resultado.ToString();

        }
        private void buttonSuma_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text ="";
            valor = 0;
            operador = 1;
        }

     

        private void buttonResta_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            valor = 0;
            operador = 2;
        }

        private void buttonMultiplica_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            valor = 0;
            operador = 3;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            valor = 0;
            operador = 4;
        }


        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            valor = 0;
        }

     
    
    }
}
