using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            {
                int numero;

                if (!int.TryParse(MtxtBoxNumero.Text, out numero) || numero < 1)
                {
                    MessageBox.Show("Ingrese un número entero positivo válido.");
                    return;
                }

                //llama a la funcion EsPrimo 
                if (EsPrimo(numero))
                {
                    MessageBox.Show($"{numero} es un número primo.");
                }
                else
                {
                    MessageBox.Show($"{numero} NO es un número primo.");
                }
            }
        }

        //operador booleano para devolver una respuesta mas certera de si es un numero primo o no 
        private bool EsPrimo(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0)
                    return false;
            }
            return true;

        }
    }
}

