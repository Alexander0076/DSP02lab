using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        //private int[] lista = new int[10];
        private int num = 0;
        private Decimal suma=0;
        private Decimal media = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
            int[] lista = new int[Convert.ToInt32(numeros.Text)];
            for (int i=0; i != (lista.Length); i++)
            {
                
                num = lista[i];
                suma += num;


                list.Items.Add(num);
                numeros.Text = String.Empty;

            }
            list.Items.Add("La suma es: " + suma);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int[] lista = new int[Convert.ToInt32(numeros.Text)];
            for (int i = 0; i != (lista.Length); i++)
            {
                media = suma / num;
                list.Items.Clear();
                list.Items.Add("La media es: " + media);
            }
               
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int[] lista = new int[Convert.ToInt32(numeros.Text)];
            list.Items.Clear();
                int numbers = num;
                int min = lista.Min();
                int max = lista.Max();
            list.Items.Add("Minimum Value : " + min);
            list.Items.Add("Maximum Value : " + max);
            
            
        }
    }
}
