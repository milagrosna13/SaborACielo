using iText.Kernel.Events;
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
            if (UserLogin.TipoUsuario == 1)
            {
                Ccliente.AgregarBotonesAdm(DGlistaCliente);
            }
        }

        private void CBapeCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (CBapeCliente.Checked)
            {
                Tape_cliente.Enabled = true;
            }
            else
            {
                Tape_cliente.Enabled = false;
            }
        }

        private void CBnomCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (CBnomCliente.Checked)
            {
                Tnom_cliente.Enabled = true;
            }
            else
            {
                Tnom_cliente.Enabled = false;
            }
        }

        private void CBdni_CheckedChanged(object sender, EventArgs e)
        {
            if (CBdni.Checked)
            {
                Tdni_cliente.Enabled = true;
            }
            else
            {
                Tdni_cliente.Enabled = false;
            }
        }

        private void DGlistaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DGlistaCliente.Rows[e.RowIndex];
            DataGridViewCell estado = row.Cells["Estado"];
            DataGridViewCell eliminar = row.Cells["eliminar_cliente"];
            int dni_seleccionado;

            if (e.RowIndex >= 0 && e.ColumnIndex == DGlistaCliente.Columns["eliminar_cliente"].Index && Convert.ToInt32(DGlistaCliente.Rows[e.RowIndex].Cells["Dni"].Value) > 0)
            {
                dni_seleccionado = Convert.ToInt32(DGlistaCliente.Rows[e.RowIndex].Cells["Dni"].Value);
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

        private void CBtodosClientes_CheckedChanged(object sender, EventArgs e)
        {
            if(CBtodosClientes.Checked == true) {
                CBnomCliente.Checked = false;
                CBdni.Checked = false;
                CBapeCliente.Checked = false;

                bool res = clientes.MostrarClientes(DGlistaCliente);
            }
        }

        private void Tape_cliente_TextChanged(object sender, EventArgs e)
        {
            filtrarClientes();
        }

        private void Tdni_cliente_TextChanged(object sender, EventArgs e)
        {
            filtrarClientes();
        }

        private void filtrarClientes()
        {
            int dni;
            string nombre;
            string apellido;

            if (CBdni.Checked == true && !string.IsNullOrEmpty(Tdni_cliente.Text))
            {
                dni = Convert.ToInt32(Tdni_cliente.Text);
            }
            else dni = 0;
            if (CBnomCliente.Checked == true)
            {
                nombre = Tnom_cliente.Text;
            }
            else nombre = string.Empty;
            if(CBapeCliente.Checked == true)
            { 
                apellido = Tape_cliente.Text;
            } else apellido = string.Empty;

            bool filtro = clientes.FiltrarCliente(dni, nombre, apellido, null, DGlistaCliente);
        }

        private void Tnom_cliente_TextChanged(object sender, EventArgs e)
        {
            filtrarClientes();
        }
    }
}
