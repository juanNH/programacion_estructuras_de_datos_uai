using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Ej9 : Form
    {
        private int unoContador;
        private int dosContador = 0;
        private int tresContador = 0;
        private int cuatroContador = 0;
        private int cincoContador = 0;
        private int seisContador = 0;
        private int totalContador = 0;
        public Ej9()
        {

        InitializeComponent();
        }

        //internal static int uno = 0;
        private void AgregarContador(int dado)
        {
            switch (dado)
            {
                case 1:
                    unoContador += 1;
                    break;
                case 2:
                    dosContador += 1;
                    break;
                case 3:
                    tresContador += 1;
                    break;
                case 4:
                    cuatroContador += 1;
                    break;
                case 5:
                    cincoContador += 1;
                    break;
                case 6:
                    seisContador += 1;
                    break;
                default:
                    break;
            }
        }
        private string PorcentajeText (int valor)
        {
            return "Representa el: "+((valor*100)/totalContador).ToString()+"%";
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            int dado1 = rnd.Next(1, 7);
            int dado2 = rnd.Next(1, 7);
            totalContador += 2;
            AgregarContador(dado1);
            AgregarContador(dado2);
            label3.Text = dado1.ToString();
            label4.Text = dado2.ToString();
            dataGridView1.Rows.Add(
                unoContador,
                dosContador,
                tresContador,
                cuatroContador,
                cincoContador,
                seisContador,
                PorcentajeText(unoContador),
                PorcentajeText(dosContador),
                PorcentajeText(tresContador),
                PorcentajeText(cuatroContador),
                PorcentajeText(cincoContador),
                PorcentajeText(seisContador)
                );

        }
    }
}
