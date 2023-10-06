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
    public partial class FlistarClientes : Form
    {
        public FlistarClientes()
        {
            InitializeComponent();
        }

        private void CBapeCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (CBapeCliente.Checked)
            {
                Tape_cliente.ReadOnly = false;
            }
            else
            {
                Tape_cliente.ReadOnly = true;
            }
        }

        private void CBnomCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (CBnomCliente.Checked)
            {
                Tnom_cliente.ReadOnly = false;
            }
            else
            {
                Tnom_cliente.ReadOnly = true;
            }
        }

        private void CBdni_CheckedChanged(object sender, EventArgs e)
        {
            if (CBdni.Checked)
            {
                Tdni_cliente.ReadOnly = false;
            }
            else
            {
                Tdni_cliente.ReadOnly = true;
            }
        }

        private void DGlistaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DGlistaCliente.Rows[e.RowIndex];
            DataGridViewCell estado = row.Cells["estado"];
            DataGridViewCell eliminar = row.Cells["baja"];

            if (estado.Value.ToString() == "Inactivo")
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == DGlistaCliente.Columns["baja_cliente"].Index)
                {
                    var msg = MessageBox.Show("Desea dar de baja al cliente?", "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        row.Cells["estado"].Value = "Inactivo";
                        MessageBox.Show("Cliente dado de baja", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            } else
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == DGlistaCliente.Columns["baja_cliente"].Index)
                {
                    var msg = MessageBox.Show("Desea dar de alta al cliente?", "Confirmar Alta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        row.Cells["estado"].Value = "Activo";
                        MessageBox.Show("Cliente dado de alta con exito", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
