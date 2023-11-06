using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.Common;
using System.Collections;
using System.Net;

namespace SaborAcielo.datos
{
    internal class Ccliente
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString;
        private readonly SqlDataAdapter dataAdapter;
        private readonly DataTable dataTable;

        public bool MostrarClientes(DataGridView dataGridView)
        {
            try
            {
                // Crear un DataTable local para almacenar los datos
                DataTable localDataTable = new DataTable();

                // Configurar el SqlDataAdapter
                using (SqlDataAdapter localDataAdapter = new SqlDataAdapter("SELECT * FROM Cliente", new SqlConnection(connectionString)))
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
        public static void AgregarBotonEditar(DataGridView dataGridView)
        {
            // Agregar la columna "Editar" al final
            DataGridViewButtonColumn columnaEditar = new DataGridViewButtonColumn();
            columnaEditar.Name = "editar_cliente";
            columnaEditar.Text = "Editar";
            columnaEditar.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(columnaEditar);

        }
        public static void AgregarBotonesAdm(DataGridView dataGridView)
        {
            // Agregar la columna "Eliminar" al final           
            DataGridViewButtonColumn columnaEliminar = new DataGridViewButtonColumn();
            columnaEliminar.Name = "eliminar_cliente";
            columnaEliminar.Text = "Baja";
            columnaEliminar.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(columnaEliminar);
        }
        public static bool clienteExiste(int dni)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Cliente WHERE dni_cliente = @dni";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@dni", dni);


                    object count = cmd.ExecuteScalar();
                    connection.Close();

                    if (count != null && (int)count > 0)
                    {
                        return true;
                    }
                    else return false;
                }

            }
        }

        public static bool AgregarCliente(int dni, string nombrec, string apellidoc, string direcc, string telc, string emailc, string sexoc, string estado)
        {
            try
            {
                // Resto del código para insertar en la base de datos
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Cliente (dni_cliente, nombre_cliente, apellido_cliente, dire_cliente, tel_cliente, email_cliente, estado_cliente, sexo_cliente, fechaRegistro_cliente) " +
                        "VALUES (@dni, @nombre, @apellido, @dire, @tel, @email, @estado, @sexo, @fecha)";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Usa parámetros para evitar la inyección de SQL
                    command.Parameters.AddWithValue("@dni", dni);
                    command.Parameters.AddWithValue("@nombre", nombrec);
                    command.Parameters.AddWithValue("@apellido", apellidoc);
                    command.Parameters.AddWithValue("@dire", direcc);
                    command.Parameters.AddWithValue("@tel", telc);
                    command.Parameters.AddWithValue("@email", emailc);
                    command.Parameters.AddWithValue("@sexo", sexoc);
                    command.Parameters.AddWithValue("@estado", estado);
                    command.Parameters.AddWithValue("@fecha", DateTime.Now);


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

        
        public static bool EditarCliente(int dni, string nuevoNombre, string nuevoApellido, string nuevaDirec, string nuevoTel, string estado, string nuevoEmail)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
                {
                    connection.Open();

                    string query = "UPDATE Cliente " +
                        "SET dni_cliente = @dni, nombre_cliente = @nuevoNombre, apellido_cliente = @nuevoApellido, dire_cliente = @nuevaDirec, tel_cliente = @nuevoTel, estado_cliente = @estado, email_cliente = @nuevoEmail " +
                        "WHERE dni_cliente = @dni";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@dni", dni);
                    command.Parameters.AddWithValue("@nuevoNombre", nuevoNombre);
                    command.Parameters.AddWithValue("@nuevoApellido", nuevoApellido);
                    command.Parameters.AddWithValue("@nuevaDirec", nuevaDirec);
                    command.Parameters.AddWithValue("@nuevoTel", nuevoTel);
                    command.Parameters.AddWithValue("@estado", estado);
                    command.Parameters.AddWithValue("@nuevoEmail", nuevoEmail);

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
        public static bool EditarEstado(int dni)
        {
            string estadoActual;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
                {
                    connection.Open();

                    string query_select = "SELECT estado_cliente FROM Cliente WHERE dni_cliente = @dni";
                    using (SqlCommand cmd = new SqlCommand(query_select, connection))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);
                        estadoActual = (string)cmd.ExecuteScalar(); // Obtener el estado actual
                    }

                    if (estadoActual == "activo")
                    {
                        string query_update = "UPDATE Cliente SET estado_cliente = 'inactivo' WHERE dni_cliente = @dni";
                        using (SqlCommand cmd = new SqlCommand(query_update, connection))
                        {
                            cmd.Parameters.AddWithValue("@dni", dni);
                            cmd.ExecuteNonQuery(); // Ejecutar la actualización
                        }
                        return true;
                    }
                    else
                    {
                        string query_update = "UPDATE Cliente SET estado_cliente = 'activo' WHERE dni_cliente = @dni";
                        using (SqlCommand cmd = new SqlCommand(query_update, connection))
                        {
                            cmd.Parameters.AddWithValue("@dni", dni);
                            cmd.ExecuteNonQuery(); 
                        }
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }

        }

        public DataTable BuscarClientePorDNI(int dni)
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Cliente WHERE dni_cliente = @dni";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@dni", dni);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }


            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir (por ejemplo, problemas de conexión)
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }

        }

        //filtros 
        public bool FiltrarCliente(int dni, string nombre, string apellido, DateTime? fecha, DataGridView dt)
        {
            if (!string.IsNullOrEmpty(nombre) || !string.IsNullOrEmpty(apellido) || dni > 0)
            {
                try
                {

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string consultaSQL = "SELECT c.* FROM Cliente c " +
                            "WHERE 1 = 1 "; // Inicializa un "true" lógico

                        if (!string.IsNullOrEmpty(nombre))
                        {
                            consultaSQL += " AND c.nombre_cliente LIKE @nombre";
                        }

                        if (!string.IsNullOrEmpty(apellido))
                        {
                            consultaSQL += " AND c.apellido_cliente LIKE @apellido";
                        }

                        if (dni != 0)
                        {
                            consultaSQL += " AND c.dni_cliente LIKE @dni";
                        }

                        if (fecha != null)
                        {
                            consultaSQL += " AND CONVERT(date, c.fechaRegistro_cliente) = CONVERT(date, @fecha)";
                        }

                        using (SqlCommand command = new SqlCommand(consultaSQL, connection))
                        {
                            if (!string.IsNullOrEmpty(nombre))
                            {
                                command.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                            }

                            if (!string.IsNullOrEmpty(apellido))
                            {
                                command.Parameters.AddWithValue("@apellido", "%" + apellido + "%");
                            }

                            if (dni != 0)
                            {
                                command.Parameters.AddWithValue("@dni", "%" + dni + "%");
                            }

                            if (fecha != null)
                            {
                                command.Parameters.AddWithValue("@fecha", fecha.Value);
                            }
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            dt.DataSource = table;

                        }
                        return true;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(" EROR" + ex.Message);
                    return false;
                }
            }else
            {
                try
                {
                    DataTable localDataTable = new DataTable();

                    using (SqlDataAdapter localDataAdapter = new SqlDataAdapter("SELECT c.*" +
                   "FROM Cliente c ", new SqlConnection(connectionString)))
                    {
                        localDataAdapter.Fill(localDataTable);
                    }
                    dt.DataSource = localDataTable;
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}
