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

namespace Ejercicio_3_Guia_2
{
    public partial class Form1 : Form
    {
        ArrayList list;
        private Decimal number = 0;
        private Decimal promedio = 0;
        private Decimal suma = 0;
        private Decimal porceP = 0, porceN = 0; 
        public Form1()
        {
            InitializeComponent();
            list = new ArrayList();
        }
        

        private void btn_Click(object sender, EventArgs e)
        {
            number = Convert.ToDecimal(numeros.Text);
            numeros.Text = String.Empty;
            if(number <= 40 || number >= -40)
            {
                if(number > 0)
                {
                    PO.Items.Add(number);
                    int list = 0;
                    for (int i = 0; i < PO.Items.Count; i++)
                    {
                        list = Convert.ToInt32(PO.Items[i]);
                        if (list != 0)
                        {
                            suma += list;

                        }
                        else
                        {
                            MessageBox.Show("No se encontraron numeros positivos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    porceP = (suma / 100) * PO.Items.Count;
                    PorPosi.Text = porceP.ToString();
                    CNP.Text = PO.Items.Count.ToString();


                }else if(number < 0)
                {
                    NEG.Items.Add(number);
                    int list = 0;
                    for (int i = 0; i < NEG.Items.Count; i++)
                    {
                        list = Convert.ToInt32(NEG.Items[i]);
                        if (list != 0)
                        {
                            suma += list;

                        }
                        else
                        {
                            MessageBox.Show("No se encontraron numeros negativos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    porceN = (suma / 100) * NEG.Items.Count;
                    promedio = suma / NEG.Items.Count;
                    PorNeg.Text = porceN.ToString();
                    PromNeg.Text = promedio.ToString();
                    var numeros = NEG.Items.Cast<object>().Select(obj => Convert.ToInt32(obj));
                    //int min = numeros.Min();
                    //NNA.Text = min.ToString();
                    int max = numeros.Max();
                    NNA.Text = max.ToString();

                }
                else if(number == 0)
                {

                    CERO.Items.Add(number);
                    CC.Text = CERO.Items.Count.ToString();
                }
            }
            else
            {
                MessageBox.Show("Por favor ingresar un numero menor que 40 y mayor que -40", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
