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

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        private int suma = 0;
        private decimal prom = 0 ;
        ArrayList lista;
        public Form1()
        {
            InitializeComponent();
            lista = new ArrayList();
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            lista.Add(numeros.Text);
            //numeros.Text = String.Empty;
            
        }

        private void mostrar_Click(object sender, EventArgs e)
        {
            if (lista.Count > 10)
            {
                MessageBox.Show("Solo puede ingresar 10 numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (lista.Count <= 0)
            {
                MessageBox.Show("Por favor ingrese un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if(lista.Count == 10)
            {

                for (int i = 0; i < lista.Count; i++)
                {
                    int aux = Convert.ToInt32(lista[i]);
                    if( aux > 0)
                    {
                        npositivos.Items.Add(lista[i]);
                    }else if(aux < 0)
                    {
                        nnegativos.Items.Add(lista[i]);
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un total de 10 numeros. Faltantes: "+ (10 - lista.Count) , "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menor_Click(object sender, EventArgs e)
        {
            var numeros = nnegativos.Items.Cast<object>().Select(obj => Convert.ToInt32(obj));
            int list = 0;
            //int max = numeros.Max();
            //maxi.Text = max.ToString();
            for (int i = 0; i < nnegativos.Items.Count; i++)
            {
                list = Convert.ToInt32(nnegativos.Items[i]);
                if(list != 0)
                {
                    int min = numeros.Min();
                    negativo.Text = min.ToString();

                }
                else
                {
                    MessageBox.Show("No se encontraron numeros negativos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }

        private void promedio_Click(object sender, EventArgs e)
        {
            int list = 0;
            for (int i = 0; i < npositivos.Items.Count; i++)
            {
                list = Convert.ToInt32(nnegativos.Items[i]);
                if (list != 0)
                {
                    suma += Convert.ToInt32(npositivos.Items[i]);

                }
                else
                {
                    MessageBox.Show("No se encontraron numeros negativos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            prom = suma / npositivos.Items.Count;
            positivo.Text = prom.ToString();

        }
    }
}
