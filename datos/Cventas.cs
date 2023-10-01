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

namespace SaborAcielo.datos
{
    internal class Cventas
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString;
        private readonly SqlDataAdapter dataAdapter;
        private readonly DataTable dataTable;

        public void MostrarResumen(int id)
        {
            string query = "SELECT * FROM venta WHERE ID = @id_venta"; // Reemplaza TuTabla y ID con los nombres reales

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_venta", id);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string detalles = $"ID: {reader["ID"]}\n";
                            detalles += $"Producto: {reader["producto"]}\n";
                            detalles += $"Precio: {reader["precio"]}\n"; 
                            detalles += $"Cantidad: {reader["cantidad"]}\n"; 
                            detalles += $"Total: {reader["total"]}\n"; 

                            MessageBox.Show(detalles, "Detalles de la compra");
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron detalles para el ID proporcionado", "Error");
                        }
                    }
                }
            }
        }


        public bool Filtrar(string filtro, out DataTable resultado)
        {
            resultado = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(filtro, conexion);                    
                    adapter.Fill(dataTable);

                }
                return true;
            }
            catch
            {
                resultado = null;  
                return false;
            }
        }
        public DataTable FiltrarPorTexto(string texto)
        {
            string consulta = $"SELECT * FROM Producto WHERE nombre_produ LIKE '%{texto}%'";
            DataTable resultado;
            Filtrar(consulta, out resultado);
            return resultado;
        }
    }
}

