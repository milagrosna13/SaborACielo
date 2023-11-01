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
using System.Net;
using static System.Net.WebRequestMethods;

namespace SaborAcielo.datos
{
    internal class Cproducto
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString;
        private readonly SqlDataAdapter dataAdapter;
        private readonly DataTable dataTable;


        // Método para actualizar la tabla 
        public bool CargarProductos(DataGridView dataGridView)
        {
            try
            {
                // Crear un DataTable local para almacenar los datos
                DataTable localDataTable = new DataTable();

                // Configurar el SqlDataAdapter
                using (SqlDataAdapter localDataAdapter = new SqlDataAdapter("SELECT p.id_produ AS ID, p.nombre_produ AS Producto, " +
                "t.desc_tipoProd AS Tipo, p.detalle AS Detalle, p.precio AS Precio, p.stock, p.fecha AS Fecha, p.imagen, " +               
               "CASE WHEN p.estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado " +
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
        //Metodo para buscar productos (vista: listar)
        public static DataTable ObtenerProductos(string nombre, string tipo, DateTime? fecha)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
            {
                connection.Open();

                string consultaSQL = "SELECT p.id_produ AS ID, p.nombre_produ AS Producto, " +
                    "p.detalle AS Detalle, p.precio AS Precio, p.stock, p.fecha AS Fecha, p.imagen, " +
                    "t.desc_tipoProd AS Tipo, " +
                    "CASE WHEN p.estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado " +
                    "FROM Producto p " +
                    "INNER JOIN Tipo_produ t ON p.id_tipoProdu = t.id_tipoProdu " +
                    "WHERE 1=1";

                if (!string.IsNullOrEmpty(nombre))
                {
                    consultaSQL += " AND p.nombre_produ = @nombre";
                }

                if (!string.IsNullOrEmpty(tipo))
                {
                    consultaSQL += " AND t.desc_tipoProd = @tipo";
                }

                if (fecha != null)
                {
                    consultaSQL += " AND CONVERT(date, p.fecha) = CONVERT(date, @fecha)";
                }

                using (SqlCommand command = new SqlCommand(consultaSQL, connection))
                {
                    if (!string.IsNullOrEmpty(nombre))
                    {
                        command.Parameters.AddWithValue("@nombre", nombre);
                    }

                    if (!string.IsNullOrEmpty(tipo))
                    {
                        command.Parameters.AddWithValue("@tipo", tipo);
                    }

                    if (fecha != null)
                    {
                        command.Parameters.AddWithValue("@fecha", fecha.Value);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        //Productos disponibles para compra: Estado = ACTIVO y STOCK > 0
        public bool ObtenerProductosActivos(string nombre, string tipo, string detalle, DataGridView dg)
        {
            if (!string.IsNullOrEmpty(nombre) || !string.IsNullOrEmpty(tipo) || !string.IsNullOrEmpty(detalle))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
                    {
                        connection.Open();

                        string consultaSQL = "SELECT p.id_produ AS ID, p.nombre_produ AS Producto, t.desc_tipoProd AS Tipo, " +
                            "p.detalle AS Detalle, p.precio AS Precio, p.stock AS Stock " +
                            "FROM Producto p " +
                            "INNER JOIN Tipo_produ t ON p.id_tipoProdu = t.id_tipoProdu " +
                            "WHERE p.estado = 1 AND p.stock > 0 AND 1=1";

                        if (!string.IsNullOrEmpty(nombre))
                        {
                            consultaSQL += " AND p.nombre_produ LIKE @nombre";
                        }

                        if (!string.IsNullOrEmpty(tipo))
                        {
                            consultaSQL += " AND t.desc_tipoProd LIKE @tipo";
                        }
                        if (!string.IsNullOrEmpty(detalle))
                        {
                            consultaSQL += " AND p.detalle LIKE @detalle";
                        }
                        using (SqlCommand command = new SqlCommand(consultaSQL, connection))
                        {
                            if (!string.IsNullOrEmpty(nombre))
                            {
                                command.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                            }

                            if (!string.IsNullOrEmpty(tipo))
                            {
                                command.Parameters.AddWithValue("@tipo", "%" + tipo + "%");
                            }
                            if (!string.IsNullOrEmpty(detalle))
                            {
                                command.Parameters.AddWithValue("@detalle", "%" + detalle + "%");
                            }
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            dg.DataSource = table;
                        }
                        return true;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Se produjo un error: " + ex.Message, "Error", MessageBoxButtons.OK);
                    return false;
                }

            } else
            {
                try
                {
                    DataTable localDataTable = new DataTable();

                    using (SqlDataAdapter localDataAdapter = new SqlDataAdapter("SELECT p.id_produ AS ID, p.nombre_produ AS Producto, " +
                    "t.desc_tipoProd AS Tipo, p.detalle AS Detalle, p.precio AS Precio, p.stock AS Stock " +
                   "FROM Producto p " +
                   "INNER JOIN Tipo_produ t ON p.id_tipoProdu = t.id_tipoProdu " +
                   "WHERE p.estado = 1 AND p.stock > 0", new SqlConnection(connectionString)))
                    {
                        localDataAdapter.Fill(localDataTable);
                    }
                    dg.DataSource = localDataTable;
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public List<DateTime> ObtenerFechasDisponibles()
        {
            List<DateTime> fechasDisponibles = new List<DateTime>();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
            {
                connection.Open();

                string consultaSQL = "SELECT DISTINCT fecha FROM Producto";

                using (SqlCommand command = new SqlCommand(consultaSQL, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            fechasDisponibles.Add(reader.GetDateTime(0));
                        }
                    }
                }
            }

            return fechasDisponibles;
        }
        public List<string> ObtenerNombresUnicos()
        {
            List<string> nombresUnicos = new List<string>();

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                string consultaSQL = "SELECT DISTINCT nombre_produ FROM Producto"; // Consulta para obtener nombres únicos
                using (SqlCommand comando = new SqlCommand(consultaSQL, conexion))
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nombresUnicos.Add(reader["nombre_produ"].ToString());
                    }
                }
            }

            return nombresUnicos;
        }
        public List<string> ObtenerTipos()
        {
            List<string> tiposUnicos = new List<string>();

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                string consultaSQL = "SELECT DISTINCT desc_tipoProd FROM Tipo_produ"; // Consulta para obtener tipos únicos
                using (SqlCommand comando = new SqlCommand(consultaSQL, conexion))
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tiposUnicos.Add(reader["desc_tipoProd"].ToString());
                    }
                }
            }
            return tiposUnicos;
        }

        public List<string> ObtenerDetalles()
        {
            List<string> nombresUnicos = new List<string>();

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                string consultaSQL = "SELECT DISTINCT detalle FROM Producto"; 
                using (SqlCommand comando = new SqlCommand(consultaSQL, conexion))
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nombresUnicos.Add(reader["detalle"].ToString());
                    }
                }
            }

