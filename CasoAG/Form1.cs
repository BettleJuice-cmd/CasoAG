using CasoAG.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasoAG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void jerarquíaOrganizativaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            new Arbol().Show();

        }

        private void sistemaDeRutasDelParqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Grafo().Show();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
