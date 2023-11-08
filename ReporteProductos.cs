using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaborAcielo.datos;

namespace SaborAcielo
{
    public partial class ReporteProductos : Form
    {
        private Creporte reporte;
        public ReporteProductos()
        {
            InitializeComponent();
            reporte = new Creporte();
            List<string> nombres = reporte.ObtenerNombresUnicos();
            InicializarComboBoxes();
            bool resultado = reporte.CargarProductos(DGnombreProdu);
        }

        private void InicializarComboBoxes()
        {
            Creporte produ = new Creporte(); // Crea una instancia de la clase Cproducto

            // Obtiene los nombres y tipos de productos desde la base de datos utilizando la instancia cProducto
            List<string> nombres = produ.ObtenerNombresUnicos();
           

            // Llena los ComboBox con los valores obtenidos
            CnombreProd.Items.AddRange(nombres.ToArray());
           
        }
        private void ReporteProductos_Load(object sender, EventArgs e)
        {
            // Obtén los totales por tipo.
            Dictionary<string, int> totalesPorTipo = reporte.ObtenerTotalesPorTipo();

            // Actualiza los controles de texto en los paneles con los totales.
            if (PstockR.Controls.ContainsKey("LtotalR"))
            {
                Label labelR = PstockR.Controls["LtotalR"] as Label;
                if (labelR != null)
                {
                    labelR.Text = totalesPorTipo.ContainsKey("Regular") ? totalesPorTipo["Regular"].ToString() : "0";
                }
            }

            if (PstockV.Controls.ContainsKey("LtotalV"))
            {
                Label labelV = PstockV.Controls["LtotalV"] as Label;
                if (labelV != null)
                {
                    labelV.Text = totalesPorTipo.ContainsKey("Vegano") ? totalesPorTipo["Vegano"].ToString() : "0";
                }
            }

            if (PstockST.Controls.ContainsKey("LtotalST"))
            {
                Label labelST = PstockST.Controls["LtotalST"] as Label;
                if (labelST != null)
                {
                    labelST.Text = totalesPorTipo.ContainsKey("Sin T.A.C.C") ? totalesPorTipo["Sin T.A.C.C"].ToString() : "0";
                }
            }

            DataTable ventasTipo = reporte.ObtenerVentasTipo();
            // Definir una lista de colores para las barras
            Color[] colores = new Color[] { Color.Plum, Color.SandyBrown, Color.YellowGreen };
            int colorIndex = 0;
            // Mostrar los datos en el gráfico
            foreach (DataRow row in ventasTipo.Rows)
            {
                string tipoProducto = row["NombreTipoProducto"].ToString();
                int totalStock = Convert.ToInt32(row["TotalStock"]);

                // Agregar los datos al gráfico de barras
                CventasTipo.Series["Tipos"].Points.AddXY(tipoProducto, totalStock);
                CventasTipo.Series["Tipos"].Points[colorIndex].Color = colores[colorIndex % colores.Length];

                colorIndex++;

            }

            DataTable ventasNombre = reporte.ObtenerVentasNombre();

            // Mostrar los datos en el gráfico
            foreach (DataRow row in ventasNombre.Rows)
            {
                string nombre = row["nombre_produ"].ToString();
                int totalVenta = Convert.ToInt32(row["TotalVentas"]);

                // Agregar los datos al gráfico de barras
                Cpopulares.Series["Populares"].Points.AddXY(nombre, totalVenta);


            }
        }

        private void Bok_Click(object sender, EventArgs e)
        {
           
                DateTime fechaInicio = DT1.Value;
                DateTime fechaFin = DT2.Value;

                Creporte reporte = new Creporte();

                DataTable ventasTipo = reporte.ObtenerVentasTipo(fechaInicio, fechaFin);

                CventasTipo.Series["Tipos"].Points.Clear();

                
                foreach (DataRow row in ventasTipo.Rows)
                {
                    string tipoProducto = row["NombreTipoProducto"].ToString();
                    int totalStock = Convert.ToInt32(row["TotalStock"]);

                   
                    CventasTipo.Series["Tipos"].Points.AddXY(tipoProducto, totalStock);
                }

                DataTable ventasNombre = reporte.ObtenerVentasNombre(fechaInicio, fechaFin);

                
                Cpopulares.Series["Populares"].Points.Clear();

                
                foreach (DataRow row in ventasNombre.Rows)
                {
                    string nombre = row["nombre_produ"].ToString();
                    int totalVenta = Convert.ToInt32(row["TotalVentas"]);

                   
                    Cpopulares.Series["Populares"].Points.AddXY(nombre, totalVenta);
                }
           

        }

        private void Bhoy_Click(object sender, EventArgs e)
        {
            // Obtener la fecha de hoy
            DateTime fechaHoy = DateTime.Today;

            // Obtener los datos para hoy y mostrarlos en los gráficos
            MostrarDatosParaFecha(fechaHoy, fechaHoy);
        }

        private void B7Dias_Click(object sender, EventArgs e)
        {
            
            DateTime fechaInicio = DateTime.Today.AddDays(-6); // 6 días atrás
            DateTime fechaFin = DateTime.Today; 
            MostrarDatosParaFecha(fechaInicio, fechaFin);
        }

        private void Bmes_click(object sender, EventArgs e)
        {
           
            DateTime fechaInicio = DateTime.Today.AddMonths(-1).AddDays(1); // fecha hace un mes
            DateTime fechaFin = DateTime.Today; 
            MostrarDatosParaFecha(fechaInicio, fechaFin);
        }

        private void MostrarDatosParaFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            Creporte reporte = new Creporte();

            DataTable ventasTipo = reporte.ObtenerVentasTipo(fechaInicio, fechaFin);
            DataTable ventasNombre = reporte.ObtenerVentasNombre(fechaInicio, fechaFin);

            LimpiarGraficos(); 
            MostrarDatosEnGraficos(ventasTipo, ventasNombre);
        }

        private void LimpiarGraficos()
        {
            CventasTipo.Series["Tipos"].Points.Clear();
            Cpopulares.Series["Populares"].Points.Clear();
        }

        private void MostrarDatosEnGraficos(DataTable ventasTipo, DataTable ventasNombre)
        {
            foreach (DataRow row in ventasTipo.Rows)
            {
                string tipoProducto = row["NombreTipoProducto"].ToString();
                int totalStock = Convert.ToInt32(row["TotalStock"]);
                CventasTipo.Series["Tipos"].Points.AddXY(tipoProducto, totalStock);
            }

            foreach (DataRow row in ventasNombre.Rows)
            {
                string nombre = row["nombre_produ"].ToString();
                int totalVenta = Convert.ToInt32(row["TotalVentas"]);
                Cpopulares.Series["Populares"].Points.AddXY(nombre, totalVenta);
            }
        }

        private void BbuscarProducto_Click(object sender, EventArgs e)
        {
            string nombre = string.Empty;
            string tipo = string.Empty;

            if (CBnombre.Checked)
            {
                nombre = CnombreProd.SelectedItem.ToString();
            }

            if (CBtodosProductos.Checked)
            {
                nombre = string.Empty;
                tipo = string.Empty;
            }

            var productos = Creporte.ObtenerProductos(nombre); // Llamar al método a través de la instancia
            DGnombreProdu.DataSource = productos; // Asignar los resultados al DataGridView
        }

        private void CBnombre_CheckedChanged(object sender, EventArgs e)
        {
            CnombreProd.Enabled = CBnombre.Checked;
        }
    }
}
