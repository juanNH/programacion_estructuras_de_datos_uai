using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.tp4.ej3
{
    internal class NodoCliente
    {
        public int dni;
        public int edad;
        public string nombres;
        public string apellidos;
        public NodoCliente Siguiente;
        public string getDniEdad()
        {
            return dni.ToString()+" "+edad.ToString();
        }
    }
}
