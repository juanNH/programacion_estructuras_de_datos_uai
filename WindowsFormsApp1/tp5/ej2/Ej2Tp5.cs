using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.tp5.ej2
{
    public partial class Ej2Tp5 : Form
    {
        public PuebloList listPueblo = new PuebloList();
        public PuebloList listPuebloRecorrido = new PuebloList();
        public PuebloList listPuebloAux = new PuebloList();
        public string puebloActual = "";
        public Ej2Tp5()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            pueblosLista.Items.Clear();
            Agregar(listPueblo.NodoInicio);
        }
        private void Agregar(NodoPueblo nodo)
        {
            if(nodo == null)
            {
                return;
            }
            pueblosLista.Items.Add(nodo.nombre);
            Agregar(nodo.Siguiente);
        }
        private void ListarRecorridos()
        {
            recorridoLista.Items.Clear();
            AgregarRecorridos(listPuebloRecorrido.NodoInicio);
        }
        private void AgregarRecorridos(NodoPueblo nodo)
        {
            if (nodo == null)
            {
                return;
            }
            recorridoLista.Items.Add(nodo.nombre);
            AgregarRecorridos(nodo.Siguiente);
        }
        private void pushButton_Click(object sender, EventArgs e)
        {
            listPueblo.Push(puebloBox.Text);
            Listar();
        }

        private void popButton_Click(object sender, EventArgs e)
        {
            listPueblo.Pop();
            Listar();
        }
        private void viajar(string pueblo) 
        {
            acomodarViaje(listPueblo.NodoInicio, pueblo);
            acomodarLista(listPuebloAux.NodoInicio);
            labelPueblo.Text = "El pueblo actual es: " + puebloActual;

        }
        private void acomodarLista(NodoPueblo nodo)
        {
            if (nodo == null)
            {
                return;
            }
            listPueblo.Push(nodo.nombre);
            listPuebloAux.Pop();
            acomodarLista(nodo.Siguiente);
        }
        private void acomodarViaje(NodoPueblo nodo, string pueblo)
        {
            if(nodo == null)
            {
                return;
            }
            if (nodo.nombre == pueblo)
            {
                puebloActual = nodo.nombre;
                return;
            }
            if (nodo.nombre == puebloActual)
            {
                listPuebloRecorrido.NodoInicio = null;
            }
            listPuebloRecorrido.Push(nodo.nombre);
            listPuebloAux.Push(nodo.nombre);
            listPueblo.Pop();
            acomodarViaje(nodo.Siguiente, pueblo);
        }
        private void viajarButton_Click(object sender, EventArgs e)
        {
            if(pueblosLista.SelectedItem == null)
            {
                return;
            }
            string pueblo = pueblosLista.SelectedItem.ToString().Split(' ')[0];
            viajar(pueblo);
            Listar();
            ListarRecorridos();
        }
    }
}
