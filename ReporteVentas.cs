using SaborAcielo.datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SaborAcielo
{
    public partial class ReporteVentas : Form
    {
        public ReporteVentas()
        {
            InitializeComponent();
            ActualizarLabels();
        }

        private Creporte reporte = new Creporte();

        private void ActualizarLabels()
        {
            LtotalV.Text = reporte.ObtenerTotalVentas().ToString();
            LtotalG.Text = reporte.ObtenerTotalGanancia().ToString();
            LtotalC.Text = reporte.ObtenerTotalClientes().ToString();

            CargarDatosEnGrafico();
        }

        private void CargarDatosEnGrafico()
        {
            DataTable datosTotalesPorFecha = reporte.ObtenerTotalesPorFecha();

            ChartGanancias.Series.Clear();
            ChartGanancias.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd"; // Formato de fecha para el eje X

            Series series = new Series("GananciasPorFecha");
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 8;
            foreach (DataRow row in datosTotalesPorFecha.Rows)
            {
                DateTime fecha = Convert.ToDateTime(row["fecha"]); // Utiliza "fecha" en lugar de "date"
                decimal total = Convert.ToDecimal(row["TotalVentas"]);

                series.Points.AddXY(fecha, total);
            }

            ChartGanancias.Series.Add(series);

            // Configurar los ejes X e Y
            ChartGanancias.ChartAreas[0].AxisX.Title = "Fechas"; // Título para el eje X
            ChartGanancias.ChartAreas[0].AxisY.Title = "Ganancias";
        }
        private void Bok_Click(object sender, EventArgs e)
        {

            DateTime? fechaInicio = DT1.Checked ? DT1.Value : (DateTime?)null;
            DateTime? fechaFin = DT2.Checked ? DT2.Value : (DateTime?)null;

            Creporte reporte = new Creporte();

            DataTable ventasTipo = reporte.ObtenerTotalesPorFecha(fechaInicio, fechaFin);

            ChartGanancias.Series["GananciasPorFecha"].Points.Clear();



           
            foreach (DataRow row in ventasTipo.Rows)
            {
                DateTime fecha = Convert.ToDateTime(row["fecha"]); 
                decimal total = Convert.ToDecimal(row["TotalVentas"]); 

                // Agregar los nuevos puntos al gráfico
               
                ChartGanancias.Series["GananciasPorFecha"].Points.AddXY(fecha, total);
                
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

            DataTable ventasTipo = reporte.ObtenerTotalesPorFecha(fechaInicio, fechaFin);
           

            LimpiarGraficos();
            MostrarDatosEnGraficos(ventasTipo);
        }
        private void MostrarDatosEnGraficos( DataTable ventasNombre)
        {
        

            foreach (DataRow row in ventasNombre.Rows)
            {
                DateTime fecha = Convert.ToDateTime(row["fecha"]);
                decimal total = Convert.ToDecimal(row["TotalVentas"]);
                ChartGanancias.Series["GananciasPorFecha"].Points.AddXY(fecha, total);
            }
        }

        private void LimpiarGraficos()
        {
            ChartGanancias.Series["GananciasPorFecha"].Points.Clear();
          
        }

    }
}
