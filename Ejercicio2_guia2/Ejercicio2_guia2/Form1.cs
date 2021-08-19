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
        public List<double> Cadena= new List<double>();
        public double[] numero = new double[9000];
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
            Cadena.Add(Convert.ToDouble(txt1.Text));
            
            txt1.Text = String.Empty;
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            media = Cadena.Average();
            txt3.Text = Cadena.Average().ToString();


        }
        public double DesTipic = 0;
        public double[] sumaDes = new double[10000];

        private void btn2_Click(object sender, EventArgs e)
        {
            foreach (  double i in Cadena)
            {
                DesTipic += Math.Pow(i - media, 2);
            }
            
            
           
            TotalDesTipic = Math.Sqrt(DesTipic / Cadena.Count);
            txt2.Text = TotalDesTipic.ToString();
        }

       
    }
}
