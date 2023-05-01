using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.tp4.ej4
{
    internal class ListAlumnos
    {
        public NodoAlumno nodoInicio;

        public void RegistrarAlumno(int dni, int edad, string nombre, string apellido)
        {
            NodoAlumno nodoAlumno = new NodoAlumno {
                dni= dni,
                edad= edad,
                nombre= nombre,
                apellido= apellido
            };
           if (nodoInicio == null)
            {

                nodoAlumno.Siguiente = nodoAlumno;
                nodoInicio = nodoAlumno;
                return;
            }
            NodoAlumno alumnoFinal = GetAlumnoFinal(nodoInicio, nodoInicio);
            alumnoFinal.Siguiente = nodoAlumno;
            nodoAlumno.Siguiente = nodoInicio;
        }
        public void AgregarSiguienteAlumno(int dni, int edad, string nombre, string apellido, int dniSeleccionado)
        {

            NodoAlumno nodoAlumno = new NodoAlumno
            {
                dni = dni,
                edad = edad,
                nombre = nombre,
                apellido = apellido
            };
            NodoAlumno alumnoSeleccionado = GetAlumnoPorDni(nodoInicio, dniSeleccionado);
            NodoAlumno alumnoSiguinte = GetAlumnoSiguientePorDni(nodoInicio, dniSeleccionado);
            alumnoSeleccionado.Siguiente = nodoAlumno;
            nodoAlumno.Siguiente = alumnoSiguinte;
        }
        public void EditarAlumno(int dni, int edad, string nombre, string apellido)
        {
            NodoAlumno alumnoEditar = GetAlumnoPorDni(nodoInicio, dni);
            alumnoEditar.edad = edad;
            alumnoEditar.nombre = nombre;
            alumnoEditar.apellido = apellido;
        }
        public void EliminarPorDni(int dni)
        {
            NodoAlumno alumnoAnterior = GetAlumnoAnteriorPorDni(nodoInicio,dni);
            NodoAlumno alumnoSiguienteEliminado = GetAlumnoSiguientePorDni(nodoInicio, dni);
            NodoAlumno alumnoEliminado = GetAlumnoPorDni(nodoInicio, dni);
           
            if (alumnoSiguienteEliminado == alumnoEliminado && alumnoAnterior == alumnoEliminado)
            {
                nodoInicio = null;
                return;
            }
            if (alumnoEliminado == nodoInicio)
            {
                nodoInicio = alumnoSiguienteEliminado;
            }
            alumnoAnterior.Siguiente = alumnoSiguienteEliminado;

        }
        public NodoAlumno GetAlumnoAnteriorPorDni(NodoAlumno nodo, int dni)
        {
            if (nodo.Siguiente.dni == dni)
            {
                return nodo;
            }
            return GetAlumnoAnteriorPorDni(nodo.Siguiente, dni);
        }
        public NodoAlumno GetAlumnoSiguientePorDni(NodoAlumno nodo, int dni)
        {
            if (nodo.dni == dni)
            {
                return nodo.Siguiente;
            }
            return GetAlumnoSiguientePorDni(nodo.Siguiente, dni);
        }
        public NodoAlumno GetAlumnoPorDni(NodoAlumno nodo, int dni)
        {
            if (nodo.dni == dni)
            {
                return nodo;
            }
            return GetAlumnoPorDni(nodo.Siguiente, dni);
        }
        public NodoAlumno GetAlumnoFinal(NodoAlumno nodo, NodoAlumno nodoInicio)
        {
            if(nodo.Siguiente == nodoInicio)
            {
                return nodo;
            }
            return GetAlumnoFinal(nodo.Siguiente, nodoInicio);
        }
    }
}
