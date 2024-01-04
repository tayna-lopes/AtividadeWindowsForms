using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularImparPar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == null || textBox1.Text == "")
            {
                label1.Text = "Campo não preenchido. Insira um número.";
            }
            else
            {
                bool isNumeric = int.TryParse(textBox1.Text, out _);
                if (isNumeric)
                {
                    int numero = Convert.ToInt32(textBox1.Text);

                    if (numero % 2 == 0)
                    {
                        label1.Text = "Número é par.";
                    }
                    else
                    {
                        label1.Text = "Número é ímpar.";
                    }
                }
                else
                {
                    label1.Text = "Valor Invalido. Insira um numero.";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Insira um número.";

        }
    }
}
