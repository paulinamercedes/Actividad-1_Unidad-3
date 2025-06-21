using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EJERCICIO1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonTabla_Click(object sender, EventArgs e)
        {

            int numero;

            if (int.TryParse(TextBoxNum.Text, out numero))
            {
                ListBoxTabla.Items.Clear();

                for (int i = 1; i <= 12; i++)
                {
                    ListBoxTabla.Items.Add($"{numero} x {i} = {numero * i}");
                }
            }
            else
            {
                MessageBox.Show("Favor ingresar un número válido.");
            }
        }
    }
}
