using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.Common;
using System.Collections;
using System.IO;
using System.Drawing;

namespace SaborAcielo.datos
{
    internal class Cproducto
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString;
        private readonly SqlDataAdapter dataAdapter;
        private readonly DataTable dataTable;
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Tipo { get; set; }
        public string Detalle { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public bool Estado { get; set; }
        public DateTime Fecha { get; set; }
        public byte[] Imagen { get; set; }
        // Método para actualizar la tabla 
        public bool CargarProductos(DataGridView dataGridView)
        {
            try
            {
                // Crear un DataTable local para almacenar los datos
                DataTable localDataTable = new DataTable();

                // Configurar el SqlDataAdapter
                using (SqlDataAdapter localDataAdapter = new SqlDataAdapter("SELECT p.id_produ AS ID, p.nombre_produ AS Producto," +
                    "p.detalle AS Detalle, p.precio AS Precio, p.stock, p.fecha AS Fecha, p.imagen, t.desc_tipoProd AS Tipo, CAST(p.estado AS INT) AS Estado " +
                    "FROM Producto p " +
                    "INNER JOIN Tipo_produ t ON p.id_tipoProdu = t.id_tipoProdu", new SqlConnection(connectionString)))
                {
                    // Llenar el DataTable con los datos
                    localDataAdapter.Fill(localDataTable);
                }

                // Asignar el DataTable como origen de datos del DataGridView
                dataGridView.DataSource = localDataTable;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        // Método para agregar un producto
        public static bool AgregarProducto(string nombre, int tipo, decimal precio, string detalle, string stock, DateTime fecha, byte[] imagen, DataGridView datagrid)
        {
           
        // Establece el valor de estado en 1 (alta) por defecto
        bool estado = true;
            try
            {
                // Resto del código para insertar en la base de datos
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Producto (nombre_produ, id_tipoProdu, detalle, precio, stock, estado, fecha,imagen) VALUES (@nombre, @tipo, @detalle, @precio, @stock, @estado, @fecha,@imagen)";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Usa parámetros para evitar la inyección de SQL
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@tipo", tipo);
                    command.Parameters.AddWithValue("@detalle", detalle);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@stock", stock);
                    command.Parameters.AddWithValue("@estado", estado);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@imagen", imagen);


                    command.ExecuteNonQuery();

                    connection.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error: " + ex.Message);
                MessageBox.Show("Error en la inserción de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public static void AgregarColumnasBoton(DataGridView dataGridView)
        {
            // Agregar las columnas "Editar" y "Eliminar" al final
            DataGridViewButtonColumn columnaEditar = new DataGridViewButtonColumn();
            columnaEditar.Name = "Editar";
            columnaEditar.Text = "Editar";
            columnaEditar.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(columnaEditar);

            DataGridViewButtonColumn columnaEliminar = new DataGridViewButtonColumn();
            columnaEliminar.Name = "Eliminar";
            columnaEliminar.Text = "Eliminar";
            columnaEliminar.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(columnaEliminar);
        }

        //Método para actualizar producto
        public static bool ActualizarProducto(int idProducto, string nuevoNombre, string nuevoDetalle, decimal nuevoPrecio, int nuevoStock,  DateTime nuevaFecha, byte[] nuevaImagen)
        {
            bool estado = true;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
                {
                    connection.Open();

                    string query = "UPDATE Producto SET nombre_produ = @nuevoNombre, detalle = @nuevoDetalle, precio = @nuevoPrecio, stock = @nuevoStock, estado = @estado, fecha = @nuevaFecha, imagen = @nuevaImagen WHERE id_produ = @idProducto";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@nuevoNombre", nuevoNombre);
                    command.Parameters.AddWithValue("@nuevoDetalle", nuevoDetalle);
                    command.Parameters.AddWithValue("@nuevoPrecio", nuevoPrecio);
                    command.Parameters.AddWithValue("@nuevoStock", nuevoStock);
                    command.Parameters.AddWithValue("@estado", estado);
                    command.Parameters.AddWithValue("@nuevaFecha", nuevaFecha);
                    command.Parameters.AddWithValue("@nuevaImagen", nuevaImagen);
                    command.Parameters.AddWithValue("@idProducto", idProducto);

                    int rowsAffected = command.ExecuteNonQuery();

                    connection.Close();

                    return rowsAffected > 0; // Verificar si se actualizaron filas
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error: " + ex.Message);
                MessageBox.Show("Error en la actualización de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Método para acceder a los registros del producto a editar
        public DataRow obtenerProducto(int idProducto)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Producto WHERE id_produ = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", idProducto);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0];
            }
            else
            {
                return null;
            }
            
        }
        public byte[] ObtenerImagenDesdeBaseDeDatos(int id)
        {
            byte[] imagenBytes = null;

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                string consulta = "SELECT imagen FROM Producto WHERE id_produ = @id";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            imagenBytes = (byte[])reader["imagen"];
                        }
                    }
                }
            }

            return imagenBytes;
        }

        public void MostrarImagenEnPictureBox(int id, PictureBox pictureBox)
        {
            byte[] imagenBytes = ObtenerImagenDesdeBaseDeDatos(id);

            if (imagenBytes != null && imagenBytes.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imagenBytes))
                {
                    Image imagen = Image.FromStream(ms);
                    pictureBox.Image = imagen;
                }
            }
            else
            {                
                pictureBox.Image = null; 
            }
        }


        //Método para eliminar lógicamente a un producto
        public static bool EliminarProducto(int idProducto)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
                {
                    connection.Open();

                    string query = "UPDATE Producto SET estado = 0 WHERE id_produ = @idProducto";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@idProducto", idProducto);

                    command.ExecuteNonQuery();

                    connection.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error: " + ex.Message);
                return false;
            }
        }

       

    }
}

