using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpdateBD
{
    public partial class Form1 : Form
    {
        private SqlConnection conexion = new SqlConnection("server=KEVIN-PC ; database=base1 ; integrated security = true");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cod = textBox1.Text;
            string cadena = "select descripcion, precio from articulos where codigo=@codigo";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.Add("@codigo", SqlDbType.Int);
            comando.Parameters["@codigo"].Value = int.Parse(textBox1.Text);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                textBox2.Text = registro["descripcion"].ToString();
                textBox3.Text = registro["precio"].ToString();
                button2.Enabled = true;
            }
            else
                MessageBox.Show("No existe un artículo con el código ingresado");
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cadena = "update articulos set descripcion=@descripcion, precio=@precio where codigo=@codigo";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.Add("@codigo", SqlDbType.Int);
            comando.Parameters["@codigo"].Value = int.Parse(textBox1.Text);
            comando.Parameters.Add("@descripcion", SqlDbType.VarChar);
            comando.Parameters["@descripcion"].Value = textBox2.Text;
            comando.Parameters.Add("@precio", SqlDbType.Float);
            comando.Parameters["@precio"].Value = float.Parse(textBox3.Text);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se modificaron los datos del artículo");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else
                MessageBox.Show("No existe un artículo con el código ingresado");
            conexion.Close();
            button2.Enabled = false;
        }
    }
}
