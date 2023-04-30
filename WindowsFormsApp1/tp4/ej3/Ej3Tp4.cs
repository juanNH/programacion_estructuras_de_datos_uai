using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.tp4.ej3
{
    public partial class Ej3Tp4 : Form
    {
        ListCliente listCliente = new ListCliente();
        public Ej3Tp4()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void resetData()
        {
            listaCliente.Enabled = true;
            editarButton.Enabled = true;
            agregarSiguienteButton.Enabled = true;
            eliminarButton.Enabled = true;
            dniBox.Enabled = true;
            agregarButton.Visible = true;
            editarCancelarButton.Visible = false;
            editarClienteButton.Visible = false;
            dniBox.Text = "";
            nombresBox.Text = "";
            apellidosBox.Text = "";
        }
        private void editarCancelarButton_Click(object sender, EventArgs e)
        {
            resetData();
        }
        private void renderLista()
        {
            listaCliente.Items.Clear();
            listar(listCliente.nodoInicio);
        }
        private void listar(NodoCliente nodo)
        {
            if(nodo == null)
            {
                return;
            }
            listaCliente.Items.Add(nodo.getDniEdad());
            listar(nodo.Siguiente);
        }
        private void agregarButton_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(dniBox.Text);
            string nombres = nombresBox.Text;
            string apellidos = apellidosBox.Text;
            Random rd = new Random();
            int edad = rd.Next(5, 60);
            listCliente.AgregarFinal(dni, edad, nombres, apellidos);
            renderLista();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            if (listaCliente.SelectedItem == null)
            {
                return;
            }
            int dniClienteRemover = int.Parse(listaCliente.SelectedItem.ToString().Split(' ')[0]);
            listCliente.EliminarDeFila(dniClienteRemover);
            renderLista();

        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            if(listaCliente.SelectedItem == null) {
                return;
            }
            int dni = int.Parse(listaCliente.SelectedItem.ToString().Split(' ')[0]);

            NodoCliente nodo = listCliente.getNodoPorDni(listCliente.nodoInicio, dni);
            dniBox.Text = nodo.dni.ToString();
            apellidosBox.Text = nodo.apellidos;
            nombresBox.Text = nodo.nombres;
            dniBox.Enabled = false;
            listaCliente.Enabled = false;
            editarCancelarButton.Visible = true;
            editarClienteButton.Visible = true;
            eliminarButton.Enabled = false;
            agregarSiguienteButton.Enabled = false;
            editarButton.Enabled = false;
            agregarButton.Visible = false;
        }

        private void editarClienteButton_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(dniBox.Text);
            string nombres = nombresBox.Text;
            string apellidos = apellidosBox.Text;
            listCliente.EditarCliente(dni,nombres,apellidos);
            resetData();
            renderLista();
        }

        private void agregarSiguienteButton_Click(object sender, EventArgs e)
        {
            if(listaCliente.SelectedItem == null)
            {
                return;
            }
            int dniBuscar = int.Parse(listaCliente.SelectedItem.ToString().Split(' ')[0]);

            int dni = int.Parse(dniBox.Text);
            string nombres = nombresBox.Text;
            string apellidos = apellidosBox.Text;
            Random rd = new Random();
            int edad = rd.Next(5, 60);
            listCliente.AgregarSiguiente(dni, edad, nombres, apellidos, dniBuscar);
            renderLista();
        }
    }
}
