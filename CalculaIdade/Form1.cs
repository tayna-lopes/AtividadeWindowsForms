using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaIdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Insira uma data.";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "")
            {
                label1.Text = "Campo não preenchido. Insira uma data.";
            }
            else
            {
                bool isData = DateTime.TryParse(textBox1.Text, out _);
                if (isData)
                {
                    DateTime data = Convert.ToDateTime(textBox1.Text);
                    if (data.Year > 2015)
                    {
                        label1.Text = "Data invalida. Inserir uma data abaixo de 2015.";
                    }
                    else
                    {
                        int idade = DateTime.Now.Year - data.Year;

                        if (DateTime.Now.Month < data.Month || (DateTime.Now.Month == data.Month && DateTime.Now.Day < data.Day))
                        {
                            idade--;
                        }
                        label1.Text = "Idade: " + idade + " anos";
                    }
                }
                else
                {
                    label1.Text = "Formato de data invalido";
                }
            }
        }
    }
}
