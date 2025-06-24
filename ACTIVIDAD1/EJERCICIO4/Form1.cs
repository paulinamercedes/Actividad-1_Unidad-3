using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            private void btnVerificar_Click(object sender, EventArgs e)
        {
            
            string texto = textBoxPalabra.Text.Trim().ToLower();

            //Verifica el textBox si tiene la palabra escrita, sino envia un mensaje

            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("Por favor, ingresar una palabra.");
                return;
            }


            //Verificar la palabra 

            string palabra = textBoxPalabra.Text.Trim().ToLower();
            string invertida = "";

            for (int i = palabra.Length - 1; i >= 0; i--)
            {
                invertida += palabra[i];
            }

            if (palabra == invertida)
            {
                MessageBox.Show("La palabra es palíndroma.", "Resultado");
            }
            else
            {
                MessageBox.Show("NO es una palabra palíndroma.", "Resultado");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPalabra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
