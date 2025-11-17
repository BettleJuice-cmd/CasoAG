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
            this.ControlBox = false;
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
            if (cbOrigen.SelectedItem == null || cbDestino.SelectedItem == null || string.IsNullOrEmpty(tbDistancia.Text))
            {
                MessageBox.Show("Debes seleccionar Origen, Destino e ingresar la Distancia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string origen = cbOrigen.SelectedItem.ToString();
            string destino = cbDestino.SelectedItem.ToString();

            if (int.TryParse(tbDistancia.Text, out int distancia) && distancia > 0)
            {
               
                miMapa.AgregarArista(origen, destino, distancia);

                MessageBox.Show($"Conexión de {origen} a {destino} ({distancia}m) agregada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La distancia debe ser un número entero positivo.", "Error de Distancia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConexidad_Click(object sender, EventArgs e)
        {
            bool esConexo = miMapa.EsConexo(); 
          
            if (esConexo)
            {
                lblConexidad.Text = "✅ El parque es CONEXO. Todos los edificios son accesibles.";
                lblConexidad.ForeColor = Color.Green;
            }
            else
            {
                lblConexidad.Text = "❌ El parque NO es CONEXO. Hay edificios aislados.";
                lblConexidad.ForeColor = Color.Red;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }

        private void btnRutaCorta_Click(object sender, EventArgs e)
        {
            string inicio = cbOrigen.SelectedItem?.ToString(); 
            string fin = cbDestino.SelectedItem?.ToString();   

           
            if (string.IsNullOrEmpty(inicio) || string.IsNullOrEmpty(fin))
            {
                MessageBox.Show("Por favor, selecciona un edificio de inicio y uno final para calcular la ruta.", "Error de Selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (inicio == fin)
            {
                MessageBox.Show("El edificio de inicio y el final no pueden ser el mismo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            List<string> rutaOptima = miMapa.RutaCorta(inicio, fin); 

            
            if (rutaOptima.Count > 0)
            {
                string rutaTexto = string.Join(" -> ", rutaOptima);
                int distanciaTotal = miMapa.ObtenerDistanciaTotalRuta(rutaOptima); 

                MessageBox.Show($"Ruta más corta de {inicio} a {fin}:\r\n{rutaTexto}\r\nDistancia total: {distanciaTotal}m", "Ruta Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No se pudo encontrar una ruta entre '{inicio}' y '{fin}'.\r\nVerifica que los edificios existan y estén conectados.", "Ruta No Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