            return nombresUnicos;
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
            dataGridView.CellPainting += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    if (e.ColumnIndex == dataGridView.Columns["Editar"].Index || e.ColumnIndex == dataGridView.Columns["Eliminar"].Index)
                    {
                        // Obtener la imagen y ajustar su tamaño
                        Image image = null;
                        int newWidth = 20; // Ancho deseado
                        int newHeight = 20; // Alto deseado

                        if (e.ColumnIndex == dataGridView.Columns["Editar"].Index)
                        {
                            // Personalizar la imagen para la columna "Editar"
                            image = Properties.Resources.editaricon;
                        }
                        else if (e.ColumnIndex == dataGridView.Columns["Eliminar"].Index)
                        {
                            // Personalizar la imagen para la columna "Eliminar"
                            image = Properties.Resources.eliminaricon;
                        }

                        // Ajustar el tamaño de la imagen
                        Image smallImage = new Bitmap(image, new Size(newWidth, newHeight));

                        // Calcular la posición para centrar la imagen en la celda
                        int x = e.CellBounds.Left + (e.CellBounds.Width - smallImage.Width) / 2;
                        int y = e.CellBounds.Top + (e.CellBounds.Height - smallImage.Height) / 2;

                        // Dibujar la imagen en el centro de la celda
                        e.PaintBackground(e.CellBounds, true);
                        e.Graphics.DrawImage(smallImage, x, y);
                        e.Handled = true;
                    }
                }
            };

        }

        public static void botonAgregar(DataGridView dg)
        {
            DataGridViewButtonColumn columnaAgregar = new DataGridViewButtonColumn();
            columnaAgregar.Name = "Agregar";
            columnaAgregar.Text = "Agregar";
            columnaAgregar.UseColumnTextForButtonValue = true;

            bool columnaAgregada = false;
            foreach (DataGridViewColumn columna in dg.Columns)
            {
                if (columna.Name == "Agregar" && columna.DisplayIndex != dg.ColumnCount - 1)
                {
                    columnaAgregada = true;
                    break;
                }
            }
            
            if (!columnaAgregada)
            {
                dg.Columns.Add(columnaAgregar);
                columnaAgregar.DisplayIndex = dg.ColumnCount - 1;
            }
            
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

        //Método para acceder a los registros del producto seleccionado
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

       //actualizar el stock de productos despues de confirmar una compra
        public bool actualizarStock(DataGridView carrito, DataGridView productos)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
                {
                    connection.Open();
                    string consulta = "UPDATE Producto SET stock = @nuevoStock WHERE id_produ = @idProducto";

                    using (SqlCommand command = new SqlCommand(consulta, connection))
                    {
                        int nuevoStock;
                        int actualStock = 0;
                        foreach (DataGridViewRow fila in carrito.Rows)
                        {
                            command.Parameters.Clear();

                            int id = Convert.ToInt32(fila.Cells["ID"].Value);

                            foreach (DataGridViewRow row in productos.Rows)
                            {
                                if (Convert.ToInt32(row.Cells["ID"].Value) == id)
                                {
                                    actualStock = Convert.ToInt32(row.Cells["Stock"].Value);
                                }
                            }

                            nuevoStock = actualStock - Convert.ToInt32(fila.Cells["Cantidad"].Value);

                            command.Parameters.AddWithValue("@nuevoStock", nuevoStock);
                            command.Parameters.AddWithValue("@idProducto", id);
                            int rowsAffected = command.ExecuteNonQuery();

                           
                        }


                        connection.Close();

                        return true;
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

    }
}

