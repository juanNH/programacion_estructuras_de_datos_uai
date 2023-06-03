using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.tp7._1
{
    internal class Tree
    {
        private Nodo raiz;

        public void AgregarNodo(Nodo nodoNuevo)
        {
            if(raiz == null)
            {
                raiz = nodoNuevo;
                return;
            }
            AddNewNodo(nodoNuevo, raiz);
        }
        private void AddNewNodo(Nodo nodoNuevo,Nodo nodo)
        {
            if(nodoNuevo.valor == nodo.valor)
            {
                return;
            }
            if (nodo.valor > nodoNuevo.valor)
            {
                if(nodo.izquierda == null)
                {
                    nodo.izquierda = nodoNuevo;
                    return;
                }
                AddNewNodo(nodoNuevo, nodo.izquierda);
            }
            else
            {
                if(nodo.derecha == null)
                {
                    nodo.derecha = nodoNuevo;
                    return;
                }
                AddNewNodo(nodoNuevo, nodo.derecha);
            }
        }
        public string PostOrder()
        {
            return "";
        }
        public void Busqueda(Nodo nodo)
        {

        }
        public Nodo GetRaiz() { return raiz; }
    }
}
