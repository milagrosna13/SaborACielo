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
            /* Dictionary<string, int> productosMasComunes = reporte.ObtenerProductosMasComunes();

             // Obtener los productos más comunes y su cantidad en stock desde tu clase Creporte.
             CmasProducido.Series.Clear();
             CmasProducido.Titles.Add("Productos Más Comunes");

             // Agregar los datos a la serie (asegúrate de que el nombre de la serie sea correcto).
             foreach (var producto in productosMasComunes)
             {
                 CmasProducido.Series["Series1"].Points.AddXY(producto.Key, producto.Value);
             }

             // Personalizar el gráfico (e.g., colores, leyendas, etc.).

             // Dibujar el gráfico.
             CmasProducido.DataBind();*/
        }
    }
}
