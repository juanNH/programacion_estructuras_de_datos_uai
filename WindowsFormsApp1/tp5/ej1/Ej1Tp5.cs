using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.tp5.ej1
{
    public partial class Ej1Tp5 : Form
    {
        public ListContainer ContainerList = new ListContainer();
        public ListContainer ContainerListAux = new ListContainer();

        public Ej1Tp5()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            containerLista.Items.Clear();
            Agregar(ContainerList.NodoInicial);

        }
        private void Agregar(NodoContainer nodo)
        {
            if(nodo == null)
            {
                return;
            }
            containerLista.Items.Add(nodo.identificador);
            Agregar(nodo.Siguiente);
        }

        private void pushButton_Click(object sender, EventArgs e)
        {
            ContainerList.Push(int.Parse(idBox.Text));
            Listar();
        }

        private void popButton_Click(object sender, EventArgs e)
        {
            ContainerList.Pop();
            Listar();
        }
        
        private void eliminarButton_Click(object sender, EventArgs e)
        {
            if(containerLista.SelectedItem == null)
            {
                return;
            }
            int id = int.Parse(containerLista.SelectedItem.ToString().Split(' ')[0]);
            removeIdSelected(id);
            Listar();
        }
        private void removeIdSelected(int id) {
            checkList(ContainerList.NodoInicial, id);
            addAuxListToList(ContainerListAux.NodoInicial);
        }
        private void addAuxListToList(NodoContainer nodo)
        {
            if(nodo == null)
            {
                return;
            }
            ContainerList.Push(nodo.identificador);
            ContainerListAux.Pop();
            addAuxListToList(nodo.Siguiente);
        }
        private void checkList(NodoContainer nodo, int id)
        {
            if(nodo.identificador == id)
            {
                ContainerList.Pop();
                return;
            }
            ContainerListAux.Push(nodo.identificador);
            ContainerList.Pop();
            checkList(nodo.Siguiente, id);
        }
    }
}
