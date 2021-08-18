using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2_guia2
{
    public partial class Form1 : Form
    {
        public int x;
        public int y;
        public double[] numero = new double[900];
        public double[] NumDes = new double[9000];
        public double suma = 0;
        public double media = 0;
        public double TotalDesTipic = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            x = txt1.Text.Length;
            for (int i = 0; i < x; i++)
            {
                numero[i] = Convert.ToInt32(txt1.Text);
                list1.Items.Add(numero[i]);
                
                txt1.Text = String.Empty;
                y +=1 ;
                
            }
            for (int i = 0; i < y; i++)
            {
                suma =   numero[i] + suma;
            }

            
            media = suma / y;
            //txt3.Text = y.ToString();
           









        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txt3.Text = media.ToString();


        }
        public double DesTipic = 0;
        public double[] sumaDes = new double[10000];

        private void btn2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<y; i++)
            {
                //sumaDes[i] = Math.Pow((numero[i] - media), 2);
                DesTipic = DesTipic + Math.Pow(numero[i] - media, 2);
            }
            for(int i = y; i>y; i--)
            {
                list2.Items.Add(numero[i]);
            }
            //for(int h = 0; h<y; y++)
            //{
            //    list2.Items.Add(sumaDes[h].ToString());
            //}

            //for(int j = 0; j<y; j++)
            //{
            //    DesTipic = DesTipic + sumaDes[j];
            //}
            //txt4.Text = DesTipic.ToString();
            DesTipic = DesTipic / y;
            //DesTipic = Math.Sqrt(DesTipic);
            TotalDesTipic = DesTipic;
            txt2.Text = TotalDesTipic.ToString();
        }

       
    }
}
