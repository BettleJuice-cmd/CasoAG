using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasoAG.Formularios
{
    public partial class Arbol : Form
    {
       
        public Arbol()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            if(tvArbol.SelectedNode != null)
            {
               
                tvArbol.SelectedNode.Nodes.Add(tbJerarquia.Text);
            }
            else
            {
                tvArbol.Nodes.Add(tbJerarquia.Text);
            }
            tbJerarquia.Clear();
            tbJerarquia.Focus();

        }

        private void tvArbol_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                tvArbol.SelectedNode = e.Node;
                cmsArbol.Show(tvArbol, e.Location);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(tvArbol.SelectedNode != null)
            {
                tvArbol.SelectedNode.Nodes.Remove(tvArbol.SelectedNode);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBuscado = tbJerarquia.Text;

            if(string.IsNullOrEmpty(textoBuscado))
            {
                MessageBox.Show("Por favor, ingrese un texto para buscar.");
                return;
            }

            TreeNode nodoEncontrado = BuscarNodo(tvArbol.Nodes, textoBuscado);

            
            if (nodoEncontrado != null)
            {
               
                MessageBox.Show("¡Nodo encontrado!");
                tvArbol.SelectedNode = nodoEncontrado; 
                nodoEncontrado.Expand(); 
                tvArbol.Focus(); 
            }
            else
            {
               
                MessageBox.Show("No se encontró el nodo.");
            }
        }

        private TreeNode BuscarNodo(TreeNodeCollection coleccion, string texto)
        {
            foreach (TreeNode nodo in coleccion)
            {
                if (nodo.Text.ToLower().Contains(texto.ToLower()))
                {
                    return nodo;
                }

                TreeNode nodoHijo = BuscarNodo(nodo.Nodes, texto);

                if(nodoHijo != null)
                {
                    return nodoHijo;
                }

            }
            return null;
        }
    }
    
}
