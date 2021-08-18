using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4_Guia_2
{
    public partial class Form1 : Form
    {
        private int num =0;
        private ArrayList lista;

        public Form1()
        {
            InitializeComponent();
            lista = new ArrayList();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            
            num = Convert.ToInt32(number.Text);
            number.Text = String.Empty;
            for (int i = 0; i < 10; i++)
            {
                tabla.Items.Add(num + " x " + (i + 1) + " = " + (num * (i + 1)));
            }
            
        }

        private void cls_Click(object sender, EventArgs e)
        {
            tabla.DataSource = null;
            tabla.Items.Clear();
        }
    }
}
