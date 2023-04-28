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
    public partial class Ej4 : Form
    {
        public Ej4()
        {
            InitializeComponent();
        }
        private void division_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            MessageBox.Show("La division entre los numeros es: " + (num1 / num2).ToString());

        }

        private void potencia_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            MessageBox.Show("La potencia de ambos numeros son: "+ (num1 * num1).ToString() + " y "+(num2 * num2).ToString());

        }

        private void sum_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            MessageBox.Show("La suma entre los numeros es: " + (num1 + num2).ToString());

        }

        private void resta_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            MessageBox.Show("La resta entre los numeros es: " + (num1 - num2).ToString());

        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            MessageBox.Show("La multiplicacion entre los numeros es: " + (num1 * num2).ToString());

        }

        private void raiz_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            MessageBox.Show("La raiz de ambos numeros son: " + (Math.Sqrt(num1)).ToString() + " y " + Math.Sqrt(num2).ToString());

        }
    }
}
