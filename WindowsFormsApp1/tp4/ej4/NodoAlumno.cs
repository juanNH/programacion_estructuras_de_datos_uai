using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.tp4.ej4
{
    internal class NodoAlumno
    {
        public int dni;
        public int edad;
        public string nombre;
        public string apellido;
        public NodoAlumno Siguiente;
        public string getDniNombre()
        {
            return dni.ToString()+" "+nombre;
        }
    }
}
