using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.tp5.ej1
{
    public class ListContainer
    {
        public NodoContainer NodoInicial;

        public void Push(int id)
        {
            NodoContainer nodo = new NodoContainer {
                identificador = id,
                Siguiente = NodoInicial,
            };
           NodoInicial = nodo;   
        }
        public void Pop() {
            if(NodoInicial == null)
            {
                return;
            }
            NodoInicial = NodoInicial.Siguiente;
        }
    }
}
