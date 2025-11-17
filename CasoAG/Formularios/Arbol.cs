using CasoAG.ModelosArbol;
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
            string textoBuscado = tbBuscar.Text;

            if(string.IsNullOrEmpty(textoBuscado))
            {
                MessageBox.Show("Por favor, ingrese un texto para buscar.");
                return;
            }

            TreeNode nodoEncontrado = FuncionesArbol.BuscarNodo(tvArbol.Nodes, textoBuscado);


            if (nodoEncontrado != null)
            {

                MessageBox.Show("El nodo fue encontrado!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }

            else
            {
                MessageBox.Show("EL NODO NO FUE ENCONTRADO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRecorrido_Click(object sender, EventArgs e)
        {
            lbPreOrden.Items.Clear();
            List<string> noditos = new List<string>();
            FuncionesArbol.RecorridoPreOrden(tvArbol.Nodes, noditos);
            foreach (string p in noditos)
            {
                lbPreOrden.Items.Add($"- {p}");
            }


           
        }

        private void btnPostOrden_Click(object sender, EventArgs e)
        {
            lbPostOrden.Items.Clear();
            List<string> nodos = new List<string>();

            FuncionesArbol.RecorridoPostOrden(tvArbol.Nodes, nodos);
            foreach(string p in nodos)
            {
                lbPostOrden.Items.Add($"- {p}");
            }
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            lblNodos.Text = "CANTIDAD DE NODOS TOTALES: ";
            int totalNodos = FuncionesArbol.ContarNodos(tvArbol.Nodes);

            lblNodos.Text += (totalNodos);

        }

        private void Arbol_Load(object sender, EventArgs e)
        {

        }
    }
    
}
