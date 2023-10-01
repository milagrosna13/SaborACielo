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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace SaborAcielo
{
    public partial class FagregarVenta : Form
    {
        public FagregarVenta()
        {
            InitializeComponent();
        }

        private int precio = 2000;
        private int venta = 1;
        private int compra;
        private void Ncant_ValueChanged(object sender, EventArgs e)
        {
            TBprecioProd.Text = Convert.ToString(precio);
            TBsubtotal.Text = Convert.ToString(Ncant.Value * precio);
        }
        
       
        private void limpiar()
        {
            TBprecioProd.Clear();
            Fproducto.Clear();
            Ncant.Value = 0;
            TBsubtotal.Clear();
            TBprecioProd.Clear();
            CtipoProd.SelectedIndex = -1;
        }

        private void BagregarCompra_Click(object sender, EventArgs e)
        {
            float total = Convert.ToInt32(TBsubtotal.Text);
            DataGridViewRow fila = new DataGridViewRow();
            fila.Cells.Add(new DataGridViewTextBoxCell { Value = venta});
            fila.Cells.Add(new DataGridViewTextBoxCell { Value = CtipoProd.Text });
            fila.Cells.Add(new DataGridViewTextBoxCell { Value = Fproducto.Text });
            fila.Cells.Add(new DataGridViewTextBoxCell { Value = Ncant.Value });
            fila.Cells.Add(new DataGridViewTextBoxCell { Value =  total});
            
            DGcarrito.Rows.Add(fila);
            compra = venta - 1;
            limpiar();
        }

        private void Bcompra_Click(object sender, EventArgs e)
        {
            if (DGcarrito.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar productos a la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (compra == venta - 1) 
            { 
                var res = MessageBox.Show("Seguro quiere finalizar la compra?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    venta++;
                    MessageBox.Show("Compra realizada con éxito", "Compra realizada", MessageBoxButtons.OK);
                }
            } else
            {

            }
        }
        private void Fproducto_TextChanged(object sender, EventArgs e)
        {}

        private void Fproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void BcancelarCompra_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void DGcarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DGcarrito.Rows[e.RowIndex];
            DataGridViewCell nombreCell = row.Cells["id_venta"];
            DataGridViewCell eliminarCell = row.Cells["baja"];

            if (string.IsNullOrWhiteSpace(Convert.ToString(nombreCell.Value)))
            {
                eliminarCell.ReadOnly = true;
            }
            else
            {
                eliminarCell.ReadOnly = false;
                var msg = MessageBox.Show("Desea eliminar el producto del carrito?", "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    if (e.RowIndex >= 0 && e.ColumnIndex == DGcarrito.Columns["baja"].Index)
                    {
                        DGcarrito.Rows.RemoveAt(e.RowIndex);
                    }
                    MessageBox.Show("Producto eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
