using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacion_strawberry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int idusuario = 1;

        private void espectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "espectar")
                {
                    f.Activate();
                    return;
                }
            }
            espectar formHijo = new espectar();
            formHijo.MdiParent = this;
            formHijo.WindowState = FormWindowState.Maximized;
            formHijo.Show();
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "evento")
                {
                    f.Activate();
                    return;
                }
            }
            evento formHijo = new evento();
            formHijo.MdiParent = this;
            formHijo.WindowState = FormWindowState.Maximized;
            formHijo.Show();
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "Iniciosesion")
                {
                    f.Activate();
                    return;
                }
            }
            Iniciosesion formHijo = new Iniciosesion();
            formHijo.MdiParent = this;
            formHijo.WindowState = FormWindowState.Maximized;
            formHijo.Show();
        }

        private void jugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "formaencuentro")
                {
                    f.Activate();
                    return;
                }
            }
            formaencuentro formHijo = new formaencuentro(idusuario);
            formHijo.MdiParent = this;
            formHijo.WindowState = FormWindowState.Maximized;
            formHijo.Show();
        }

        private void v1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "jugar1v1")
                {
                    f.Activate();
                    return;
                }
            }
            jugar1v1 formHijo = new jugar1v1();
            formHijo.MdiParent = this;
            formHijo.WindowState = FormWindowState.Maximized;
            formHijo.Show();
        }
    }
}
