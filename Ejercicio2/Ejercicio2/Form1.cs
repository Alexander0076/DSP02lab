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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             


        dia = Convert.ToInt32(cmb2.Text);
            mes = Convert.ToString(cmb1.Text);
            year = Convert.ToInt32(txt2.Text);

        //    class ejecutar
        //{
        //    public string Time(string mes, int dia, int year)
        //    {
        //        return dia + "/" + mes + "/" + year;
        //    }

        //}




        bool esBisiesto = ((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0);
            //if (esBisiesto)
            //{
            //    Console.WriteLine("Es año bisiesto");
            //}
            //else
            //{
            //    Console.WriteLine("No es año bisiesto");
            //}




            if (esBisiesto == true)
            {


                switch (mes)
                {
                    case "Enero":
                        txt3.Text = dia + "/" + mes + "/" + year;
                        break;
                    case "Febrero":

                        if (esBisiesto != true)
                        {
                            MessageBox.Show("El dia selecionado no es correcto ya que el año es bisiesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // txt3.Text = ejecutar.Time();
                            txt3.Text = dia + "/" + mes + "/" + year;
                        }

                        break;
                    case "Marzo":
                        txt3.Text = dia + "/" + mes + "/" + year;
                        break;
                    case "Abril":
                        txt3.Text = dia + "/" + mes + "/" + year;
                        break;
                    case "Mayo":
                        txt3.Text = dia + "/" + mes + "/" + year;
                        break;
                    case "Junio":
                        txt3.Text = dia + "/" + mes + "/" + year;
                        break;
                    case "Julio":
                        txt3.Text = dia + "/" + mes + "/" + year;
                        break;
                    case "Agosto":
                        txt3.Text = dia + "/" + mes + "/" + year;
                        break;
                    case "Septiembre":
                        txt3.Text = dia + "/" + mes + "/" + year;
                        break;
                    case "Octubre":
                        txt3.Text = dia + "/" + mes + "/" + year;
                        break;
                    case "Noviembre":
                        txt3.Text = dia + "/" + mes + "/" + year;
                        break;
                    case "Diciembre":
                        txt3.Text = dia + "/" + mes + "/" + year;
                        break;
                }

            }
            else { MessageBox.Show("El día seleccionado en el mes, no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
    }
    
}
