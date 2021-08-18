using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1new
{
    public partial class Form1 : Form
    {
        private int[] lista = new int[10];
        private int num1=0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0, num10 = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Decimal suma = 0, media=0, suma1 = 0, media1 = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(n1.Text);
            num2 = Convert.ToInt32(n2.Text);
            num3 = Convert.ToInt32(n3.Text);
            num4 = Convert.ToInt32(n4.Text);
            num5 = Convert.ToInt32(n5.Text);
            num6 = Convert.ToInt32(n6.Text);
            num7 = Convert.ToInt32(n7.Text);
            num8 = Convert.ToInt32(n8.Text);
            num9 = Convert.ToInt32(n9.Text);
            num10 = Convert.ToInt32(n10.Text);
            listBox1.Items.Clear();
            lista[0] = num1;
            lista[1] = num2;
            lista[2] = num3;
            lista[3] = num4;
            lista[4] = num5;
            lista[5] = num6;
            lista[6] = num7;
            lista[7] = num8;
            lista[8] = num9;
            lista[9] = num10;
            for (int i = 0; i != (lista.Length); i++)
            {
                listBox1.Items.Add(lista[i]);

            }

            n1.Text = String.Empty;
            n2.Text = String.Empty;
            n3.Text = String.Empty;
            n4.Text = String.Empty;
            n5.Text = String.Empty;
            n6.Text = String.Empty;
            n7.Text = String.Empty;
            n8.Text = String.Empty;
            n9.Text = String.Empty;
            n10.Text = String.Empty;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            var numeros = listBox1.Items.Cast<object>().Select(obj => Convert.ToInt32(obj));
            int min = numeros.Min();
            int max = numeros.Max();
            mini.Text =  min.ToString();
            maxi.Text = max.ToString();
            int list = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                list = Convert.ToInt32(listBox1.Items[i]);
                if (list > 0)
                {
                    suma1 += Convert.ToInt32(listBox1.Items[i]);

                }
                else
                {
                    media1 = 0;
                }

            }
            media1 = suma1 / listBox1.Items.Count;
            md2.Text = media1.ToString();

        }
        private void btn2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                suma += Convert.ToInt32(listBox1.Items[i]);
                

            }
            media = suma / listBox1.Items.Count;
            md.Text = media.ToString();
        }
    }
}
