using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO2
{
    public partial class Form1 : Form
    {
        int tiempoTotal;
        public Form1()
        {
            InitializeComponent();
        }
       
            private void btniniciar_Click(object sender, EventArgs e)
            {
            //verifica los minutos, si esta vacio el campo
                if (string.IsNullOrEmpty(textBoxMin.Text))
                {
                    MessageBox.Show("Favor introducir los minutos");
                textBoxMin.Focus();
                    return;
                }

                //verifica los segundos, si esta vacio el campo
                if (string.IsNullOrEmpty(textBoxSeg.Text))
                {
                    MessageBox.Show("Favor introducir los segundos");
                    textBoxSeg.Focus();
                    return;

                }

                int min = int.Parse(textBoxMin.Text);
                int sec = int.Parse(textBoxSeg.Text);
                tiempoTotal = min * 60 + sec;

                timer1.Start();

            }
        
            private void timer1_Tick(object sender, EventArgs e) //el temporizador
            {
                if (tiempoTotal > 0)
                {
                    tiempoTotal--;
                    int min = tiempoTotal / 60;
                    int sec = tiempoTotal % 60;
                    labeltiempo.Text = $"{min:D2}:{sec:D2}";
                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("El tiempo ha finalizado");

                }
            }
        }
    }

