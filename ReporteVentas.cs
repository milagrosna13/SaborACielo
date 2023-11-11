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
            ComboBoxNombre.AutoCompleteCustomSource = reporte.ObtenerSugerenciasNombre();
            CBoxApellido.AutoCompleteCustomSource = reporte.ObtenerSugerenciasApellido();
            bool resultado = reporte.CargarEmpleados(DGempleados);
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
            series.IsValueShownAsLabel = true;
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

        private void BbuscarEmpleado_Click(object sender, EventArgs e)
        {
            // Obtiene los parámetros de búsqueda desde la interfaz de usuario
            int dni = 0;
            string nombre = string.Empty;
            string apellido = string.Empty;
        

            if (CBnombre.Checked && !string.IsNullOrEmpty(ComboBoxNombre.Text))
            {
                nombre = ComboBoxNombre.Text;
            }

            if (CBapellido.Checked && !string.IsNullOrEmpty(CBoxApellido.Text))
            {
                apellido = CBoxApellido.Text;
            }
            if (CBdni.Checked && !string.IsNullOrEmpty(TBoxDni.Text)) { dni = Convert.ToInt32(TBoxDni.Text); }

            // Verifica si el checkbox "Todos los productos" está marcado
            if (CBtodosEmpleados.Checked)
            {
                dni = 0;
                nombre = string.Empty;  // Ignora la búsqueda por nombre
                apellido = string.Empty;    // Ignora la búsqueda por tipo
             
            }

            // Llama al método de la clase CProducto para obtener los resultados
            var empleados = Creporte.ObtenerEmpleados(nombre, apellido, dni);

            // Muestra los resultados en el DataGridView
            DGempleados.DataSource = empleados;
        }
        private void TBoxDni_TextChanged(object sender, EventArgs e)
        {
            Cempleado empleado = new Cempleado();
            int dniBusqueda;

            if (int.TryParse(TBoxDni.Text, out dniBusqueda))
            {
                LBdni.Visible = true;

                DataTable resultados = empleado.BuscarDni(dniBusqueda);

                LBdni.Items.Clear();
                foreach (DataRow row in resultados.Rows)
                {
                    LBdni.Items.Add(row["dni_empleado"].ToString());
                }
            }
            else
            {
                LBdni.Items.Clear();
                LBdni.Visible = false;
            }
        }

        private void LBdni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBdni.SelectedIndex >= 0)
            {
                TBoxDni.Text = LBdni.SelectedItem.ToString();
            }
            LBdni.Visible = false;
        }


        private void TBoxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void ComboBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void CBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void ReporteVentas_Load(object sender, EventArgs e)
        {
            DataTable ventasNombre = reporte.ObtenerTopEmpleados();

            // Mostrar los datos en el gráfico
            foreach (DataRow row in ventasNombre.Rows)
            {
                string nombre = row["nombre"].ToString();
                int totalVenta = Convert.ToInt32(row["TotalGanancias"]);

                // Agregar los datos al gráfico de barras
                ctopEmp.Series["TOP3"].Points.AddXY(nombre, totalVenta);


            }
        }
    }

}
