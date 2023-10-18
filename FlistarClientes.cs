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
    public partial class FlistarClientes : Form
    {
        private Ccliente clientes = new Ccliente();
        public FlistarClientes()
        {
            InitializeComponent();
            bool res = clientes.MostrarClientes(DGlistaCliente);
            Ccliente.AgregarBotonesAdm(DGlistaCliente);
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

        private void DGlistaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DGlistaCliente.Rows[e.RowIndex];
            DataGridViewCell estado = row.Cells["estado_cliente"];
            DataGridViewCell eliminar = row.Cells["eliminar_cliente"];
            int dni_seleccionado;

            if (e.RowIndex >= 0 && e.ColumnIndex == DGlistaCliente.Columns["eliminar_cliente"].Index)
            {
                dni_seleccionado = Convert.ToInt32(DGlistaCliente.Rows[e.RowIndex].Cells["dni_cliente"].Value);
                if (estado.Value.ToString() == "inactivo")
                {
                    var msg = MessageBox.Show("Desea dar de alta al cliente?", "Confirmar alta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        Ccliente.EditarEstado(dni_seleccionado);
                        MessageBox.Show("Cliente dado de alta", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clientes.MostrarClientes(DGlistaCliente);
                    }
                }
                else
                {
                    var msg = MessageBox.Show("Desea dar de baja al cliente?", "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        Ccliente.EditarEstado(dni_seleccionado);
                        MessageBox.Show("Cliente dado de baja con exito", "Baja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clientes.MostrarClientes(DGlistaCliente);
                    }
                }
            }
        }
    }
}
