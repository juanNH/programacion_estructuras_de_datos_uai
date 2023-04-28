using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Ej11 : Form
    {
        private int turno = 2;
        public Ej11()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(button.Text != "")
            {
                return;
            }
            if(turno % 2 == 0)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "0";
            }
            Boolean fin = verificadorGanador();
            turno += 1;
            if (turno ==  11 && !fin)
            {
                MessageBox.Show("Empate");
            }
        }
        private bool verificadorGanador()
        {
            // ganador horizontal
            if(a1.Text == a2.Text && a2.Text == a3.Text && a1.Text != "")
            {
                winnerMsg();
                return true;
            }
            if (b1.Text == b2.Text && b2.Text == b3.Text && b1.Text != "")
            {
                winnerMsg();
                return true;

            }
            if (c1.Text == c2.Text && a2.Text == c3.Text && c1.Text != "")
            {
                winnerMsg();
                return true;

            }
            // ganador vertical
            if (a1.Text == b1.Text && b1.Text == c1.Text && a1.Text != "")
            {
                winnerMsg();
                return true;

            }
            if (a2.Text == b2.Text && b2.Text == c2.Text && a2.Text != "")
            {
                winnerMsg();
                return true;

            }
            if (a3.Text == b3.Text && b3.Text == c3.Text && a3.Text != "")
            {
                winnerMsg();
                return true;

            }
            // ganador cruzado
            if (a1.Text == b2.Text && b2.Text == c3.Text && a1.Text != "")
            {
                winnerMsg();
                return true;

            }
            if (a3.Text == b2.Text && b2.Text == c1.Text && a3.Text != "")
            {
                winnerMsg();
                return true;

            }
            return false;
        }
        private void winnerMsg()
        {
            if (turno % 2 == 0)
            {
                MessageBox.Show("Ganador X");
            }
            else
            {
                MessageBox.Show("Ganador 0");
            }
        } 
    }
}
