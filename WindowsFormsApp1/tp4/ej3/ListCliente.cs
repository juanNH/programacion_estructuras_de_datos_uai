using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.tp4.ej3
{
    internal class ListCliente
    {
        public NodoCliente nodoInicio;
       
        public void AgregarFinal(int dni, int edad, string nombres, string apellidos)
        {
            NodoCliente nodoCliente = new NodoCliente { 
                dni = dni,
                edad = edad,
                nombres = nombres,
                apellidos = apellidos
            };
            if( nodoInicio == null )
            {
                nodoInicio = nodoCliente;
                return;
            }
            NodoCliente nodoFinal = getNodoClienteFinal(nodoInicio);
            nodoFinal.Siguiente = nodoCliente;
        }
        public void AgregarSiguiente(int dni, int edad, string nombres, string apellidos, int dniBuscar)
        {
            NodoCliente nodoCliente = new NodoCliente
            {
                dni = dni,
                edad = edad,
                nombres = nombres,
                apellidos = apellidos
            };
            if (nodoInicio == null)
            {
                nodoInicio = nodoCliente;
                return;
            }
            
            NodoCliente nodoActual = getNodoPorDni(nodoInicio,dniBuscar);
            NodoCliente nodoSiguiente = getNodoSiguiente(nodoInicio, dniBuscar);
            if(nodoActual == null)
            {
                nodoInicio = nodoCliente;
            }
            else
            {
                nodoActual.Siguiente = nodoCliente;
            }
            nodoCliente.Siguiente = nodoSiguiente;
        }
        public void EliminarDeFila(int dni)
        {
            NodoCliente nodoAnterior = getNodoAnterior(nodoInicio, dni);
            NodoCliente nodoSiguiente = getNodoSiguiente(nodoInicio, dni);
            if(nodoAnterior == null)
            {
                nodoInicio = nodoSiguiente;
            }
            else
            {
                nodoAnterior.Siguiente = nodoSiguiente;
            }


        }
        public void EditarCliente(int dni, string nombres, string apellidos)
        {
            NodoCliente nodo = getNodoPorDni(nodoInicio, dni);
            if(nodo == null)
            {
                return;
            }
            nodo.nombres = nombres;
            nodo.apellidos = apellidos;
        }
        public NodoCliente getNodoPorDni(NodoCliente nodo,int dni)
        {
            if ( nodo == null)
            {
                return null;
            }
            if( nodo.dni == dni)
            {
                return nodo;
            }
            return getNodoPorDni(nodo.Siguiente, dni);
        }
        public NodoCliente getNodoAnterior(NodoCliente nodo,int dni)
        {
            if(nodo == null || nodo.dni == dni || nodo.Siguiente == null)
            {
                return null;
            }
            if(nodo.Siguiente.dni == dni)
            {
                return nodo;
            }
            return getNodoAnterior(nodo.Siguiente, dni);
        }
        public NodoCliente getNodoSiguiente(NodoCliente nodo, int dni)
        {
            if (nodo == null  || nodo.Siguiente == null)
            {
                return null;
            }
            if (nodo.dni == dni)
            {
                return nodo.Siguiente;
            }
            return getNodoSiguiente(nodo.Siguiente, dni);
        }
        public NodoCliente getNodoClienteFinal(NodoCliente nodo)
        {
            if(nodo == null)
            {
                return null;
            }
            if(nodo.Siguiente == null)
            {
                return nodo;
            }
            return getNodoClienteFinal(nodo.Siguiente);
        }
    }
}
