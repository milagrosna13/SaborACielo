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
using System.Drawing.Printing;
using System.Drawing;
using SaborAcielo.Empleado;

namespace SaborAcielo.datos
{
    internal class Cventas
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString;
        private readonly SqlDataAdapter dataAdapter;
        private readonly DataTable dataTable;
        private Cusuarios cusuarios = new Cusuarios();


        public bool cargarVentas(DataGridView dg, int tipous)
        {
            try
            {
                DataTable localDataTable = new DataTable();
                if (tipous == 1)
                {
                    string consulta = "SELECT vc.id_venta AS ID, vc.dni_empleado AS Empleado, " +
                   "vc.dni_cliente AS Cliente, c.nombre_cliente AS Nombre, vc.fecha_venta AS Fecha, vc.total AS Total, " +
                   "mp.desc_tipomedio AS MedioDePago, " +
                   "CASE WHEN vc.estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado " +                   
                   "FROM Venta_cabecera vc " +
                   "INNER JOIN Cliente c ON vc.dni_cliente = c.dni_cliente " +
                   "INNER JOIN medio_pago mp ON vc.tipo_pago = mp.tipo_medio";
                    
                    using(SqlDataAdapter localDataAdapter = new SqlDataAdapter(consulta, new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString)))
                    {
                        localDataAdapter.Fill(localDataTable);
                    }
                }
                else if(tipous == 3) 
                {
                    int dniEmpleado = cusuarios.ObtenerDniUsuario(UserLogin.NombreUsuario);

                    string consultaSql = "SELECT vc.id_venta AS ID, " +
                     "vc.dni_cliente AS Cliente, c.nombre_cliente AS Nombre, vc.fecha_venta AS Fecha, vc.total AS Total, " +
                     "mp.desc_tipomedio AS MedioDePago, " +
                     "CASE WHEN vc.estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado " +
                     "FROM Venta_cabecera vc " +
                     "INNER JOIN Cliente c ON vc.dni_cliente = c.dni_cliente " +
                     "INNER JOIN medio_pago mp ON vc.tipo_pago = mp.tipo_medio " +
                     "WHERE vc.dni_empleado = @dniEmpleado";

                    using (SqlDataAdapter localDataAdapter = new SqlDataAdapter(consultaSql, new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString)))
                    {
                        localDataAdapter.SelectCommand.Parameters.AddWithValue("@dniEmpleado", dniEmpleado);

                        localDataAdapter.Fill(localDataTable);
                    }

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

        public DataRow CabeceraVenta(int id)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT vc.id_venta, e.nombre, e.dni_empleado, c.nombre_cliente, c.dni_cliente, vc.fecha_venta, vc.total, mp.desc_tipomedio " +
                    "FROM Venta_cabecera vc " +
                    "INNER JOIN Cliente c ON vc.dni_cliente = c.dni_cliente " +
                    "INNER JOIN Empleado e ON vc.dni_empleado = e.dni_empleado " +
                    "INNER JOIN medio_pago mp ON vc.tipo_pago = mp.tipo_medio " +
                    "WHERE vc.id_venta = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0];
            }
            else
            {
                return null;
            }
        }

        public static void botonDetalle(DataGridView dg)
        {
            DataGridViewButtonColumn columnaDetalle = new DataGridViewButtonColumn();
            columnaDetalle.Name = "Detalle";
            columnaDetalle.Text = "Ver detalle";
            columnaDetalle.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn columnaEliminar = new DataGridViewButtonColumn();
            columnaEliminar.Name = "EditarEstado";
            columnaEliminar.Text = "Baja";
            columnaEliminar.UseColumnTextForButtonValue = true;

            bool columnaAgregada = false;
            foreach (DataGridViewColumn columna in dg.Columns)
            {
                if (columna.Name == "Detalle" && columna.DisplayIndex != dg.ColumnCount - 1)
                {
                    columnaAgregada = true;
                    break;
                }
            }

            if (!columnaAgregada)
            {
                dg.Columns.Add(columnaDetalle);
                dg.Columns.Add(columnaEliminar);
                columnaDetalle.DisplayIndex = dg.ColumnCount - 1;
                columnaEliminar.DisplayIndex = columnaDetalle.Index;
            }
            dg.CellPainting += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    if (e.ColumnIndex == dg.Columns["Detalle"].Index || e.ColumnIndex == dg.Columns["EditarEstado"].Index)
                    {
                        // Obtener la imagen y ajustar su tamaño
                        Image image = null;
                        int newWidth = 20; // Ancho deseado
                        int newHeight = 20; // Alto deseado

                        if (e.ColumnIndex == dg.Columns["EditarEstado"].Index)
                        {
                            // Personalizar la imagen para la columna "Editar"
                            image = Properties.Resources.editaricon;
                        }
                        else if (e.ColumnIndex == dg.Columns["Detalle"].Index)
                        {
                            // Personalizar la imagen para la columna "Eliminar"
                            image = Properties.Resources.pagado;
                        }

                        Image smallImage = new Bitmap(image, new Size(newWidth, newHeight));

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

        public static bool MostrarResumen(int id, DataGridView dg)
        {
            try
            {
                DataTable localDataTable = new DataTable();

                using (SqlDataAdapter localDataAdapter = new SqlDataAdapter("SELECT p.nombre_produ AS Producto, " +
                    "tp.desc_tipoProd AS Tipo, p.detalle AS Detalle, p.precio AS PrecioUni, " +
                    "vd.cantidad AS Cantidad, vd.subtotal AS Subtotal " +                    
                    "FROM Venta_detalle vd " +
                    "INNER JOIN Producto p ON vd.id_produ = p.id_produ " +
                    "INNER JOIN Tipo_produ tp ON p.id_tipoProdu = tp.id_tipoProdu " +
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

        public bool agregarCabecera(int dni_c, int nro, int empl, DateTime fecha, decimal total, int idpago)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Venta_cabecera (id_venta, dni_empleado, dni_cliente, fecha_venta, total, tipo_pago) VALUES (@nro, @empleado, @cliente, @fecha, @total, @idpago)";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Usa parámetros para evitar la inyección de SQL
                    command.Parameters.AddWithValue("@nro", nro);
                    command.Parameters.AddWithValue("@empleado", empl);
                    command.Parameters.AddWithValue("@cliente", dni_c);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@total", total);
                    command.Parameters.AddWithValue("@idpago", idpago);

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

        //ver factura de la compra
        public void verFactura(int id)
        {
            Ffactura formularioFactura = new Ffactura(id);
            formularioFactura.ShowDialog();
        }

        public bool editarEstado(int id)
        {
            int estadoActual;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
                {
                    connection.Open();

                    string query_select = "SELECT estado FROM Venta_cabecera WHERE id_venta = @id";
                    using (SqlCommand cmd = new SqlCommand(query_select, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        estadoActual = (int)cmd.ExecuteScalar(); // Obtener el estado actual
                    }

                    if (estadoActual == 1)
                    {
                        string query_update = "UPDATE Venta_cabecera SET estado = 0 WHERE id_venta = @id";
                        using (SqlCommand cmd = new SqlCommand(query_update, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery(); // Ejecutar la actualización
                        }
                        return true;
                    }
                    else
                    {
                        string query_update = "UPDATE Venta_cabecera SET estado = 1 WHERE id_venta = @id";
                        using (SqlCommand cmd = new SqlCommand(query_update, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }

        }

        //filtro con todos los check 
        public bool filtrarVenta(int dni_c, string nom_c, int dni_e, string nom_e, int estado, int tipo_pago, DateTime? f_desde, DateTime? f_hasta, int tipo_us, DataGridView dt)
        {
            if(tipo_us == 1)//es un administrador, puede filtrar por empleado
            {
                if(!string.IsNullOrEmpty(nom_c) || !string.IsNullOrEmpty(nom_e) || dni_c > 0 || dni_e > 0 || estado != -1 || tipo_pago != -1)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string consulta = "SELECT vc.id_venta AS ID, vc.dni_empleado AS Empleado, " +
                                "vc.dni_cliente AS Cliente, c.nombre_cliente AS Nombre, vc.fecha_venta AS Fecha, vc.total AS Total, " +
                                "mp.desc_tipomedio AS MedioDePago, " +
                                "CASE WHEN vc.estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado " +
                                "FROM Venta_cabecera vc " +
                                "INNER JOIN Cliente c ON vc.dni_cliente = c.dni_cliente " +
                                "INNER JOIN Empleado e ON vc.dni_empleado = e.dni_empleado " +
                                "INNER JOIN medio_pago mp ON vc.tipo_pago = mp.tipo_medio " +
                                "WHERE 1 = 1 ";

                            if (!string.IsNullOrEmpty(nom_c))
                            {
                                consulta += " AND c.nombre_cliente LIKE @nombrec";
                            }
                            if (!string.IsNullOrEmpty(nom_e))
                            {
                                consulta += " AND e.nombre LIKE @nombre";
                            }
                            if (dni_c > 0)
                            {
                                consulta += " AND c.dni_cliente LIKE @dnic";
                            }
                            if (dni_e > 0)
                            {
                                consulta += " AND e.dni_empleado LIKE @dnie";
                            }
                            if (estado != -1)
                            {
                                consulta += " AND vc.estado = @estado";
                            }
                            if (tipo_pago != -1)
                            {
                                consulta += " AND vc.tipo_pago = @tipo";
                            }

                            using(SqlCommand command = new SqlCommand(consulta, connection))
                            {
                                if (!string.IsNullOrEmpty(nom_c))
                                {
                                    command.Parameters.AddWithValue("@nombrec", "%" + nom_c + "%");
                                }
                                if (!string.IsNullOrEmpty(nom_e))
                                {
                                    command.Parameters.AddWithValue("@nombre", "%" + nom_e + "%");
                                }
                                if (dni_e > 0)
                                {
                                    command.Parameters.AddWithValue("@dnie", "%" + dni_e + "%");
                                }
                                if (dni_c > 0)
                                {
                                    command.Parameters.AddWithValue("@dnic", "%" + dni_c + "%");
                                }
                                if (estado != -1)
                                {
                                    command.Parameters.AddWithValue("@estado", estado);
                                }
                                if (tipo_pago > 0)
                                {
                                    command.Parameters.AddWithValue("@tipo", tipo_pago);
                                }
                                SqlDataAdapter adapter = new SqlDataAdapter(command);
                                DataTable table = new DataTable();
                                adapter.Fill(table);

                                dt.DataSource = table;
                            }
                            return true;
                        }
                    } 
                    catch (Exception ex){
                        MessageBox.Show("Error: " + ex.Message);
                        return false;
                    }

                }else { return false; }
            } else //es vendedor, solo puede filtrar sus ventas
            {
                if (!string.IsNullOrEmpty(nom_c) || dni_c > 0 || estado != -1 || tipo_pago != -1)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            int dniEmpleado = cusuarios.ObtenerDniUsuario(UserLogin.NombreUsuario);
                            string consulta = "SELECT vc.id_venta AS ID, " +
                                "vc.dni_cliente AS Cliente, c.nombre_cliente AS Nombre, vc.fecha_venta AS Fecha, vc.total AS Total, " +
                                "mp.desc_tipomedio AS MedioDePago, " +
                                "CASE WHEN vc.estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado " +
                                "FROM Venta_cabecera vc " +
                                "INNER JOIN Cliente c ON vc.dni_cliente = c.dni_cliente " +
                                "INNER JOIN Empleado e ON vc.dni_empleado = e.dni_empleado " +
                                "INNER JOIN medio_pago mp ON vc.tipo_pago = mp.tipo_medio " +
                                "WHERE 1 = 1 AND vc.dni_empleado = @dni ";

                            if (!string.IsNullOrEmpty(nom_c))
                            {
                                consulta += " AND c.nombre_cliente LIKE @nombrec";
                            }
                            
                            if (dni_c > 0)
                            {
                                consulta += " AND c.dni_cliente LIKE @dnic";
                            }
                            
                            if (estado != -1)
                            {
                                consulta += " AND vc.estado = @estado";
                            }
                            if (tipo_pago != -1)
                            {
                                consulta += " AND vc.tipo_pago = @tipo";
                            }

                            using (SqlCommand command = new SqlCommand(consulta, connection))
                            {
                                command.Parameters.AddWithValue("@dni", dniEmpleado);
                                if (!string.IsNullOrEmpty(nom_c))
                                {
                                    command.Parameters.AddWithValue("@nombrec", "%" + nom_c + "%");
                                }           
                                if (dni_c > 0)
                                {
                                    command.Parameters.AddWithValue("@dnic", "%" + dni_c + "%");
                                }
                                if (estado != -1)
                                {
                                    command.Parameters.AddWithValue("@estado", estado);
                                }
                                if (tipo_pago > 0)
                                {
                                    command.Parameters.AddWithValue("@tipo", tipo_pago);
                                }

                                SqlDataAdapter adapter = new SqlDataAdapter(command);
                                DataTable table = new DataTable();
                                adapter.Fill(table);

                                dt.DataSource = table;
                            }
                            return true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return false;
                    }

                }
                else { return false; }
            }
        }

    }
}

    
    
