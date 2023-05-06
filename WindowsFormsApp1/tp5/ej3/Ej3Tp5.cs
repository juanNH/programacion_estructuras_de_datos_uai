using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.tp5.ej1;
using WindowsFormsApp1.tp5.ej2;

namespace WindowsFormsApp1.tp5.ej3
{
    public partial class Ej3Tp5 : Form
    {
        public ListExp listExp = new ListExp();
        public ListExp listExpAux = new ListExp();
        public ListExp listExpOrdenado = new ListExp();
        public DateTime? minDate = null;
        public int nroExpToOrder;
        public int nroMax;

        public Ej3Tp5()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            listaExpedientes.Items.Clear();
            Agregar(listExp.NodoInicio);
        }
       
        private void Agregar(NodoExpcs nodo)
        {
            if (nodo == null)
            {
                return;
            }
            listaExpedientes.Items.Add(nodo.nroFecha());
            Agregar(nodo.Siguiente);
        }
        private void pushButton_Click(object sender, EventArgs e)
        {
            string caratula = caratulaBox.Text;
            DateTime fecha = fechaBox.Value;
            int nroExp = int.Parse(nroExpBox.Text);
            listExp.Push(fecha, caratula, nroExp);
            Listar();
        }

        private void popButton_Click(object sender, EventArgs e)
        {
            listExp.Pop();
            Listar();
        }
        private void recorrerPila()
        {
            gestionarRecorridaValores(listExp.NodoInicio);
            addAuxListToList(listExpAux.NodoInicio);
        }

        private void addAuxListToList(NodoExpcs nodo)
        {
            if (nodo == null)
            {
                return;
            }
            listExp.Push(nodo.fecha, nodo.caratula, nodo.nroExp);
            listExpAux.Pop();
            addAuxListToList(nodo.Siguiente);
        }
        private void gestionarRecorridaValores(NodoExpcs nodo)
        {
            if( nodo == null) { return; }
            if(minDate == null)
            {
                minDate = nodo.fecha;
                nroMax = nodo.nroExp;
                nroExpToOrder = nodo.nroExp;
            }
            else
            {
                if (nodo.fecha.CompareTo(minDate) > 0)
                {
                    minDate = nodo.fecha;
                    nroMax = nodo.nroExp;
                    nroExpToOrder = nodo.nroExp;
                }
                else if(nodo.fecha.CompareTo(minDate) == 0 && nodo.nroExp >= nroMax)
                {
                    minDate = nodo.fecha;
                    nroMax = nodo.nroExp;
                    nroExpToOrder = nodo.nroExp;
                }
            }
            listExpAux.Push(nodo.fecha, nodo.caratula, nodo.nroExp);
            listExp.Pop();
            gestionarRecorridaValores(nodo.Siguiente);
        }
        private void agregarAListaOrdenada(NodoExpcs nodo, int id)
        {
            if (nodo == null) { return; }
            if(nodo.nroExp == id)
            {
                listExpOrdenado.Push(nodo.fecha, nodo.caratula, nodo.nroExp);
                listExp.Pop();
                return;
            }
            listExpAux.Push(nodo.fecha, nodo.caratula, nodo.nroExp);
            listExp.Pop();
            agregarAListaOrdenada(nodo.Siguiente, id);
        }
        private void ordenarPila()
        {
            agregarAListaOrdenada(listExp.NodoInicio, nroExpToOrder);
            addAuxListToList(listExpAux.NodoInicio);
        }
        private void ListarOrdenado()
        {
            acomodarListadoOrdenado(listExpOrdenado.NodoInicio);
        }
        private void acomodarListadoOrdenado(NodoExpcs nodo)
        {
            if (nodo == null) { return; }
            listExp.Push(nodo.fecha, nodo.caratula, nodo.nroExp);
            listExpOrdenado.Pop();
            acomodarListadoOrdenado(nodo.Siguiente);
        }
        private void ordenarButton_Click(object sender, EventArgs e)
        {
            while(listExp.NodoInicio != null)
            {
                recorrerPila();
                ordenarPila();
                minDate = null;
                nroExpToOrder = 0;
                nroMax = 0;
            }
            ListarOrdenado();
            Listar();
        }
    }
}
