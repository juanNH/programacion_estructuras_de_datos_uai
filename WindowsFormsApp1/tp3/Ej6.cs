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
    public partial class Ej6 : Form
    {
        public Ej6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int v1 = 0;
            int v2 = 1;
            for (int i = 1; i <= num1; i++)
            {
                int count = v1;
                listBox1.Items.Add(count.ToString());
                v1 = v2;
                v2 = count + v1;
                if(i == num1)
                {
                    listBox1.Items.Add(v1.ToString());
                }
            }
        }
    }
}
