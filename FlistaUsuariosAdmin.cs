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
    public partial class FlistaUsuariosAdmin : Form
    {
        public FlistaUsuariosAdmin()
        {
            InitializeComponent();
        }

        private void TBdniUsuario_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TBnomUsuario_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void TBapeUsuario_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void TBdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBtelefono_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void limpiar()
        {
            TBapeUsuario.Clear();
            TBapellidoUsuario.Clear();
            TBnomUsuario.Clear();
            TBnombreUsuario.Clear();
            TBdireccion.Clear();
            TBtelefono.Clear();
            TBdniUsuario.Clear();
            TBdni.Clear();
            CBusuarioTipo.SelectedIndex = -1;
            CBtipoUsuario.SelectedIndex = -1;
            TBemail.Clear();
        }
                       
        private void BcancelProdu_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void BagregarUs_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBnomUsuario.Text) || string.IsNullOrEmpty(TBapeUsuario.Text) || string.IsNullOrWhiteSpace(TBdniUsuario.Text) )
            {
                MessageBox.Show("Debe completar los campos obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var res = MessageBox.Show("¿Desea guardar los datos del empleado: " + TBnomUsuario.Text + "", "Agregar empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.Cells.Add(new DataGridViewTextBoxCell { Value = TBnomUsuario.Text });
                    fila.Cells.Add(new DataGridViewTextBoxCell { Value = TBapeUsuario.Text });
                    fila.Cells.Add(new DataGridViewTextBoxCell { Value = TBdniUsuario.Text });
                    fila.Cells.Add(new DataGridViewTextBoxCell { Value = TBemail.Text });
                    fila.Cells.Add(new DataGridViewTextBoxCell { Value = TBdireccion.Text });
                    fila.Cells.Add(new DataGridViewTextBoxCell { Value = TBtelefono.Text });
                    fila.Cells.Add(new DataGridViewTextBoxCell { Value = CBusuarioTipo.SelectedItem?.ToString() });
                    fila.Cells.Add(new DataGridViewTextBoxCell { Value = "Activo"});

                    DGlistaUsuarios.Rows.Add(fila);
                    limpiar();
                }
                else
                {
                    limpiar();
                }
            }
        }

        private void BeditarUs_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBnomUsuario.Text) || string.IsNullOrEmpty(TBapeUsuario.Text) || string.IsNullOrWhiteSpace(TBdniUsuario.Text))
            {
                MessageBox.Show("Debe completar los campos obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (DGlistaUsuarios.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = DGlistaUsuarios.SelectedRows[0];
                    row.Cells["nom_em"].Value = TBnomUsuario.Text;
                    row.Cells["ape_em"].Value = TBapeUsuario.Text;
                    row.Cells["dni_em"].Value = TBdniUsuario.Text;
                    row.Cells["email_em"].Value = TBemail.Text;
                    row.Cells["direc_em"].Value = TBdireccion.Text;
                    row.Cells["tel_em"].Value = TBtelefono.Text;
                    row.Cells["perfil_em"].Value = CBusuarioTipo.SelectedItem?.ToString();
                    MessageBox.Show("Usuario editado con exito", "Editar", MessageBoxButtons.OK);
                    limpiar();
                    BagregarUs.Visible = true;
                }
            } 
        }

        private void DGlistaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DGlistaUsuarios.Rows[e.RowIndex];
            DataGridViewCell nombreCell = row.Cells["nom_em"];
            DataGridViewCell editarCell = row.Cells["editar_em"];
            DataGridViewCell eliminarCell = row.Cells["eliminar_em"];

            if (string.IsNullOrWhiteSpace(Convert.ToString(nombreCell.Value)))
            {
                editarCell.ReadOnly = true;
            }
            else
            {
                editarCell.ReadOnly = false;
                eliminarCell.ReadOnly = false;

                if (e.RowIndex >= 0 && e.ColumnIndex == DGlistaUsuarios.Columns["editar_em"].Index)
                {
                    var msg = MessageBox.Show("Desea editar el empleado?", "Confirmar editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {

                        BagregarUs.Visible = false;
                        BeditarUs.Visible = true;
                        TBnomUsuario.Text = row.Cells["nom_em"].Value.ToString();
                        TBapeUsuario.Text = row.Cells["ape_em"].Value.ToString();
                        TBdniUsuario.Text = row.Cells["dni_em"].Value.ToString();
                        TBemail.Text = row.Cells["email_em"].Value.ToString();
                        TBtelefono.Text = row.Cells["tel_em"].Value.ToString();
                        TBdireccion.Text = row.Cells["dire_em"].Value.ToString();
                        if (CBtipoUsuario.SelectedIndex != -1)
                        {
                            CBusuarioTipo.SelectedItem = row.Cells["perfil_em"].Value.ToString();
                        }
                    }
                }

                if (e.RowIndex >= 0 && e.ColumnIndex == DGlistaUsuarios.Columns["eliminar_em"].Index)
                {
                    var msg = MessageBox.Show("Desea eliminar el empleado?", "Confirmar eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        row.Cells["estado_em"].Value = "Inactivo";
                    }
                }
            }
        }
    }
}