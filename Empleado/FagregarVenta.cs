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
    public partial class FagregarVenta : Form
    {
        public FagregarVenta()
        {
            InitializeComponent();
        }

        private void Ncant_ValueChanged(object sender, EventArgs e)
        {
            TBprecioProd.Text = Convert.ToString(2);
            TBsubtotal.Text = Convert.ToString(Ncant.Value * Convert.ToInt32(TBprecioProd.Text));
        }

        private void BagregarCompra_Click(object sender, EventArgs e)
        {
            float total = Convert.ToInt32(TBsubtotal.Text);
            DataGridViewRow fila = new DataGridViewRow();
            fila.Cells.Add(new DataGridViewTextBoxCell { Value =  total});
        }
    }
}
