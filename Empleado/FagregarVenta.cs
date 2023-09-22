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
        int precio = 2;
        private void Ncant_ValueChanged(object sender, EventArgs e)
        {
            TBsubtotal.Text = Convert.ToString(Ncant.Value * precio);
        }
        int venta;
       
        private void BagregarCompra_Click(object sender, EventArgs e)
        {
            venta++;
            float total = Convert.ToInt32(TBsubtotal.Text);
            DataGridViewRow fila = new DataGridViewRow();
            fila.Cells.Add(new DataGridViewTextBoxCell { Value = venta});
            fila.Cells.Add(new DataGridViewTextBoxCell { Value = CBtipoProd.Text });
            fila.Cells.Add(new DataGridViewTextBoxCell { Value = CBproducto.Text });
            fila.Cells.Add(new DataGridViewTextBoxCell { Value = Ncant.Value });
            fila.Cells.Add(new DataGridViewTextBoxCell { Value =  total});
            
            DGcarrito.Rows.Add(fila); 

        }

        private void Bcompra_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Seguro quiere finalizar la compra?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == System.Windows.Forms.DialogResult.Yes) {
                MessageBox.Show("Compra realizada con éxito", "Compra realizada", MessageBoxButtons.OK);

            }
        }
    }
}
