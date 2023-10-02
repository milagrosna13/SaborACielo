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
    }
}
