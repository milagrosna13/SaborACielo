using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Dictionary<string, int> ObtenerProductosMasComunes()
        {
            Dictionary<string, int> productosMasComunes = new Dictionary<string, int>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Crea una consulta SQL para obtener los productos más comunes en función de la cantidad en stock.
                string query = "SELECT p.nombre_produ, SUM(p.stock) AS TotalStock " +
                               "FROM Producto p " +
                               "GROUP BY p.nombre_produ " +
                               "ORDER BY TotalStock DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nombreProducto = reader["nombre_produ"].ToString();
                            int totalStock = (int)reader["TotalStock"];

                            // Agregar los productos más comunes al diccionario.
                            productosMasComunes.Add(nombreProducto, totalStock);
                        }
                    }
                }
            }

            return productosMasComunes;
        }

    }
}
