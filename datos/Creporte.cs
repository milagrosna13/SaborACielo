﻿using iText.StyledXmlParser.Jsoup.Select;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaborAcielo.datos
{
    internal class Creporte
    {
        private string connectionString;
        public Creporte()
        {
            // Obtiene la cadena de conexión desde el archivo de configuración.
            connectionString = ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString;
        }
        //--------------------------------Reporte ventas--------------------------------------------------------------------

        public DataTable ObtenerTotalesPorFecha(DateTime? fechaInicio = null, DateTime? fechaFin = null)
        {
            DataTable totalesPorFecha = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT CAST(fecha_venta AS date) AS fecha, " +
                               "SUM(total) AS TotalVentas " +
                               "FROM Venta_cabecera ";

                // Si se proporcionan fechas, se agrega la cláusula WHERE para filtrar por rango de fechas
                if (fechaInicio != null && fechaFin != null)
                {
                    query += "WHERE CAST(fecha_venta AS date) BETWEEN @FechaInicio AND @FechaFin ";
                }

                query += "GROUP BY CAST(fecha_venta AS date) " +
                         "ORDER BY CAST(fecha_venta AS date)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Si se proporcionan fechas, se agregan como parámetros
                    if (fechaInicio != null && fechaFin != null)
                    {
                        command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@FechaFin", fechaFin);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(totalesPorFecha);
                }
            }

            return totalesPorFecha;
        }

        //para las tarjetitas de arriba
        public int ObtenerTotalGanancia()
        {
            int totalGanancia = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT SUM(total) AS TotalVentas FROM Venta_cabecera WHERE estado = 1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        totalGanancia = Convert.ToInt32(result);
                    }
                }
            }

            return totalGanancia;
        }
        public int ObtenerTotalVentas()
        {
            int totalVentas = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) AS CantidadVentasEstado1 FROM Venta_cabecera WHERE estado = 1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        totalVentas = Convert.ToInt32(result);
                    }
                }
            }

            return totalVentas;
        }
        public int ObtenerTotalClientes()
        {
            int totalClientes = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) AS CantidadClientes\r\nFROM cliente\r\nWHERE estado_cliente = 'activo'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        totalClientes = Convert.ToInt32(result);
                    }
                }
            }

            return totalClientes;
        }

        //-----------------------------------------------------------------------------------------------------------------------
        //-------------------REPORTE PRODUCTOS--------------------------------------------------------------------------------------------
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
        //Metodo para buscar productos (vista: listar)
        public static DataTable ObtenerProductos(string nombre)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
            {
                connection.Open();

                string consultaSQL = "SELECT p.nombre_produ, SUM(CASE WHEN p.estado = 1 THEN p.stock ELSE 0 END) AS TotalStock FROM Producto p";

                if (!string.IsNullOrEmpty(nombre))
                {
                    consultaSQL += " WHERE p.nombre_produ = @nombre";
                }

                consultaSQL += " GROUP BY p.nombre_produ"; // Mover la cláusula GROUP BY al final

                using (SqlCommand command = new SqlCommand(consultaSQL, connection))
                {
                    if (!string.IsNullOrEmpty(nombre))
                    {
                        command.Parameters.AddWithValue("@nombre", nombre);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        public Dictionary<string, int> ObtenerTotalesPorTipo()
        {
            Dictionary<string, int> totalesPorTipo = new Dictionary<string, int>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Modifica la consulta SQL para considerar el estado.
                string query = "SELECT tp.desc_tipoProd, SUM(CASE WHEN p.estado = 1 THEN p.stock ELSE 0 END) AS TotalStock " +
                               "FROM Producto p " +
                               "INNER JOIN Tipo_produ tp ON p.id_tipoProdu = tp.id_tipoProdu " +
                               "GROUP BY tp.desc_tipoProd";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tipoProducto = reader["desc_tipoProd"].ToString();
                            int totalStock = (int)reader["TotalStock"];

                            // Agregar los totales al diccionario.
                            totalesPorTipo.Add(tipoProducto, totalStock);
                        }
                    }
                }
            }

            return totalesPorTipo;
        }
        //OBTINE TOTAL DE VENTAS POR TIPO
        public DataTable ObtenerVentasTipo(DateTime? fechaInicio = null, DateTime? fechaFin = null)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT tp.desc_tipoProd AS NombreTipoProducto, COUNT(vd.id_venta) AS TotalStock " +
               "FROM Venta_detalle vd " +
               "INNER JOIN Venta_cabecera vc ON vc.id_venta = vd.id_venta " +
               "INNER JOIN Producto p ON p.id_produ = vd.id_produ " +
               "INNER JOIN Tipo_produ tp ON p.id_tipoProdu = tp.id_tipoProdu ";

                if (fechaInicio != null && fechaFin != null)
                {
                    query += "WHERE vc.fecha_venta BETWEEN @FechaInicio AND @FechaFin ";
                }

                query += "GROUP BY tp.desc_tipoProd";



                SqlCommand command = new SqlCommand(query, connection);

                if (fechaInicio != null && fechaFin != null)
                {
                    command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@FechaFin", fechaFin);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public DataTable ObtenerVentasNombre(DateTime? fechaInicio = null, DateTime? fechaFin = null)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT TOP 5 tp.nombre_produ, COUNT(vd.id_venta) AS TotalVentas " +
                               "FROM Venta_detalle vd " +
                               "INNER JOIN Venta_cabecera vc ON vc.id_venta = vd.id_venta " +
                               "INNER JOIN Producto tp ON tp.id_produ = vd.id_produ ";

                if (fechaInicio != null && fechaFin != null)
                {
                    query += "WHERE vc.fecha_venta BETWEEN @FechaInicio AND @FechaFin ";
                }

                query += "GROUP BY tp.nombre_produ ORDER BY TotalVentas DESC";

                SqlCommand command = new SqlCommand(query, connection);

                if (fechaInicio != null && fechaFin != null)
                {
                    command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@FechaFin", fechaFin);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }



        public bool CargarProductos(DataGridView dataGridView)
        {
            try
            {
                // Crear un DataTable local para almacenar los datos
                DataTable localDataTable = new DataTable();

                // Configurar el SqlDataAdapter
                using (SqlDataAdapter localDataAdapter = new SqlDataAdapter("SELECT p.nombre_produ, SUM(CASE WHEN p.estado = 1 THEN p.stock ELSE 0 END) \r\nAS TotalStock FROM Producto p group BY nombre_produ", new SqlConnection(connectionString)))
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


    }
}
