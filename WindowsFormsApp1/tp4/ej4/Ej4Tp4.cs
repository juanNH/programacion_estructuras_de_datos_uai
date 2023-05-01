using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.tp4.ej4
{
    public partial class Ej4Tp4 : Form
    {
        ListAlumnos listAlumnos = new ListAlumnos();
        public Ej4Tp4()
        {
            InitializeComponent();
        }
        private void renderListado()
        {
            listaBox.Items.Clear();
            listar(listAlumnos.nodoInicio, listAlumnos.nodoInicio);
        }
        private void listar(NodoAlumno nodo, NodoAlumno nodoInicio)
        {
            if(nodo == null)
            {
                return;
            }
            listaBox.Items.Add(nodo.getDniNombre());

            if (nodo.Siguiente != nodoInicio)
            {
                listar(nodo.Siguiente, nodoInicio);
            }
        }
        private void valoresDefault()
        {
            dniBox.Text = "";
            nombreBox.Text = "";
            apellidoBox.Text = "";
            edadBox.Text = "";
            dniBox.Enabled = true;
            editarButton.Enabled = true;
            eliminarButton.Enabled = true;
            listaBox.Enabled = true;
            agregarSiguienteButton.Enabled = true;
            agregarEditarButton.Visible = false;
            cancelarEditarButton.Visible = false;
            agregarButton.Visible = true;
        }
        private void agregarButton_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(dniBox.Text);
            int edad = int.Parse(edadBox.Text);
            string nombre = nombreBox.Text;
            string apellido = apellidoBox.Text;
            listAlumnos.RegistrarAlumno(dni,edad, nombre, apellido);
            renderListado();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            if(listaBox.SelectedItem == null)
            {
                return;
            }
            int dni = int.Parse(listaBox.SelectedItem.ToString().Split(' ')[0]);
            listAlumnos.EliminarPorDni(dni);
            renderListado();

        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            if (listaBox.SelectedItem == null)
            {
                return;
            }
            int dni = int.Parse(listaBox.SelectedItem.ToString().Split(' ')[0]);
            NodoAlumno alumnoSeleccionado = listAlumnos.GetAlumnoPorDni(listAlumnos.nodoInicio,dni);
            dniBox.Text = alumnoSeleccionado.dni.ToString();
            nombreBox.Text = alumnoSeleccionado.nombre;
            apellidoBox.Text = alumnoSeleccionado.apellido;
            edadBox.Text = alumnoSeleccionado.edad.ToString();
            dniBox.Enabled = false;
            editarButton.Enabled = false;
            eliminarButton.Enabled = false;
            listaBox.Enabled = false;
            agregarSiguienteButton.Enabled = false;
            agregarEditarButton.Visible = true;
            cancelarEditarButton.Visible = true;
            agregarButton.Visible = false;
        }

        private void cancelarEditarButton_Click(object sender, EventArgs e)
        {
            valoresDefault();
        }

        private void agregarEditarButton_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(dniBox.Text);
            int edad = int.Parse(edadBox.Text);
            string nombre = nombreBox.Text;
            string apellido = apellidoBox.Text;
            listAlumnos.EditarAlumno(dni, edad, nombre, apellido);
            valoresDefault();
            renderListado();
        }

        private void agregarSiguienteButton_Click(object sender, EventArgs e)
        {
            if (listaBox.SelectedItem == null)
            {
                return;
            }
            int dniSeleccionado = int.Parse(listaBox.SelectedItem.ToString().Split(' ')[0]);
            int dni = int.Parse(dniBox.Text);
            int edad = int.Parse(edadBox.Text);
            string nombre = nombreBox.Text;
            string apellido = apellidoBox.Text;
            listAlumnos.AgregarSiguienteAlumno(dni, edad, nombre, apellido, dniSeleccionado);
            renderListado();
        }
    }
}
