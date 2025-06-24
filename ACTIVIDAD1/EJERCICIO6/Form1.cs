using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // Validar el número de entrada

            if (int.TryParse(maskedTextBox1.Text, out int numero))
            {
                if (EsunNumPerfecto(numero))
                {
                    MessageBox.Show($"{numero} es un número perfecto.", "Resultado");
                }
                else
                {
                    MessageBox.Show($"{numero} NO es un número perfecto.", "Resultado");
                }
            }
            else
            {
                MessageBox.Show("Favor introducir un número válido", "Error");
            }
        }

        private bool EsunNumPerfecto(int n)
        {
            if (n <= 1) return false;  //Si el numero es menor o igual a 1, no es perfecto

            int suma = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0) //verifica si i es divisor de n
                {
                    suma += i;
                }
            }

            return suma == n; //compara si la suma de los divisores es igual al número de entrada
        }
    }
}
