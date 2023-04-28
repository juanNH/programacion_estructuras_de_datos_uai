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
    public partial class Ej7 : Form
    {
        public Ej7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int monto = int.Parse(textBox1.Text);
            int tasa = int.Parse(textBox2.Text);
            int dias = int.Parse(textBox3.Text);
            int interes = monto * tasa * dias / 36500;
            dataGridView1.Rows.Add(monto, tasa, dias, interes);
        }
    }
}
