using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularTemperaturas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Inserir uma temperatura";
            label2.Text = "";
            label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "")
            {
                label1.Text = "Campo não preenchido. Insira uma temperatura.";
            }
            else
            {
                bool isNumeric = int.TryParse(textBox1.Text, out _);
                if (isNumeric)
                {
                    double celcius = Convert.ToDouble(textBox1.Text);

                    double kelvin = celcius + 273.15;
                    label2.Text = "Temperatura em Kelvin: " + kelvin + "°K";

                    double fahrenheit = (celcius * 9 / 5) + 32;
                    label3.Text = "Temperatura em Fahrenheit: " + fahrenheit + "°F";

                }
                else
                {
                    label1.Text = "Formato invalido. Insira uma temperatura.";
                    label2.Text = "";
                    label3.Text = "";
                }
            }
        }
    }
}
