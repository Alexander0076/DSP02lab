using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        private string mes;
        private int year, dia;
        private int[] numeros = new int[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dia = Convert.ToInt32(cmb2.Text);
            mes = Convert.ToString(cmb1.Text);
            year = Convert.ToInt32(txt2.Text);

            if (DateTime.IsLeapYear(year) == true)
            {


                switch (mes)
                {
                    case "Enero":
                        break;
                    case "Febrero":
                        if (dia == 29)
                        {
                            MessageBox.Show("El dia selecionado no es correcto ya que el año es bisiesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            txt3.Text = dia + "/" + mes + "/" + year;
                        }

                        break;
                    case "Marzo":
                        break;
                    case "Abril":
                        break;
                    case "Mayo":
                        break;
                    case "Junio":
                        break;
                    case "Julio":
                        break;
                    case "Agosto":
                        break;
                    case "Septiembre":
                        break;
                    case "Octubre":
                        break;
                    case "Noviembre":
                        break;
                    case "Diciembre":
                        break;
                }

            }
            else { MessageBox.Show("El día seleccionado en el mes, no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
