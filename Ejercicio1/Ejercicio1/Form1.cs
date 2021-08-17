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
        private int[] lista = new int[10];
        private double num=0;
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

            for (int i=0; i!=(lista.Length); i++)
            {
                lista[i] = Convert.ToInt32(numeros.Text);
                list.Items.Add(lista[i]);

            }
            
        }
    }
}
