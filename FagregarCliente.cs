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
                var res = MessageBox.Show("¿Desea guardar los datos del cliente: " + TBnomCliente.Text + " " + TBapeCliente.Text, "Guardar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(res == DialogResult.Yes)
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
            if(Beditar.Visible) { Beditar.Visible = false; }    
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
            DataGridViewCell editar = row.Cells["editar_cliente"];
            DataGridViewCell nombreCell = row.Cells["nombre_cliente"];


            if (string.IsNullOrWhiteSpace(Convert.ToString(nombreCell.Value)))
            {
                editar.ReadOnly = true;
            }
            else
            {   
                editar.ReadOnly = false;
                var res = MessageBox.Show("Desea editar los datos del cliente?", "Editar", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Beditar.Visible = true;
                    
                    string sexo = row.Cells["sexo_cliente"].Value.ToString();
                    switch (sexo)
                    {
                        case "Hombre":
                            RBhombre.Checked = true; break;
                        default:
                            RBmujer.Checked = true; break;
                    }

                    
                    TBnomCliente.Text = row.Cells["nombre_cliente"].Value.ToString();
                    TBapeCliente.Text = row.Cells["apellido_cliente"].Value.ToString();
                    TBdniCliente.Text = row.Cells["dni_cliente"].Value.ToString();
                    TBtelCliente.Text = row.Cells["tel_cliente"].Value.ToString();
                    TBdireCliente.Text = row.Cells["direc_cliente"].Value.ToString();


                }
                else limpiarTextBox();
                
               
            }
            
        }

        private void Beditar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TBnomCliente.Text) || string.IsNullOrEmpty(TBapeCliente.Text) || string.IsNullOrEmpty(TBdniCliente.Text))
            {
                MessageBox.Show("Debe completar los campos obligatorios");
            } else
            {
                var msg = MessageBox.Show("Se editarán los datos del cliente: " + TBnomCliente.Text, "Confirmar editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    string sexo = RBmujer.Checked == true ? RBmujer.Text : RBhombre.Text;

                    DataGridViewRow row = DGclientes.Rows[DGclientes.CurrentCell.RowIndex];
                    row.Cells["nombre_cliente"].Value = TBnomCliente.Text;
                    row.Cells["apellido_cliente"].Value = TBapeCliente.Text;
                    row.Cells["dni_cliente"].Value = TBdniCliente.Text;
                    row.Cells["tel_cliente"].Value = TBtelCliente.Text;
                    row.Cells["direc_cliente"].Value = TBdireCliente.Text;
                    row.Cells["sexo_cliente"].Value = sexo;
                    
                    limpiarTextBox();

                    Beditar.Visible = false;
                }
                else limpiarTextBox();
            }
        }
        
    }
}
