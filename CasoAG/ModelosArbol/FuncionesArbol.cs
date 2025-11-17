using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasoAG.ModelosArbol
{
    public static class FuncionesArbol
    {
        public static TreeNode BuscarNodo(TreeNodeCollection coleccion, string texto)
        {
            foreach (TreeNode nodo in coleccion)
            {
                if (nodo.Text.ToLower().Contains(texto.ToLower()))
                {
                    return nodo;
                }

                TreeNode nodoHijo = BuscarNodo(nodo.Nodes, texto);

                if (nodoHijo != null)
                {
                    return nodoHijo;
                }

            }
            return null;
        }

        public static void RecorridoPreOrden(TreeNodeCollection coleccion, List<string> nodos)
        {

            foreach (TreeNode nodoRaiz in coleccion)
            {
                nodos.Add(nodoRaiz.Text);
                RecorridoPreOrden(nodoRaiz.Nodes, nodos);
            }

        }

        public static void RecorridoPostOrden(TreeNodeCollection coleccion, List<string> nodos)
        {
            foreach (TreeNode nodoRaiz in coleccion)
            {
                RecorridoPostOrden(nodoRaiz.Nodes, nodos);
                nodos.Add(nodoRaiz.Text);
            }
        }

        public static int ContarNodos(TreeNodeCollection listaNodos)
        {
            int contadorNodos = 0;

            foreach (TreeNode nodo in listaNodos)
            {
                contadorNodos = contadorNodos + 1;

                contadorNodos = contadorNodos + ContarNodos(listaNodos);
            }
            return contadorNodos;
        }
    }
}
