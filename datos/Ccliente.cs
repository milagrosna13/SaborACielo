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

        public static bool AgregarCliente(string nombrec, string apellidoc, string direcc, string telc, string emailc, string estado, DateTime fecha)
        {
            try
            {
                // Resto del código para insertar en la base de datos
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Producto (nombre_cliente, apellido_cliente, dire_cliente, tel_cliente, email_cliente, estado, f_registro_cli) VALUES (@nombre, @apellido, @direcc, @tel, @email, @estado, @fecha,@imagen)";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Usa parámetros para evitar la inyección de SQL
                    command.Parameters.AddWithValue("@nombre",nombrec);
                    command.Parameters.AddWithValue("@apellido",apellidoc);
                    command.Parameters.AddWithValue("@dire", direcc);
                    command.Parameters.AddWithValue("@tel", telc);
                    command.Parameters.AddWithValue("@email", emailc);
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
    }
}
