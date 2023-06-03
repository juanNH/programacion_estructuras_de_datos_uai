using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.tp7._1
{
    public partial class Ej0Tp7 : Form
    {
        private Tree arbol = new Tree();
        public Ej0Tp7()
        {
            InitializeComponent();
        }

        private void listarArbol()
        {
            treeNodo.Nodes.Clear();
            addToTree(arbol.GetRaiz(), null, string.Empty);
            treeNodo.ExpandAll();
        }
        private void addToTree(Nodo nodo, TreeNode padre, string lado)
        {
            if (nodo == null)
            {
                return;
            }
            TreeNode nuevo = new TreeNode{
                Text = nodo.valor.ToString()};
            if(padre == null && lado == string.Empty)
            {
                treeNodo.Nodes.Add(nuevo);
            }
            else
            {
                nuevo.Text = $"{lado} => {nodo.valor}";
                padre.Nodes.Add(nuevo);
            }
            if (nodo.derecha != null) addToTree(nodo.derecha, nuevo, "D");
            if (nodo.izquierda != null) addToTree(nodo.izquierda,nuevo, "I");
        }
        private void agregarButton_Click(object sender, EventArgs e)
        {
            decimal valor = numeroBox.Value;
            Nodo nodoNuevo = new Nodo
            {
                valor=valor
            };
            arbol.AgregarNodo(nodoNuevo);
            listarArbol();
        }

        private void preOrderButton_Click(object sender, EventArgs e)
        {
           treeBox.Text = "";
           PreOrderRecursive(arbol.GetRaiz());
        }
        private void PreOrderRecursive(Nodo node)
        {
            if (node == null)
            {
                return;
            }
            treeBox.Text = treeBox.Text + " => " + node.valor.ToString();
            PreOrderRecursive(node.izquierda);
            PreOrderRecursive(node.derecha);
        }

        private void inOrderButton_Click(object sender, EventArgs e)
        {

            treeBox.Text = "";
            InOrderRecursive(arbol.GetRaiz());
        }
        
        private void InOrderRecursive(Nodo node)
        {
            if (node == null)
            {
                return;
            }
            InOrderRecursive(node.izquierda);
            treeBox.Text = treeBox.Text + " => " + node.valor.ToString();
            InOrderRecursive(node.derecha);
        }

        private void postOrderButton_Click(object sender, EventArgs e)
        {
            treeBox.Text = "";
            PostOrderRecursive(arbol.GetRaiz());
        }

        private void PostOrderRecursive(Nodo node)
        {
            if (node == null)
            {
                return;
            }
            PostOrderRecursive(node.izquierda);
            PostOrderRecursive(node.derecha);
            treeBox.Text = treeBox.Text + " => " + node.valor.ToString();
        }
    }
}
