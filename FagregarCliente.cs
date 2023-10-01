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
    public partial class FagregarCliente : Form
    {
        public FagregarCliente()
        {
            InitializeComponent();
        }

        private void BguardarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBnomCliente.Text) || string.IsNullOrEmpty(TBapeCliente.Text) ||
                string.IsNullOrEmpty(TBdniCliente.Text))
            {
                MessageBox.Show("Debe completar los campos obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                var res = MessageBox.Show("¿Desea guardar los datos del cliente: " + TBnomCliente.Text + "" + TBapeCliente.Text, "Guardar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(res == System.Windows.Forms.DialogResult.Yes)
                {
                    string sexo = RBmujer.Checked == true ? RBmujer.Text : RBhombre.Text;

                    //mostrar en datagrid
                    DGclientes.Rows.Add(TBnomCliente.Text, TBapeCliente.Text, TBdniCliente.Text, sexo, TBtelCliente.Text, TBdireCliente.Text, "Activo");

                    MessageBox.Show("Cliente guardado con éxito", "Guardar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpiarTextBox();
                } else
                {
                    limpiarTextBox();
                }

            }
        }

        private void limpiarTextBox()
        {
            TBnomCliente.Text = "";
            TBapeCliente.Text = "";
            TBdireCliente.Text = "";
            TBdniCliente.Text = "";
            TBtelCliente.Text = "";
        }

        private void TBnomCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TBapeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void BcancelCliente_Click(object sender, EventArgs e)
        {
            limpiarTextBox();
        }

        private void TBdniCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TBtelCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TBnomCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DGclientes.Rows[e.RowIndex];
            DataGridViewCell estadoCell = row.Cells["estado_cliente"];
            DataGridViewCell eliminarCell = row.Cells["baja_cliente"];
            DataGridViewCell nombreCell = row.Cells["nombre_cliente"];


            if (string.IsNullOrWhiteSpace(Convert.ToString(nombreCell.Value)))
            {
                eliminarCell.ReadOnly = true;
            }
            else
            {   if (estadoCell.Value.ToString() == "Inactivo")
                {
                    eliminarCell.ReadOnly = false;
                    if (e.RowIndex >= 0 && e.ColumnIndex == DGclientes.Columns["baja_cliente"].Index)
                    {
                        var msg = MessageBox.Show("Desea dar de baja al cliente?", "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (msg == DialogResult.Yes)
                        {
                            DGclientes[6, e.RowIndex].Value = "Inactivo";
                            MessageBox.Show("Cliente dado de baja", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            
        }

        private void DGclientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow row = DGclientes.Rows[e.RowIndex];
            DataGridViewCell nombreCell = row.Cells["nombre_cliente"];
            DataGridViewCell eliminarCell = row.Cells["baja_cliente"];

            if (e.ColumnIndex == 7 && e.RowIndex >= 0) 
            {
                // Verifica el contenido de la columna "estado"
                if (e.Value != null && e.Value.ToString() == "Activo") 
                {
                    // Habilita el botón eliminar
                    eliminarCell.ReadOnly = false;

                }
                else
                {
                    // Deshabilita el botón eliminar
                    eliminarCell.ReadOnly= true;
                }
            }
        }
    }
}
