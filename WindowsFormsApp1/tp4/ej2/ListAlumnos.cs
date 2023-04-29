using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.tp4.ej2
{
    public class ListAlumnos
    {
        public NodoAlumno Inicio;

        public void CrearAlumnoFinal(int dni, string nombres, string apellidos, string direccion, int telefono, string fechaNacimiento)
        {
            NodoAlumno nodoAlumno = new NodoAlumno
            {
                dni = dni,
                nombres = nombres,
                apellidos = apellidos,
                direccion = direccion,
                telefono = telefono,
                fechaNacimiento = fechaNacimiento
            };
            if (Inicio == null)
            {
                Inicio = nodoAlumno;
                return;
            }
            NodoAlumno nodoAlumnoFinal = GetAlumnoFinal(Inicio);
            nodoAlumnoFinal.Siguiente = nodoAlumno;
        }
        public void EliminarAlumnoPorDni(int dni)
        {
            NodoAlumno nodoAlumnoEliminarAnterior = GetAlumnoSeleccionadoAnterior(Inicio, dni);
            NodoAlumno nodoAlumnoEliminarSiguiente = GetAlumnoSeleccionadoSiguiente(Inicio, dni);
            if (nodoAlumnoEliminarAnterior == null)
            {
                Inicio = nodoAlumnoEliminarSiguiente;
                return;
            }
            nodoAlumnoEliminarAnterior.Siguiente = nodoAlumnoEliminarSiguiente;
        }
        public void CrearAlumnoSeleccionadoAnterior(int dni, string nombres, string apellidos, string direccion, int telefono, string fechaNacimiento, int dniSeleccionado)
        {
            NodoAlumno nodoAlumno = new NodoAlumno
            {
                dni = dni,
                nombres = nombres,
                apellidos = apellidos,
                direccion = direccion,
                telefono = telefono,
                fechaNacimiento = fechaNacimiento
            };
            NodoAlumno nodoAlumnoAnterior = GetAlumnoSeleccionadoAnterior(Inicio, dniSeleccionado);
            NodoAlumno nodoAlumnoActual = GetAlumnoSeleccionado(Inicio, dniSeleccionado);
            if(nodoAlumnoAnterior != null)
            {
                nodoAlumnoAnterior.Siguiente = nodoAlumno;
            }
            else
            {
                Inicio = nodoAlumno;
            }
            if(nodoAlumno != null)
            {
                nodoAlumno.Siguiente = nodoAlumnoActual;
            }
        }
        public void CrearAlumnoSeleccionadoSiguiente(int dni, string nombres, string apellidos, string direccion, int telefono, string fechaNacimiento, int dniSeleccionado)
        {
            NodoAlumno nodoAlumno = new NodoAlumno
            {
                dni = dni,
                nombres = nombres,
                apellidos = apellidos,
                direccion = direccion,
                telefono = telefono,
                fechaNacimiento = fechaNacimiento
            };
            NodoAlumno nodoAlumnoActual = GetAlumnoSeleccionado(Inicio, dniSeleccionado);
            NodoAlumno nodoAlumnoSiguiente = GetAlumnoSeleccionadoSiguiente(Inicio, dniSeleccionado);
            if (nodoAlumnoActual != null)
            {
                nodoAlumnoActual.Siguiente = nodoAlumno;
            }
            if (nodoAlumnoSiguiente != null)
            {
                nodoAlumno.Siguiente = nodoAlumnoSiguiente;
            }
        }
        public NodoAlumno GetAlumnoSeleccionadoAnterior(NodoAlumno nodoAlumno, int dni)
        {
            if(nodoAlumno == null || nodoAlumno.dni == dni || nodoAlumno.Siguiente == null)
            {
                return null;
            }
            if(nodoAlumno.Siguiente.dni == dni)
            {
                return nodoAlumno;
            }
            return GetAlumnoSeleccionadoAnterior(nodoAlumno.Siguiente, dni);
        }
        public void PutAlumnoSeleccionado(int dni, string nombres, string apellidos, int telefono, string direccion, string fechaNacimiento)
        {
            NodoAlumno alumnoEditar = GetAlumnoSeleccionado(Inicio, dni);
            if(alumnoEditar == null)
            {
                return;
            }
            alumnoEditar.nombres = nombres;
            alumnoEditar.apellidos = apellidos;
            alumnoEditar.direccion = direccion;
            alumnoEditar.telefono = telefono;
            alumnoEditar.fechaNacimiento = fechaNacimiento;
        }
        public NodoAlumno GetAlumnoSeleccionadoSiguiente(NodoAlumno nodoAlumno, int dni)
        {
            if(nodoAlumno == null)
            {
                return null;
            }
            if (nodoAlumno.dni == dni)
            {
                return nodoAlumno.Siguiente;
            }
            return GetAlumnoSeleccionadoSiguiente(nodoAlumno.Siguiente, dni);
        }
        public NodoAlumno GetAlumnoFinal(NodoAlumno nodoAlumno)
        {
            if(nodoAlumno == null)
            {
                return null;
            }
            if(nodoAlumno.Siguiente != null)
            {
                return GetAlumnoFinal(nodoAlumno.Siguiente);
            }
            return nodoAlumno;
        }
        public NodoAlumno GetAlumnoSeleccionado(NodoAlumno nodoAlumno, int dni)
        {
            if(nodoAlumno == null)
            {
                return null;
            }
            if(nodoAlumno.dni == dni)
            {
                return nodoAlumno;
            }
            return GetAlumnoSeleccionado(nodoAlumno.Siguiente, dni);

        }
    }
}
