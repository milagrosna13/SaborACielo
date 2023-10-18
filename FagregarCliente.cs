using SaborAcielo.datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
            Ccliente clientes = new Ccliente();
            bool res = clientes.MostrarClientes(DGclientes);
            Ccliente.AgregarBotonEditar(DGclientes);
        }

        private void BguardarCliente_Click(object sender, EventArgs e)
        {
            Ccliente cliente = new Ccliente();
            if (string.IsNullOrWhiteSpace(TBnomCliente.Text) || string.IsNullOrEmpty(TBapeCliente.Text) ||
                string.IsNullOrEmpty(TBdniCliente.Text))
            {
                MessageBox.Show("Debe completar los campos obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var res = MessageBox.Show("¿Desea guardar los datos del cliente: " + TBnomCliente.Text + " " + TBapeCliente.Text, "Guardar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string sexo = RBmujer.Checked == true ? RBmujer.Text : RBhombre.Text;

                    if (Ccliente.clienteExiste(Convert.ToInt32(TBdniCliente.Text)))
                    {
                        MessageBox.Show("El cliente ya está registrado", "Advertencia", MessageBoxButtons.OK);
                        limpiarTextBox();

                        cliente.MostrarClientes(DGclientes);
                    }
                    else
                    {
                        bool insert = Ccliente.AgregarCliente(Convert.ToInt32(TBdniCliente.Text), TBnomCliente.Text, TBapeCliente.Text, TBdireCliente.Text, TBtelCliente.Text, TBcorreo.Text, sexo, "activo");

                        if (insert)
                        {
                            MessageBox.Show("Cliente guardado con éxito", "Guardar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            cliente.MostrarClientes(DGclientes);
                            limpiarTextBox();
                        }
                        limpiarTextBox();
                    }
                }
                else
                {
                    limpiarTextBox();
                }

            }
        }

        private void limpiarTextBox()
        {
            TBnomCliente.Clear();
            TBapeCliente.Clear();
            TBdireCliente.Clear();
            TBdniCliente.Clear();
            TBtelCliente.Clear();
            TBcorreo.Clear();

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
            if (Beditar.Visible) { Beditar.Visible = false; }
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

        private void DGclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGclientes.Columns["editar_cliente"].Index && e.RowIndex >= 0)
            {
                int dni = Convert.ToInt32(DGclientes.Rows[e.RowIndex].Cells["dni_cliente"].Value);

                //se cargan los campos del cliente
                Ccliente cliente = new Ccliente();
                DataRow datosCliente = cliente.obtenerCliente(dni);

                if (datosCliente != null)
                {
                    TBdniCliente.Text = datosCliente["dni_cliente"].ToString();
                    TBnomCliente.Text = datosCliente["nombre_cliente"].ToString();
                    TBapeCliente.Text = datosCliente["apellido_cliente"].ToString();
                    TBdireCliente.Text = datosCliente["dire_cliente"].ToString();
                    TBtelCliente.Text = datosCliente["tel_cliente"].ToString();
                    TBcorreo.Text = datosCliente["email_cliente"].ToString();

                    Beditar.Visible = true;
                    BguardarCliente.Visible = false;
                }

            }
        }

        private void Beditar_Click(object sender, EventArgs e)
        {
            Ccliente cliente = new Ccliente();

            if (string.IsNullOrEmpty(TBnomCliente.Text) || string.IsNullOrEmpty(TBapeCliente.Text) || string.IsNullOrEmpty(TBdniCliente.Text))
            {
                MessageBox.Show("Debe completar los campos obligatorios");
            }
            else
            {
                var msg = MessageBox.Show("Se editarán los datos del cliente: " + TBnomCliente.Text, "Confirmar editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    string sexo = RBmujer.Checked == true ? RBmujer.Text : RBhombre.Text;
                    DataRow datosCliente = cliente.obtenerCliente(Convert.ToInt32(TBdniCliente.Text));
                    string estado = datosCliente["estado_cliente"].ToString();

                    //editar
                    bool exito = Ccliente.EditarCliente(Convert.ToInt32(TBdniCliente.Text), TBnomCliente.Text, TBapeCliente.Text, TBdireCliente.Text, TBtelCliente.Text, estado, TBcorreo.Text);
                    if (exito)
                    {
                        MessageBox.Show("Los datos del cliente se actualizaron exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cliente.MostrarClientes(DGclientes);
                    }

                    limpiarTextBox();
                    BguardarCliente.Visible = true;
                    Beditar.Visible = false;
                }
                else limpiarTextBox();
            }
        }

    }
}
