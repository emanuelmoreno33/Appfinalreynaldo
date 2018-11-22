using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplicacion_strawberry
{
    public partial class formaencuentro : Form
    {
        int idusuario = 0;
        float elousuario = 0;
        int juegoelegido = 0;
        int monedasusuario = 0;
        int cuota = 0;
        SqlConnection conexion = new SqlConnection("Data Source=.\\SQLExpress2008;AttachDbFilename=C:\\Users\\Maxcel Center\\Documents\\Visual Studio 2010\\Projects\\Aplicacion strawberry\\Aplicacion strawberry\\DBapp.mdf;Integrated Security=True;User Instance=True");

        public formaencuentro()
        {
            InitializeComponent();
        }

        public formaencuentro(int idusuario):this()
        {
            this.idusuario = idusuario;
            
        }

        private void formaencuentro_Load(object sender, EventArgs e)
        {

        }

        private void ant1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            juegoelegido = 1;
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            juegoelegido = 2;
            panel2.Visible = true;
            panel1.Visible = false;            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            juegoelegido = 3;
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            juegoelegido = 4; 
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private Boolean ver_juegos(int juego)
        {
            string cadena = "Select Elo_Minimo from Ranking_Categorias where Id_Juego =" + juego;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                float elo = Convert.ToSingle(registro["Elo_Minimo"].ToString());
                if (elo <= elousuario)
                {
                    conexion.Close();
                    return true;
                }
                else
                {
                    conexion.Close();
                    return false;
                }

            }
            else
            {
                conexion.Close();
                return false;
            }
            
        }

        private void datos(int juego)
        {
            string cadena = "Select elo from Ranking_Usuario where (Id_Usuario =" + idusuario.ToString()+")AND (Id_Juego ="+juego.ToString()+")";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                float elo = Convert.ToSingle(registro["elo"].ToString());
                elousuario = elo;
            }
            else
            {
                MessageBox.Show("No se encontro registro");
            }
            conexion.Close();
        }

        private void monedas(int usuario)
        {
            string cadena = "Select creditos from Usuario where Id_Usuario =" + idusuario.ToString();
            SqlCommand comando = new SqlCommand(cadena, conexion);
            conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                int mon = Convert.ToInt32(registro["creditos"].ToString());
                monedasusuario = mon;
            }
            else
            {
                MessageBox.Show("No se encontro registro");
            }
            conexion.Close();
        }

        private string juegos(int j)
        {
            string cadena = "Select Descripcion from Juego where Id_Juego =" + j.ToString();
            SqlCommand comando = new SqlCommand(cadena, conexion);
            conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            string jue = "";
            if (registro.Read())
            {
                jue = registro["Descripcion"].ToString();
                conexion.Close();
                return jue;
                
            }
            else
            {                
                jue = "No encontrado";
                conexion.Close();
                return jue;
            }
            
        }

        private void cargarahorros()
        {
            string cadena = "Select descripcion from Ahorro";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                cbahorro.Items.Add(registro["descripcion"].ToString());
            }
            conexion.Close();
            
        }

        private void panel2_VisibleChanged(object sender, EventArgs e)
        {
            if (panel2.Visible == true)
            {
                datos(juegoelegido);
                monedas(idusuario);
                string infojuego =  juegos(juegoelegido);
                lblelo.Text = "ELO: " + elousuario.ToString();
                lblusuario.Text = "Usuario: "+idusuario.ToString();
                lblmonedas.Text = monedasusuario.ToString();
                lbljuego.Text = infojuego;

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbmoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            cuota = Convert.ToInt32(cbmoneda.SelectedItem);
            if (cuota > monedasusuario)
            {
                MessageBox.Show("Elegir cantidad valida");
                desp1.Enabled = false;
            }
            else
            {
                int nuevo = monedasusuario - cuota;
                lblcantidadnueva.Text = nuevo.ToString();
                desp1.Enabled = true;
            }

        }

        private void cbahorro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void desp1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.Visible = false;
            cargarahorros();
        }

        private void juego()
        {
            Random rn = new Random();
            int resultado1 = rn.Next(1,10);
            int resultado2 = rn.Next(1, 10);
            float porcentaje = 0;
            if (resultado1 > resultado2)
            {
                lblresultado.Text = "Ganaste";
                lbljuegores.Text = juegos(juegoelegido);
                lblnumerores.Text = "Numero #1";
                lblelo.Text = "Elo: " + elousuario.ToString();
                porcentaje = trackBar1.Value / 100;
                int monedanueva = Convert.ToInt32(monedasusuario + (cuota * (1 + (porcentaje))));
                lblmonedasres.Text = "Tienes ahora: " + monedanueva.ToString();
                int aportacion = Convert.ToInt32(cuota * (1 - porcentaje));
                lblahorrores.Text = "Aportaste: " + aportacion.ToString();

                string cadena = "Insert into Aportacion(Id_Usuario,Id_Ahorro,cantidad,porcentaje) values ("+juegoelegido.ToString()+","+idusuario.ToString()+","+aportacion.ToString()+","+Convert.ToString(porcentaje)+")";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            else
            {
                lblresultado.Text = "Perdiste";
                lbljuegores.Text = juegos(juegoelegido);
                lblnumerores.Text = "Numero #1";
                lblelo.Text = "Elo: " + elousuario.ToString();
                int monedanueva = Convert.ToInt32(monedasusuario - cuota);
                lblmonedasres.Text = "Tienes ahora: " + monedanueva.ToString();
                lblahorrores.Text = "No ganaste, por lo que tu aportación no se realizo";
            }

            string cadenas = "Insert into Encuentro(Id_Juego,Id_Tipo_Encuentro,Id_Aportacion_Usuario1,Id_Aportacion_Usuario2,fecha_hora) values (" + juegoelegido.ToString() + ",1,1,5,GETDATE())";
            SqlCommand comando1 = new SqlCommand(cadenas, conexion);
            conexion.Open();
            comando1.ExecuteNonQuery();
            conexion.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            juego();
            panel3.Visible = false;
            panel4.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
