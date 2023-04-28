using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Ej10 : Form
    {
        public Ej10()
        {
            InitializeComponent();
        }
        private double ValorACelcius(double valor, string escala)
        {
            switch (escala)
            {
                case "Celsius":
                    return valor;
                case "Fahrenheit":
                    return (valor - 32) / 1.8;
                case "Kelvin":
                    return valor - 273.15;
                case "Rankine":
                    return (valor/(5 / 9.0)  ) - 273.15;
                default : 
                    return 0;
            }
        }
        private double CelciusEscala(double valor, string escala)
        {
            switch (escala)
            {
                case "Celsius":
                    return valor;
                case "Fahrenheit":
                    return (valor*1.8) + 32;
                case "Kelvin":
                    return valor + 273.15;
                case "Rankine":
                    return (valor + 273.15) * (9/5.0);
                default:
                    return 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string escalaInicial = comboBox1.Text;
            string escalaFinal = comboBox2.Text;
            int valor = int.Parse(textBox1.Text);
            double valorCInicial;
            double valorEFinal;

            valorCInicial = ValorACelcius(valor, escalaInicial);
            valorEFinal = CelciusEscala(valorCInicial, escalaFinal);
            dataGridView1.Rows.Add(
               valor,
               valorEFinal,
               escalaFinal
                );


        }
    }
}
