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
            DataRow detalle = null;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Producto WHERE id_produ = @idProdu";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@idProdu", idProducto);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            if (dt.Rows.Count > 0)
                            {
                                detalle = dt.Rows[0];
                            }
                            
                        }
                    }
                }
                return detalle;
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

