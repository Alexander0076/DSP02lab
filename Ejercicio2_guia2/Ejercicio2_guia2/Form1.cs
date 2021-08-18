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
        private int x;
        private double[] numero = new double[0];
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

            for(int i = 0; i<x; i++){
                numero[i] = Convert.ToInt32(txt1.Text)

            }

            
        }
    }
}
