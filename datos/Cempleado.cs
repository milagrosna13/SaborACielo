using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Security.Cryptography;

namespace SaborAcielo.datos
{
   
    internal class Cempleado
    {
        
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString;
        private readonly SqlDataAdapter dataAdapter;
        private readonly DataTable dataTable;
       
        // Método para actualizar la tabla 
        public bool CargarEmpleados(DataGridView dataGridView)
        {
            try
            {
                // Crear un DataTable local para almacenar los datos
                DataTable localDataTable = new DataTable();

                // Configurar el SqlDataAdapter con la consulta SQL modificada
                using (SqlDataAdapter localDataAdapter = new SqlDataAdapter("SELECT e.dni_empleado AS DNI, e.nombre AS Nombre," +
                    "e.apellido AS Apellido, e.mail AS Email, e.telefono As Teléfono, e.direccion as Dirección, e.fecha_ingreso AS 'Fecha de ingreso', e.foto_emp as Foto, " +
                    "CASE WHEN e.estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado, " +
                    "COALESCE(Tipo_usuario.desc_tipoUs, 'Usuario no asignado') as 'Tipo de Usuario' " +
                    "FROM Empleado e " + "LEFT JOIN Usuario ON e.dni_empleado = Usuario.dni_empleado " +
                    "LEFT JOIN Tipo_usuario ON Usuario.id_tipoUsuario = Tipo_usuario.id_tipoUsuario", new SqlConnection(connectionString)))
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

        public static bool AgregarEmpleado(int dni,string nombre, string apellido, string mail, int telefono, string direccion, DateTime fecha_ingreso, byte[] imagen, DataGridView datagrid)
        {

            // Establece el valor de estado en 1 (alta) por defecto
            bool estado = true;
            try
            {
                // Verifica si el DNI ya existe en la base de datos
                if (DNIExistente(dni))
                {
                    MessageBox.Show("El DNI ya existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                // código para insertar en la base de datos
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Empleado (dni_empleado,nombre,apellido,mail, telefono,direccion, fecha_ingreso,foto_emp,estado) VALUES (@dni_empleado,@nombre, @apellido, @mail, @telefono, @direccion, @fecha_ingreso,@imagen,@estado)";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Usa parámetros para evitar la inyección de SQL
                    command.Parameters.AddWithValue("@dni_empleado", dni);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@mail", mail);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@fecha_ingreso", estado);
                    command.Parameters.AddWithValue("@imagen", imagen);
                    command.Parameters.AddWithValue("@estado", estado);


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

        public static bool DNIExistente(int dni)
        {
            // Realiza una consulta para verificar si el DNI ya existe en la base de datos
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Empleado WHERE dni_empleado = @dni_empleado";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@dni_empleado", dni);

                int count = (int)command.ExecuteScalar();

                connection.Close();

                return count > 0;
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



        public static bool CrearUsuario(int dniEmpleado, string nombreUsuario, string contrasenia, int idTipoUsuario)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contrasenia))
                {
                    // Manejar el caso en el que el nombre de usuario o la contraseña están vacíos
                    MessageBox.Show("Tanto el nombre de usuario como la contraseña son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Verifica si el nombre de usuario ya existe
                if (NombreUsuarioExistente(nombreUsuario))
                {
                    MessageBox.Show("El nombre de usuario ya existe. Por favor, elija otro nombre de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                // Genera un salt aleatorio
                byte[] salt = GenerarSaltAleatorio(16); // Tamaño del salt en bytes

                // Aplica una función hash a la contraseña y el salt
                byte[] hash = AplicarHashAContraseña(contrasenia, salt);

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Usuario (dni_empleado, nom_usuario, contrasenia, salt, id_tipoUsuario) " +
                                   "VALUES (@dni_empleado, @nom_usuario, @contrasenia, @salt, @id_tipoUsuario)";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Usa parámetros para evitar la inyección de SQL
                    command.Parameters.AddWithValue("@dni_empleado", dniEmpleado);
                    command.Parameters.AddWithValue("@nom_usuario", nombreUsuario);
                    command.Parameters.AddWithValue("@contrasenia", hash); // Inserta el hash en lugar de la contraseña
                    command.Parameters.AddWithValue("@salt", salt); // Inserta el salt
                    command.Parameters.AddWithValue("@id_tipoUsuario", idTipoUsuario);

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
        private static bool NombreUsuarioExistente(string nombreUsuario)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Usuario WHERE nom_usuario = @nombreUsuario";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        // Genera un salt aleatorio


        // Genera un salt aleatorio
        private static byte[] GenerarSaltAleatorio(int saltSize)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[saltSize];
                rng.GetBytes(salt);
                return salt;
            }
        }

        // Aplica una función hash a la contraseña y el salt
        private static byte[] AplicarHashAContraseña(string contraseña, byte[] salt)
        {
            using (var deriveBytes = new Rfc2898DeriveBytes(contraseña, salt, 10000, HashAlgorithmName.SHA256))
            {
                return deriveBytes.GetBytes(32); // El hash tiene un tamaño de 32 bytes
            }
        }

        public bool CargarUsuarios(DataGridView dataGridView)
        {
            try
            {
                // Crear un DataTable local para almacenar los datos de usuarios
                DataTable localDataTable = new DataTable();

                // Configurar el SqlDataAdapter con la consulta SQL para usuarios
                using (SqlDataAdapter localDataAdapter = new SqlDataAdapter("SELECT dni_empleado, nom_usuario, id_tipoUsuario FROM Usuario", new SqlConnection(connectionString)))
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

    }
}
