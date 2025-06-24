using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumPrimos_Click(object sender, EventArgs e)
        {
            // Limpia la listBox antes de volver a iniciar
            lstBoxPrimos.Items.Clear();

            // convierte los valores ingresados a los textBox
            if (int.TryParse(textBoxInicio.Text, out int inicio) &&
                int.TryParse(textBoxFin.Text, out int fin))
            {
                if (inicio > fin)
                {
                    MessageBox.Show("El inicio debe ser menor o igual al final.");
                    return;
                }

                for (int i = inicio; i <= fin; i++)
                {
                    if (EsPrimo(i))
                    {
                        lstBoxPrimos.Items.Add(i);
                    }
                }

                if (lstBoxPrimos.Items.Count == 0)
                {
                    MessageBox.Show("No se encontraron números primos en ese rango.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingresa valores numéricos válidos.");
            }
        }

        // Función Booleana que verifica si es primo o no
        private bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstBoxPrimos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}    

