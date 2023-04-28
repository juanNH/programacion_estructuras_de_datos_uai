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
    public partial class Ej5 : Form
    {
        public Ej5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            for (int i = num1; i <= num2; i++)
            {
                Boolean esPrimo = true;
                for (int j = 2; j < i; j++)
                {
                    if ((i % j) == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                if(esPrimo == true)
                {
                    listBox1.Items.Add(i.ToString());
                }
            }
            
        }
    }
}
