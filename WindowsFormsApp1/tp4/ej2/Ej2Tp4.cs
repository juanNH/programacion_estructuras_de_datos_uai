using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.tp4.ej1;

namespace WindowsFormsApp1.tp4.ej2
{
    public partial class Ej2Tp4 : Form
    {
        public ListAlumnos listAlumnos = new ListAlumnos();
        public Ej2Tp4()
        {
            InitializeComponent();
        }
        private void GeneraraLista()
        {
            alumnosLista.Items.Clear();
            Listar(listAlumnos.Inicio);

        }
        private void Listar(NodoAlumno nodo)
        {
            if (nodo == null)
            {
                return;
            }
            alumnosLista.Items.Add(nodo.getDniApellidos());
            if (nodo.Siguiente != null)
            {
                Listar(nodo.Siguiente);
            }
        }
        private void agregarButton_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(dniBox.Text);
            string nombres = nombresBox.Text;
            string apellidos = apellidosBox.Text;
            string direccion = direccionBox.Text;
            int telefono = int.Parse(telefonoBox.Text);
            string fechaNacimiento = nacimientoBox.Text;
            listAlumnos.CrearAlumnoFinal(dni,nombres,apellidos,direccion,telefono,fechaNacimiento);
            GeneraraLista();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            if(alumnosLista.SelectedItem == null)
            {
                return;
            }
            int dniAlumnoEliminar = int.Parse(alumnosLista.SelectedItem.ToString().Split(' ')[0]);
            listAlumnos.EliminarAlumnoPorDni(dniAlumnoEliminar);
            GeneraraLista();
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            if(alumnosLista.SelectedItem == null)
            {
                return;
            }
            agregarButton.Enabled = false;
            agregarArribaButton.Enabled = false;
            agregarAbajoButton.Enabled = false;
            eliminarButton.Enabled = false;
            editarButton.Enabled = false;
            editarAlumnoButton.Visible = true;
            editarCancelarButton.Visible = true;
            alumnosLista.Enabled = false;
            dniBox.Enabled = false;
            NodoAlumno alumnoEditar = listAlumnos.GetAlumnoSeleccionado(listAlumnos.Inicio, int.Parse(alumnosLista.SelectedItem.ToString().Split(' ')[0]));
            dniBox.Text = alumnoEditar.dni.ToString();
            apellidosBox.Text = alumnoEditar.apellidos;
            nombresBox.Text = alumnoEditar.nombres;
            telefonoBox.Text = alumnoEditar.telefono.ToString();
            direccionBox.Text = alumnoEditar.direccion.ToString();
            nacimientoBox.Text = alumnoEditar.fechaNacimiento;
        }

        private void editarCancelarButton_Click(object sender, EventArgs e)
        {
            limpiarData();
        }
        
        private void editarAlumnoButton_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(dniBox.Text);
            string nombres = nombresBox.Text;
            string apellidos = apellidosBox.Text;
            string direccion = direccionBox.Text;
            int telefono = (int)long.Parse(telefonoBox.Text);
            string fechaNacimiento = nacimientoBox.Text;
            listAlumnos.PutAlumnoSeleccionado(dni, nombres, apellidos, telefono, direccion, fechaNacimiento);
            GeneraraLista();
            limpiarData();
        }
        private void limpiarData()
        {
            agregarButton.Enabled = true;
            agregarArribaButton.Enabled = true;
            agregarAbajoButton.Enabled = true;
            eliminarButton.Enabled = true;
            editarButton.Enabled = true;
            editarAlumnoButton.Visible = false;
            editarCancelarButton.Visible = false;
            alumnosLista.Enabled = true;
            dniBox.Enabled = true;
            dniBox.Text = "";
            apellidosBox.Text = "";
            nombresBox.Text = "";
            telefonoBox.Text = "";
            direccionBox.Text = "";
            nacimientoBox.Text = "";
        }

        private void agregarArribaButton_Click(object sender, EventArgs e)
        {
            if(alumnosLista.SelectedItem == null)
            {
                return;
            }
            int dniSeleccionado = int.Parse(alumnosLista.SelectedItem.ToString().Split(' ')[0]);

            int dni = int.Parse(dniBox.Text);
            string nombres = nombresBox.Text;
            string apellidos = apellidosBox.Text;
            string direccion = direccionBox.Text;
            int telefono = int.Parse(telefonoBox.Text);
            string fechaNacimiento = nacimientoBox.Text;
            listAlumnos.CrearAlumnoSeleccionadoAnterior(dni, nombres, apellidos, direccion, telefono, fechaNacimiento, dniSeleccionado);
            GeneraraLista();
        }

        private void agregarAbajoButton_Click(object sender, EventArgs e)
        {
            if (alumnosLista.SelectedItem == null)
            {
                return;
            }
            int dniSeleccionado = int.Parse(alumnosLista.SelectedItem.ToString().Split(' ')[0]);

            int dni = int.Parse(dniBox.Text);
            string nombres = nombresBox.Text;
            string apellidos = apellidosBox.Text;
            string direccion = direccionBox.Text;
            int telefono = int.Parse(telefonoBox.Text);
            string fechaNacimiento = nacimientoBox.Text;
            listAlumnos.CrearAlumnoSeleccionadoSiguiente(dni, nombres, apellidos, direccion, telefono, fechaNacimiento, dniSeleccionado);
            GeneraraLista();
        }
    }
}
