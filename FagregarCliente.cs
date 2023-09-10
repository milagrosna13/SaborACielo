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
                var res = MessageBox.Show("Se guardará el cliente: " + TBnomCliente.Text + TBapeCliente.Text, "Guardar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if(res == System.Windows.Forms.DialogResult.Yes)
                {
                    string sexo;
                    if(RBmujer.Checked == true)
                    {
                        sexo = RBmujer.Text;
                    } else
                    {
                        sexo = RBhombre.Text;
                    }

                    //mostrar en datagrid
                    DGclientes.Rows.Add(TBnomCliente.Text, TBapeCliente.Text, TBdniCliente.Text, sexo, TBtelCliente.Text, TBdireCliente.Text);

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
    }
}
