using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.tp4.ej1
{
    internal class NodoPaciente
    {
        public int codigo;
        public string nombres;
        public string apellidos;
        public int telefono;
        public NodoPaciente Siguiente;

        public string ListModel()
        {
            return codigo.ToString()+" "+apellidos;
        }
    }
}