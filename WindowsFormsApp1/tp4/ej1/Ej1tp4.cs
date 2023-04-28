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

namespace WindowsFormsApp1.tp4
{
    public partial class Ej1tp4 : Form
    {

        ListPaciente listPacientes = new ListPaciente();

        NodoPaciente nodoPaciente;
        public Ej1tp4()
        {
            InitializeComponent();
        }


        private void GeneraraLista()
        {
            listaPacientes.Items.Clear();
            Listar(listPacientes.NodoInicial);

        }
        private void Listar(NodoPaciente nodo)
        {
            if (nodo != null)
            {
                listaPacientes.Items.Add(nodo.ListModel());
                if (nodo.Siguiente != null)
                    Listar(nodo.Siguiente);
            }
        }
        private void registrarButton_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(codigoBox.Text);
            string nombres = nombreBox.Text;
            string apellido = apellidoBox.Text;
            int telefono = int.Parse(boxTelefono.Text);
            if(listaPacientes.SelectedItem == null)
            {
                listPacientes.AgregarAlFinal(codigo, nombres, apellido, telefono);
            }
            else
            {
                string itemSeleccionado = listaPacientes.SelectedItem.ToString();
                string code = itemSeleccionado.Split(' ')[0];
                listPacientes.AgregarDespuesCodigo(codigo, nombres, apellido, telefono, int.Parse(code));
            }
            GeneraraLista();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listaPacientes.SelectedItem == null)
            {
                return;
            }
            string itemSeleccionado = listaPacientes.SelectedItem.ToString();
            string code = itemSeleccionado.Split(' ')[0];
            listPacientes.EliminarSeleccionado(int.Parse(code));
            GeneraraLista();

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (listaPacientes.SelectedItem == null)
            {
                return;
            }
            buttonEditar.Enabled = false;
            string itemSeleccionado = listaPacientes.SelectedItem.ToString();
            string code = itemSeleccionado.Split(' ')[0];
            codigoBox.ReadOnly = true;
            NodoPaciente pacienteEditar = listPacientes.EncontrarPorCodigo(listPacientes.NodoInicial, int.Parse(code));
            codigoBox.Text = pacienteEditar.codigo.ToString();
            nombreBox.Text = pacienteEditar.nombres;
            apellidoBox.Text = pacienteEditar.apellidos;
            boxTelefono.Text = pacienteEditar.telefono.ToString();
            registrarButton.Visible = false;
            buttonEditarPaciente.Visible = true;
            buttonCancelarEditar.Visible = true;
            buttonEliminar.Enabled = false;
        }

        private void buttonCancelarEditar_Click(object sender, EventArgs e)
        {
            cleanEditar();

        }

        private void buttonEditarPaciente_Click(object sender, EventArgs e)
        {

            int codigo = int.Parse(codigoBox.Text);
            string nombres = nombreBox.Text;
            string apellido = apellidoBox.Text;
            int telefono = int.Parse(boxTelefono.Text);
            listPacientes.EditarSeleccionado(codigo, nombres, apellido, telefono);
            cleanEditar();
            GeneraraLista();

        }
        private void cleanEditar()
        {
            codigoBox.Text = "";
            nombreBox.Text = "";
            apellidoBox.Text = "";
            boxTelefono.Text = "";
            buttonEditarPaciente.Visible = false;
            buttonCancelarEditar.Visible = false;
            registrarButton.Visible = true;
            buttonEditar.Enabled = true;
            codigoBox.ReadOnly = false;
            buttonEliminar.Enabled = true;
        }
    }
}
