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

namespace SaborAcielo.datos
{
    internal class Cempleado
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString;
        private readonly SqlDataAdapter dataAdapter;
        private readonly DataTable dataTable;
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        
        public DateTime Fecha_ingreso { get; set; }

        public byte[] Imagen { get; set; }
        public bool Estado { get; set; }
        // Método para actualizar la tabla 
        public bool CargarEmpleados(DataGridView dataGridView)
        {
            try
            {
                // Crear un DataTable local para almacenar los datos
                DataTable localDataTable = new DataTable();

                // Configurar el SqlDataAdapter
                using (SqlDataAdapter localDataAdapter = new SqlDataAdapter("SELECT e.dni_empleado AS ID, e.nombre AS Nombre," +
                    "e.apellido AS Apellido, e.mail AS Email, e.telefono As Teléfono, e.direccion as Dirección, e.fecha_ingreso AS 'Fecha de ingreso', e.foto_emp as Foto ,CAST(e.estado AS INT) AS Estado,Tipo_usuario.desc_tipoUs as 'Tipo de Usuario' " +
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
                // Resto del código para insertar en la base de datos
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

        private byte[] ConvertirImagenABytes(string rutaImagen)
        {
            byte[] imagenBytes = null;

            try
            {
                using (FileStream fs = new FileStream(rutaImagen, FileMode.Open, FileAccess.Read))
                {
                    imagenBytes = new byte[fs.Length];
                    fs.Read(imagenBytes, 0, Convert.ToInt32(fs.Length));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al convertir la imagen a bytes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return imagenBytes;
        }

    }
}
