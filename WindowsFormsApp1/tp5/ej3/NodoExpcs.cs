using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.tp5.ej3
{
    public class NodoExpcs
    {
        public DateTime fecha;
        public int nroExp;
        public string caratula;
        public NodoExpcs Siguiente;

        public string nroFecha()
        {
            return nroExp.ToString()+" "+fecha;
        }
    }
}
