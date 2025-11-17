using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CasoAG.ModelosGrafo;

namespace CasoAG.Formularios
{
    
    public partial class Grafo : Form
    {
        private MotorGrafo miMapa;
        public Grafo()
        {
            InitializeComponent();
            miMapa = new MotorGrafo(); 
        }
        

        private void Grafo_Load(object sender, EventArgs e)
        {

        }

        private void CargarNodosEnCombobox()
        {
           
            var todosLosNodos = miMapa.ObtenerTodosLosNodos(); 
           
            cbOrigen.Items.Clear();
            cbDestino.Items.Clear();

            foreach (var nodo in todosLosNodos)
            {
                cbOrigen.Items.Add(nodo);
                cbDestino.Items.Add(nodo);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string nuevoNodo = tbEdificio.Text.Trim();

            if (string.IsNullOrEmpty(nuevoNodo))
            {
                MessageBox.Show("El nombre del edificio no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            miMapa.AgregarNodo(nuevoNodo);

            
            lbEdificios.Items.Add(nuevoNodo);
            CargarNodosEnCombobox(); 

            tbEdificio.Clear();
            MessageBox.Show($"Edificio '{nuevoNodo}' agregado al mapa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAgregarArista_Click(object sender, EventArgs e)
        {
            if (cbOrigen.SelectedItem == null || cbDestino.SelectedItem == null || string.IsNullOrEmpty(txtDistancia.Text))
            {
                MessageBox.Show("Debes seleccionar Origen, Destino e ingresar la Distancia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string origen = cbOrigen.SelectedItem.ToString();
            string destino = cbDestino.SelectedItem.ToString();

            if (int.TryParse(txtDistancia.Text, out int distancia) && distancia > 0)
            {
                // 2. Llamar a la función del Grafo (la que creamos con el peso)
                miMapa.AgregarArista(origen, destino, distancia);

                MessageBox.Show($"Conexión de {origen} a {destino} ({distancia}m) agregada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La distancia debe ser un número entero positivo.", "Error de Distancia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
