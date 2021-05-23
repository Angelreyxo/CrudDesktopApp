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

namespace CRUD_TAREA5
{
    public partial class Form1 : Form
    {
        public SqlConnection conexion = new SqlConnection("server=DESKTOP-DTI3QKS; database = BDProductosCrud; integrated security = true");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                MessageBox.Show("conectado");
            }
            catch(Exception)
            {
                throw;
            }
        }


        private void btnSelect_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("select * from tablaProductos",conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO tablaProductos (nombreProducto, PrecioProducto) VALUES (@nombreProducto,@PrecioProducto) ";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query,conexion);
            comando.Parameters.AddWithValue("@nombreProducto", txtNombre.Text);
            comando.Parameters.AddWithValue("@PrecioProducto", txtPrecio.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Producto Agregado");
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE tablaProductos SET nombreProducto = @nombreProducto, PrecioProducto = @PrecioProducto WHERE idProducto=@idProducto";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@nombreProducto",txtNombre.Text);
            comando.Parameters.AddWithValue("@PrecioProducto", float.Parse(txtPrecio.Text));
            comando.Parameters.AddWithValue("@idProducto", Convert.ToInt32(txtId.Text));
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se ha actalizado el registro");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM tablaProductos WHERE idProducto=@idProducto";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@idProducto", txtId.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se elimino el producto");

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRV_Click(object sender, EventArgs e)
        {
            Form ventana = new REPORTVIEWER();
            ventana.Show();


        }
    }
}
