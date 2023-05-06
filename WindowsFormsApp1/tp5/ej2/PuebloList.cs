using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.tp5.ej2
{
    public class PuebloList
    {
        public NodoPueblo NodoInicio;

        public void Push(string nombre)
        {
            NodoPueblo nodo = new NodoPueblo
            {
                nombre = nombre,
                Siguiente = NodoInicio,
            };
            NodoInicio = nodo;
        }
        public void Pop()
        {
            if(NodoInicio == null){
                return;
            }
            NodoInicio = NodoInicio.Siguiente;
        }
    }
}
