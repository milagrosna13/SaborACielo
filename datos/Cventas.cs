using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.Common;
using System.Collections;
using System.Threading.Tasks;
using System.Net;

namespace SaborAcielo.datos
{
    internal class Cventas
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString;
        private readonly SqlDataAdapter dataAdapter;
        private readonly DataTable dataTable;

        public static bool cargarVentas(DataGridView dg)
        {
            try
            {
                DataTable localDataTable = new DataTable();

                using (SqlDataAdapter localDataAdapter = new SqlDataAdapter("SELECT vc.id_venta AS ID, vc.dni_empleado AS Empleado, " +
                    "vc.dni_cliente AS Cliente, c.nombre_cliente AS Nombre, vc.fecha_venta AS Fecha, vc.total AS Total, " +
               "CASE WHEN vc.estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado " +
               "FROM Venta_cabecera vc " +
               "INNER JOIN Cliente c ON vc.dni_cliente = c.dni_cliente", new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString)))
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

        public static void botonDetalle(DataGridView dg)
        {
            DataGridViewButtonColumn columnaDetalle = new DataGridViewButtonColumn();
            columnaDetalle.Name = "Detalle";
            columnaDetalle.Text = "Ver detalle";
            columnaDetalle.UseColumnTextForButtonValue = true;
            dg.Columns.Add(columnaDetalle);
        }

        public static bool MostrarResumen(int id, DataGridView dg)
        {
            try
            {
                DataTable localDataTable = new DataTable();

                using (SqlDataAdapter localDataAdapter = new SqlDataAdapter("SELECT vd.id_venta AS ID, p.nombre_produ AS Producto, " +
                    "vd.cantidad AS Cantidad, vd.subtotal AS Subtotal " +                    
                    "FROM Venta_detalle vd " +
                    "INNER JOIN Producto p ON vd.id_produ = p.id_produ " +
                    "WHERE vd.id_venta = @id_venta", 
                    new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString)))
                {
                    localDataAdapter.SelectCommand.Parameters.AddWithValue("@id_venta", id);
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
        public DataSet FiltrarVentaPorCliente(int dni)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Venta_cabecera WHERE dni_cliente LIKE @dni";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.Add("@dni", SqlDbType.NVarChar).Value = "%" + dni + "%";

                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "Venta_cabecera");

                    return dataSet;
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }
        public DataSet FiltrarVentaDniEmpleado(int dni)
        { try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Venta_cabecera WHERE dni_cliente LIKE @dni";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.Add("@dni", SqlDbType.NVarChar).Value = "%" + dni + "%";

                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "Venta_cabecera");

                    return dataSet;
                }
            } 
            catch (Exception ex){
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }

        }
        public int obtenerMaxVenta()
        {
            try
            {
                int ventaActual = -1;
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
                {
                    connection.Open();

                    string consulta = "SELECT MAX(id_venta) FROM Venta_cabecera";
                    using (SqlCommand comando = new SqlCommand(consulta, connection))
                    {
                        object resultado = comando.ExecuteScalar();

                        if (resultado != null && resultado != DBNull.Value)
                        {
                            ventaActual = Convert.ToInt32(resultado);
                        }
                    }
                    connection.Close();
                }
                return ventaActual;
            } catch(Exception ex)
            {
                MessageBox.Show(""+ex.Message);
                return -1;
            }
        }

        public bool agregarCabecera(int dni_c, int nro, int empl, DateTime fecha, decimal total)
        {
            try
            {
                // Resto del código para insertar en la base de datos
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Venta_cabecera (id_venta, dni_empleado, dni_cliente, fecha_venta, total ) VALUES (@nro, @empleado, @cliente, @fecha, @total)";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Usa parámetros para evitar la inyección de SQL
                    command.Parameters.AddWithValue("@nro", nro);
                    command.Parameters.AddWithValue("@empleado", empl);
                    command.Parameters.AddWithValue("@cliente", dni_c);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@total", total);

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

        

        public bool agregarDetalle(int venta, DataGridView dg)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
                {
                    connection.Open();
                    string consultaInsertar = "INSERT INTO Venta_detalle (id_venta, id_produ, cantidad, subtotal) VALUES (@idventa, @idprodu, @cantidad, @total)";

                    foreach (DataGridViewRow fila in dg.Rows)
                    {
                        int idProdu = Convert.ToInt32(fila.Cells["ID"].Value);
                        int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                        decimal total = Convert.ToDecimal(fila.Cells["Subtotal"].Value);

                        if (idProdu > 0)
                        {
                            using (SqlCommand comando = new SqlCommand(consultaInsertar, connection))
                            {
                                comando.Parameters.AddWithValue("@idventa", venta);
                                comando.Parameters.AddWithValue("@idprodu", idProdu);
                                comando.Parameters.AddWithValue("@cantidad", cantidad);
                                comando.Parameters.AddWithValue("@total", total);

                                comando.ExecuteNonQuery();
                            }
                        }
                    }

                }
                return true;
            } catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public void buscarFecha(DateTime desde, DateTime hasta, DataGridView dataGridView)
        {
            try
            {
                string consultaSQL = "SELECT * FROM Venta_cabecera " +
                    "WHERE fecha_venta BETWEEN @desde AND @hasta ";
                using (SqlConnection conexion = new SqlConnection("tu_cadena_de_conexion"))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL, conexion))
                    {
                        comando.Parameters.AddWithValue("@desde", desde);
                        comando.Parameters.AddWithValue("@hasta", hasta);

                        DataTable dt = new DataTable();
                        dt.Load(comando.ExecuteReader());

                        dataGridView.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
               
            }
        }

    }
}

    
    
