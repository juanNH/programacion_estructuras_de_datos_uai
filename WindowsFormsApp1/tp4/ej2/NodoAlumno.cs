using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.tp4.ej2
{
    public class NodoAlumno
    {
        public int dni;
        public string nombres;
        public string apellidos;
        public string direccion;
        public int telefono;
        public string fechaNacimiento;
        public NodoAlumno Siguiente;

        public string getDniApellidos()
        {
            return dni.ToString()+" "+nombres;
        }
    }
}
