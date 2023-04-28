using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.tp4.ej1
{
    class ListPaciente
    {
        public NodoPaciente NodoInicial = null;
        public void AgregarAlFinal(int codigo, string nombres, string apellidos, int telefono) {
            NodoPaciente nodo = new NodoPaciente
            {
                codigo = codigo,
                nombres = nombres,
                apellidos = apellidos,
                telefono = telefono
            };
            if(NodoInicial == null)
            {
                NodoInicial = nodo;
            }
            else
            {
                NodoPaciente ultimo = BuscarUltimo(NodoInicial);
                ultimo.Siguiente = nodo;
            }


        }
        public void EditarSeleccionado(int codigo, string nombres, string apellidos, int telefono)
        {
            NodoPaciente nodoSeleccionado = EncontrarPorCodigo(NodoInicial, codigo);
            if(nodoSeleccionado == null)
            {
                return;
            }
            nodoSeleccionado.nombres = nombres;
            nodoSeleccionado.apellidos = apellidos;
            nodoSeleccionado.telefono = telefono;

        }
        public void EliminarSeleccionado(int codigo)
        {
            if (NodoInicial == null)
            {
                return;
            }
            NodoPaciente nodoAnteriorEliminado = AnteriorCodigoSeleccionado(NodoInicial, codigo);
            NodoPaciente nodoSiguienteEliminado = SiguienteCodigoSeleccionado(NodoInicial, codigo);
            if (nodoAnteriorEliminado == null)
            {
                NodoInicial = nodoSiguienteEliminado;
            }else
            {
                nodoAnteriorEliminado.Siguiente = nodoSiguienteEliminado;
            }

        }
        public void AgregarDespuesCodigo(int codigo, string nombres, string apellidos, int telefono, int codigoSeleccionado)
        {
            NodoPaciente nodoSeleccionado = EncontrarPorCodigo(NodoInicial, codigoSeleccionado);
            NodoPaciente nodoSeleccionadoSiguiente = SiguienteCodigoSeleccionado(NodoInicial, codigoSeleccionado);
            NodoPaciente nodo = new NodoPaciente
            {
                codigo = codigo,
                nombres = nombres,
                apellidos = apellidos,
                telefono = telefono
            };
            nodo.Siguiente = nodoSeleccionadoSiguiente;
            nodoSeleccionado.Siguiente = nodo;

        }
        public NodoPaciente EncontrarPorCodigo(NodoPaciente nodo, int codigo)
        {
            if (nodo == null) return null;
            if (nodo.codigo == codigo)
            {
                return nodo;

            }
            else if (nodo.Siguiente != null)
            {
                return EncontrarPorCodigo(nodo.Siguiente, codigo);
            }
            else
            {
                return null;
            }
        }
        private NodoPaciente SiguienteCodigoSeleccionado(NodoPaciente nodo, int codigo)
        {
            if (nodo == null) return null;
            if(nodo.codigo == codigo)
            {
                if (nodo.Siguiente != null)
                {
                    return nodo.Siguiente;
                }
                else
                {
                    return null;
                }
            }
            else if(nodo.Siguiente != null)
            {
                return SiguienteCodigoSeleccionado(nodo.Siguiente, codigo);
            }
            else
            {
                return null;
            }
        }
        private NodoPaciente AnteriorCodigoSeleccionado(NodoPaciente nodo, int codigo)
        {
            if (nodo == null || nodo.codigo == codigo) return null;
            if (nodo.Siguiente != null)
            {
                if (nodo.Siguiente.codigo == codigo)
                {
                    return nodo;
                }
                else
                {
                    return AnteriorCodigoSeleccionado(nodo.Siguiente, codigo);
                }
            }
            else
            {
                return null;
            }
        }
        private NodoPaciente BuscarUltimo(NodoPaciente nodo)
        {
            //la lista este vacia
            if (nodo == null) return null;

            //que no sea el ultimo
            if (nodo.Siguiente != null)
                return BuscarUltimo(nodo.Siguiente);
            else
                return nodo;

        }
    }
}
