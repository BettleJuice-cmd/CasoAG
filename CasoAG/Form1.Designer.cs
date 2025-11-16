namespace CasoAG
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jerarquíaOrganizativaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaDeRutasDelParqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jerarquíaOrganizativaToolStripMenuItem,
            this.sistemaDeRutasDelParqueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jerarquíaOrganizativaToolStripMenuItem
            // 
            this.jerarquíaOrganizativaToolStripMenuItem.Name = "jerarquíaOrganizativaToolStripMenuItem";
            this.jerarquíaOrganizativaToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.jerarquíaOrganizativaToolStripMenuItem.Text = "Jerarquía Organizativa";
            this.jerarquíaOrganizativaToolStripMenuItem.Click += new System.EventHandler(this.jerarquíaOrganizativaToolStripMenuItem_Click);
            // 
            // sistemaDeRutasDelParqueToolStripMenuItem
            // 
            this.sistemaDeRutasDelParqueToolStripMenuItem.Name = "sistemaDeRutasDelParqueToolStripMenuItem";
            this.sistemaDeRutasDelParqueToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.sistemaDeRutasDelParqueToolStripMenuItem.Text = "Sistema de rutas del parque";
            this.sistemaDeRutasDelParqueToolStripMenuItem.Click += new System.EventHandler(this.sistemaDeRutasDelParqueToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jerarquíaOrganizativaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaDeRutasDelParqueToolStripMenuItem;
    }
}

