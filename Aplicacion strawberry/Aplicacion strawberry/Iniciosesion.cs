using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Aplicacion_strawberry
{
    public partial class Iniciosesion : Form
    {
        public Iniciosesion()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source=.\\SQLExpress2008;AttachDbFilename=C:\\Users\\Maxcel Center\\Documents\\Visual Studio 2010\\Projects\\Aplicacion strawberry\\Aplicacion strawberry\\DBapp.mdf;Integrated Security=True;User Instance=True");
            SqlCommand cmd = new SqlCommand("ScalarQuery", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usuario",SqlDbType.VarChar).Value = Usuario.Text;
            cmd.Parameters.Add("@contra",SqlDbType.VarChar).Value = Contra.Text;
            int resultado = -1;
            conexion.Open();
            resultado = (int)cmd.ExecuteScalar();
            if (resultado != -1)
            {
                DatosUsuario hijo2 = new DatosUsuario();
                hijo2.MdiParent = this.MdiParent;
                hijo2.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No se encontro");
            }
            conexion.Close();
        }
    }
}
