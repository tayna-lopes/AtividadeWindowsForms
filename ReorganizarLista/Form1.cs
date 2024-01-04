using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReorganizarLista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Reorganizar Lista: [ -34, 77, -89, -25, -19, 14, -20, 46, -32, 91 ]";
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> listaOriginal = new List<int> { -34, 77, -89, -25, -19, 14, -20, 46, -32, 91 };
            List<string> listaNova = new List<string>();

            listaOriginal.ForEach(x =>
           {
               if( x > 0)
               {
                   listaNova.Add("Positivo");
               }
               else
               {
                   listaNova.Add("Negativo");
               }
           });
            label2.Text = "Resultado: " + string.Join(", ", listaNova);
        }
    }
}
