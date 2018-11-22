namespace Aplicacion_strawberry
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iniciarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.v1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.espectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesionToolStripMenuItem,
            this.jugadorToolStripMenuItem,
            this.juegoToolStripMenuItem,
            this.espectarToolStripMenuItem,
            this.eventosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iniciarSesionToolStripMenuItem
            // 
            this.iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
            this.iniciarSesionToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.iniciarSesionToolStripMenuItem.Text = "Iniciar sesion";
            this.iniciarSesionToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesionToolStripMenuItem_Click);
            // 
            // jugadorToolStripMenuItem
            // 
            this.jugadorToolStripMenuItem.Name = "jugadorToolStripMenuItem";
            this.jugadorToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.jugadorToolStripMenuItem.Text = "Jugador";
            // 
            // juegoToolStripMenuItem
            // 
            this.juegoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jugarToolStripMenuItem,
            this.v1ToolStripMenuItem});
            this.juegoToolStripMenuItem.Name = "juegoToolStripMenuItem";
            this.juegoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.juegoToolStripMenuItem.Text = "Juego";
            // 
            // jugarToolStripMenuItem
            // 
            this.jugarToolStripMenuItem.Name = "jugarToolStripMenuItem";
            this.jugarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.jugarToolStripMenuItem.Text = "Jugar";
            this.jugarToolStripMenuItem.Click += new System.EventHandler(this.jugarToolStripMenuItem_Click);
            // 
            // v1ToolStripMenuItem
            // 
            this.v1ToolStripMenuItem.Name = "v1ToolStripMenuItem";
            this.v1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.v1ToolStripMenuItem.Text = "1v1";
            this.v1ToolStripMenuItem.Click += new System.EventHandler(this.v1ToolStripMenuItem_Click);
            // 
            // espectarToolStripMenuItem
            // 
            this.espectarToolStripMenuItem.Name = "espectarToolStripMenuItem";
            this.espectarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.espectarToolStripMenuItem.Text = "Espectar";
            this.espectarToolStripMenuItem.Click += new System.EventHandler(this.espectarToolStripMenuItem_Click);
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.eventosToolStripMenuItem.Text = "Eventos";
            this.eventosToolStripMenuItem.Click += new System.EventHandler(this.eventosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesionToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem juegoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem jugarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem espectarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jugadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem v1ToolStripMenuItem;
    }
}

