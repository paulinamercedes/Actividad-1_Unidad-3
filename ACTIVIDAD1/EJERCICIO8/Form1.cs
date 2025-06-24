using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOracion_Click(object sender, EventArgs e)
        {
            string oracion = textBoxOracion.Text.Trim();

            if(string.IsNullOrEmpty(oracion))
            {
                MessageBox.Show("Favor escribir una oración", "Campo vacío");

                lblPalabras.Text = "Cantidad: 0"; //Muestra la cantidad de palabras en el label
                return;
            }

            //Separa las palabras y elimina lo espacios vacios
            string[] palabras = oracion.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            lblPalabras.Text = $"Cantidad: {palabras.Length}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
