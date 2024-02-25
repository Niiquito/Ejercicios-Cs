using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(txtbox_primerValor.Text);
            int valor2 = int.Parse(txtbox_segundoValor.Text);
            int suma = valor1 + valor2;
            lbl_resultado.Text = "El resultado es: " + suma.ToString();
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(txtbox_primerValor.Text);
            int valor2 = int.Parse(txtbox_segundoValor.Text);
            int resta = valor1 - valor2;
            lbl_resultado.Text = "El resultado es: " + resta.ToString();
        }
    }
}
