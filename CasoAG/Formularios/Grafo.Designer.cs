namespace CasoAG.Formularios
{
    partial class Grafo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEdificio = new System.Windows.Forms.TextBox();
            this.lbEdificios = new System.Windows.Forms.ListBox();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarArista = new System.Windows.Forms.Button();
            this.tbDistancia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConexidad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(165, 54);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(174, 23);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "INSERTAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "INSERTAR EDIFICIO:";
            // 
            // tbEdificio
            // 
            this.tbEdificio.Location = new System.Drawing.Point(165, 24);
            this.tbEdificio.Name = "tbEdificio";
            this.tbEdificio.Size = new System.Drawing.Size(174, 22);
            this.tbEdificio.TabIndex = 2;
            // 
            // lbEdificios
            // 
            this.lbEdificios.FormattingEnabled = true;
            this.lbEdificios.ItemHeight = 16;
            this.lbEdificios.Location = new System.Drawing.Point(25, 83);
            this.lbEdificios.Name = "lbEdificios";
            this.lbEdificios.Size = new System.Drawing.Size(314, 276);
            this.lbEdificios.TabIndex = 3;
            // 
            // cbOrigen
            // 
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(362, 96);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(121, 24);
            this.cbOrigen.TabIndex = 4;
            // 
            // cbDestino
            // 
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(502, 96);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(121, 24);
            this.cbDestino.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "ENCONTRAR LA RUTA MÁS CORTA";
            // 
            // btnAgregarArista
            // 
            this.btnAgregarArista.Location = new System.Drawing.Point(401, 209);
            this.btnAgregarArista.Name = "btnAgregarArista";
            this.btnAgregarArista.Size = new System.Drawing.Size(197, 23);
            this.btnAgregarArista.TabIndex = 7;
            this.btnAgregarArista.Text = "AGREGAR ARISTA";
            this.btnAgregarArista.UseVisualStyleBackColor = true;
            this.btnAgregarArista.Click += new System.EventHandler(this.btnAgregarArista_Click);
            // 
            // tbDistancia
            // 
            this.tbDistancia.Location = new System.Drawing.Point(443, 164);
            this.tbDistancia.Name = "tbDistancia";
            this.tbDistancia.Size = new System.Drawing.Size(100, 22);
            this.tbDistancia.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "DISTANCIA";
            // 
            // btnConexidad
            // 
            this.btnConexidad.Location = new System.Drawing.Point(25, 378);
            this.btnConexidad.Name = "btnConexidad";
            this.btnConexidad.Size = new System.Drawing.Size(128, 42);
            this.btnConexidad.TabIndex = 10;
            this.btnConexidad.Text = "VALIDAR CONEXIDAD";
            this.btnConexidad.UseVisualStyleBackColor = true;
            // 
            // Grafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConexidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDistancia);
            this.Controls.Add(this.btnAgregarArista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDestino);
            this.Controls.Add(this.cbOrigen);
            this.Controls.Add(this.lbEdificios);
            this.Controls.Add(this.tbEdificio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertar);
            this.Name = "Grafo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafo";
            this.Load += new System.EventHandler(this.Grafo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEdificio;
        private System.Windows.Forms.ListBox lbEdificios;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarArista;
        private System.Windows.Forms.TextBox tbDistancia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConexidad;
    }
}