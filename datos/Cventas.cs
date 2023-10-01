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
using System.Threading.Tasks;

namespace SaborAcielo.datos
{
    internal class Cventas
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString;
        private readonly SqlDataAdapter dataAdapter;
        private readonly DataTable dataTable;

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

