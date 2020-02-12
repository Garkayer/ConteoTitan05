using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConteoTitan05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            double[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.50, 0.25, 0.10, 0.05, 0.01 };
            double cantidad = double.Parse(txtCantidad.Text);
            sbyte n = 0;
            String respuesta = "Respuesta: \n";
            foreach (double denominacion in denominaciones)
            {
                while (denominacion <= Math.Round(cantidad, 2))
                {
                    n++;
                    cantidad -= denominacion;
                }
                if (n > 0)
                {
                    respuesta += n + (denominacion > 1 ? " Billetes " : " Monedas ") + denominacion + "\n";
                }
                n = 0;
            }
            lblRespuesta.Text = respuesta;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnFibonacci_Click(object sender, EventArgs e)
        {
            double primero = 0;
            double segundo = 1;
            double tercero = 1;
            txtCantidad.Text += primero.ToString() + "\r\n";
            txtCantidad.Text += segundo.ToString() + "\r\n";

            for (int i = 0; i < 5; i++)
            {
                tercero = segundo;
                segundo = primero + segundo;
                primero = tercero;
                 txtCantidad.Text += segundo.ToString() + "\r\n";


            }
        }
    }

}