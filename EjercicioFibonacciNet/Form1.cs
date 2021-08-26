using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioFibonacciNet
{
    public partial class Form1 : Form
    {
        string campoSalida;
        public Form1()
        {
            InitializeComponent();
            txtNumeroIngresado.Text = "0";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int numeroIngresado = int.Parse(txtNumeroIngresado.Text.ToString());

            int salida = Fibonacci.fibonacci(numeroIngresado);
            txtSalida.Visible = true;
            txtSalida.Text = salida.ToString();


            Boolean  esPrimo = NumeroPrimo.esPrimo(salida);
            if (esPrimo)
            {
                txtPrimo.Visible = true;
                txtPrimo.Text = "Es primo";
            }
            else
            {
                txtPrimo.Visible = true;
                txtPrimo.Text = "No es primo";

            }



        }
    }
}
