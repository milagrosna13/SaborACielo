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
                using (SqlDataAdapter localDataAdapter = new SqlDataAdapter("SELECT nombre_produ AS Producto," +
                    " detalle AS Detalle, precio AS Precio, stock, fecha AS Fecha, imagen FROM Producto", new SqlConnection(connectionString)))
                {
                    // Llenar el DataTable con los datos
                    localDataAdapter.Fill(localDataTable);
                }

                // Asignar el DataTable como origen de datos del DataGridView
                dataGridView.DataSource = localDataTable;

                // Agregar las columnas de botones
                if (dataGridView.Columns["tipoprodu"] == null)
                {
                    DataGridViewTextBoxColumn tipoprodu = new DataGridViewTextBoxColumn();
                    tipoprodu.HeaderText = "Tipo";
                    tipoprodu.Name = "tipoprodu"; // Asignar un nombre a la columna
                    dataGridView.Columns.Add(tipoprodu);
                }
                if (dataGridView.Columns["estado"] == null)
                {
                    DataGridViewTextBoxColumn estado = new DataGridViewTextBoxColumn();
                    estado.HeaderText = "estado";
                    estado.Name = "estado"; // Asignar un nombre a la columna
                    dataGridView.Columns.Add(estado);
                }

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SELECT p.nombre_produ, t.desc_tipoProd FROM Producto p INNER JOIN Tipo_produ t ON p.id_tipoProdu= t.id_tipoProdu;", connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            int filaActual = 0;
                            while (reader.Read())
                            {
                                dataGridView.Rows[filaActual].Cells["tipoprodu"].Value = reader["desc_tipoProd"].ToString();
                                filaActual++;
                            }
                        }
                        connection.Close();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
        }

        // Método para agregar un producto
        public static bool AgregarProducto(string nombre, int tipo, decimal precio, string detalle, string stock, DateTime fecha, DataGridView datagrid)
        {
            // Establece el valor de estado en 0 (baja) por defecto
            bool estado = false;
            try
            {
                // Resto del código para insertar en la base de datos
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Producto (nombre_produ, id_tipoProdu, detalle, precio, stock, estado, fecha) VALUES (@nombre, @tipo, @detalle, @precio, @stock, @estado, @fecha)";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Usa parámetros para evitar la inyección de SQL
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@tipo", tipo);
                    command.Parameters.AddWithValue("@detalle", detalle);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@stock", stock);
                    command.Parameters.AddWithValue("@estado", estado);
                    command.Parameters.AddWithValue("@fecha", fecha);

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

