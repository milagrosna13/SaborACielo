using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaborAcielo.datos
{
    internal class Cusuarios
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString;
        private readonly SqlDataAdapter dataAdapter;
        private readonly DataTable dataTable;

        public static int AutenticarUsuario(string nombreUsuario, string contrasenia)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
            {
                connection.Open();

                // Realiza la consulta SQL para buscar el usuario en la base de datos
                string consulta = "SELECT U.contrasenia, U.salt, U.id_tipoUsuario, E.estado " +
                          "FROM Usuario U " +
                          "INNER JOIN Empleado E ON U.dni_empleado = E.dni_empleado " +
                          "WHERE U.nom_usuario = @nombreUsuario";
                using (SqlCommand command = new SqlCommand(consulta, connection))
                {
                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            byte[] hashAlmacenado = (byte[])reader["contrasenia"];
                            byte[] salt = (byte[])reader["salt"];
                            byte[] contraseniaBytes = Encoding.UTF8.GetBytes(contrasenia);

                            if (ByteArrayEquals(hashAlmacenado, AplicarHashAContraseña(contraseniaBytes, salt)))
                            {
                                bool estado = (bool)reader["estado"];
                                if (estado)
                                {
                                    // Las credenciales son válidas y el empleado no está desactivado (estado = 1)
                                    return (int)reader["id_tipoUsuario"];
                                }
                            }
                        }
                    }
                }
            }

            // Si no se encuentra el usuario o las credenciales son incorrectas, devuelve un valor negativo
            return -1;
        }

        private static bool ByteArrayEquals(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
                return false;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    return false;
            }

            return true;
        }

        private static byte[] AplicarHashAContraseña(byte[] contraseñaBytes, byte[] salt)
        {
            using (var deriveBytes = new Rfc2898DeriveBytes(contraseñaBytes, salt, 10000, HashAlgorithmName.SHA256))
            {
                return deriveBytes.GetBytes(32); // El hash tiene un tamaño de 32 bytes
            }
        }

        
        public static string ObtenerUser()
        {
            return UserLogin.NombreUsuario;
        }
        
        public int ObtenerDniUsuario(string user)
        {
            int dni = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
                {
                    connection.Open();

                    string consulta = "SELECT dni_empleado FROM Usuario WHERE nom_usuario = @user";
                    using (SqlCommand comando = new SqlCommand(consulta, connection))
                    {
                        comando.Parameters.AddWithValue("@user", user);
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                dni = Convert.ToInt32( reader["dni_empleado"]);
                            }
                        }
                    }
                }
                return dni;
            } catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
                return dni;
            }
            
        }

        public bool CargarUsuarios(DataGridView dataGridView)
        {
            try
            {
                // Crear un DataTable local para almacenar los datos de usuarios
                DataTable localDataTable = new DataTable();

                // Configurar el SqlDataAdapter con la consulta SQL para usuarios
                string query = "SELECT U.nom_usuario AS Nombre, TU.desc_tipoUs AS Tipo, U.dni_empleado AS DNI,  " +
                       "CASE WHEN E.estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado " +
                       "FROM Usuario U " +
                       "INNER JOIN Empleado E ON U.dni_empleado = E.dni_empleado " +
                       "INNER JOIN Tipo_usuario TU ON U.id_tipoUsuario = TU.id_tipoUsuario";

                using (SqlDataAdapter localDataAdapter = new SqlDataAdapter(query, new SqlConnection(connectionString)))
                {
                    // Llenar el DataTable con los datos de usuarios
                    localDataAdapter.Fill(localDataTable);
                }

                // Asignar el DataTable como origen de datos del DataGridView
                dataGridView.DataSource = localDataTable;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos de usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public AutoCompleteStringCollection ObtenerSugerenciasNombre()
        {
            AutoCompleteStringCollection sugerencias = new AutoCompleteStringCollection();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT nom_usuario FROM Usuario";
                SqlCommand cmd = new SqlCommand(query, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sugerencias.Add(reader["nom_usuario"].ToString());
                    }
                }
            }

            return sugerencias;
        }
        public static DataTable ObtenerUsuarios(string nombre, string tipo, int dni, bool mostrarActivos, bool mostrarInactivos)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
            {
                connection.Open();

                string consultaSQL = "SELECT U.nom_usuario AS Nombre, TU.desc_tipoUs AS Tipo, U.dni_empleado AS DNI, " +
                    "CASE WHEN E.estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado " +
                    "FROM Usuario U " +
                    "INNER JOIN Empleado E ON U.dni_empleado = E.dni_empleado " +
                    "INNER JOIN Tipo_usuario TU ON U.id_tipoUsuario = TU.id_tipoUsuario" +
                    " WHERE 1 = 1"; // Inicialización para simplificar la concatenación de condiciones en el WHERE

                if (!string.IsNullOrEmpty(nombre))
                {
                    consultaSQL += " AND U.nom_usuario LIKE @nombre";
                }

                if (!string.IsNullOrEmpty(tipo))
                {
                    consultaSQL += " AND TU.desc_tipoUs LIKE @tipo";
                }

                if (dni != 0)
                {
                    consultaSQL += " AND E.dni_empleado = @dni";
                }

                if (mostrarActivos && !mostrarInactivos)
                {
                    consultaSQL += " AND E.estado = 1"; // Mostrar solo usuarios activos
                }
                else if (!mostrarActivos && mostrarInactivos)
                {
                    consultaSQL += " AND E.estado = 0"; // Mostrar solo usuarios inactivos
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

                    if (dni != 0)
                    {
                        command.Parameters.AddWithValue("@dni", dni);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }



    }
}