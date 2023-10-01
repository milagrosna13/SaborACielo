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

namespace SaborAcielo
{
    public partial class FVentasEm : Form
    {
        Cventas filtroVenta = new Cventas();
        public FVentasEm()
        {
            InitializeComponent();
        }

        private void Fprodu_TextChanged(object sender, EventArgs e)
        {
            string filtro = Fprodu.Text;
            DataTable resultado = filtroVenta.FiltrarPorTexto(filtro);
            DGventas.DataSource = resultado;
        }
    }
}
