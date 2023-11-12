using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

using Microsoft.SqlServer.Management.Smo;

namespace SaborAcielo.datos
{
    internal class DB_General
    {
        protected SqlConnection conn;
        protected SqlCommand CMD;

        public DB_General()
        {
            // Retrieve the connection string from app.config
            string connectionString = ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString;

            // Create a new SqlConnection
            conn = new SqlConnection(connectionString);

            // Initialize SqlCommand
            CMD = new SqlCommand();
            CMD.Connection = conn;
        }

        // Open the database connection
        protected void Open_Connection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        // Close the database connection
        protected void Close_Connection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        // Insert, Update And Delete...
        public void GeneralQuery(string query)
        {
            Open_Connection();
            CMD.CommandText = query;
            CMD.ExecuteNonQuery();
            Close_Connection();
        }

        public DataTable MyTable(string query)
        {
            Open_Connection();
            CMD.CommandText = query;
            SqlDataAdapter myAdapter = new SqlDataAdapter(CMD);
            DataTable mytbl = new DataTable();
            myAdapter.Fill(mytbl);
            Close_Connection();
            return mytbl;
        }
    }
}
