using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Unidad de las ComboBox
            comboBoxEntrada.Items.AddRange(new string[] { "Metros", "Centímetros", "Pulgadas" });
            comboBoxSalida.Items.AddRange(new string[] { "Metros", "Centímetros", "Pulgadas" });
            comboBoxEntrada.SelectedIndex = 0;
            comboBoxSalida.SelectedIndex = 1;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double valor;
            if (!double.TryParse(textBoxValor.Text, out valor))
            {
                MessageBox.Show("Ingrese un número válido.");
                return;
            }

            string entrada = comboBoxEntrada.SelectedItem.ToString();
            string salida = comboBoxSalida.SelectedItem.ToString();

            double valorEnMetros = 0;

            // Convertir a metros como unidad inicial, luego a la unidad final

            switch (entrada)
            {
                case "Metros":
                    valorEnMetros = valor;
                    break;
                case "Centímetros":
                    valorEnMetros = valor / 100;
                    break;
                case "Pulgadas":
                    valorEnMetros = valor * 0.0254;
                    break;
            }

            double resultado = 0;
             
            // Convertir desde metros a unidad final elegida

            switch (salida)
            {
                case "Metros":
                    resultado = valorEnMetros;
                    break;
                case "Centímetros":
                    resultado = valorEnMetros * 100;
                    break;
                case "Pulgadas":
                    resultado = valorEnMetros / 0.0254;
                    break;
            }

            labelResultado.Text = " " + resultado.ToString("F4") + " " + salida;
        }

        private void comboBoxSalida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelResultado_Click(object sender, EventArgs e)
        {

        }
    }
}