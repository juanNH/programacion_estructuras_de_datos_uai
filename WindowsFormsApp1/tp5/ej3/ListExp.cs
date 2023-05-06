using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.tp5.ej2;

namespace WindowsFormsApp1.tp5.ej3
{
    public class ListExp
    {
        public NodoExpcs NodoInicio;
        public void Push(DateTime fecha, string caratula, int nroExp)
        {
            NodoExpcs nodo = new NodoExpcs
            {
                fecha = fecha,
                caratula = caratula,
                nroExp = nroExp,
                Siguiente = NodoInicio,
            };
            NodoInicio = nodo;
        }
        public void Pop()
        {
            if (NodoInicio == null)
            {
                return;
            }
            NodoInicio = NodoInicio.Siguiente;
        }
    }
}
