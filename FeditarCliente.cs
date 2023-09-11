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
    public partial class FeditarCliente : Form
    { 
        int pos;
        public FeditarCliente()
        {
            InitializeComponent();
            
        }

        private void BeditarCliente_Click(object sender, EventArgs e)
        {
            DGclientes[0, pos].Value = TBnomCliente.Text;
            DGclientes[1, pos].Value = TBapeCliente.Text;
            DGclientes[2, pos].Value = TBdniCliente.Text;
            DGclientes[4, pos].Value = TBtelCliente.Text;
            DGclientes[5, pos].Value = TBdireCliente.Text;
            //DGclientes[0, pos].Value = TBapeCliente.Text;

        }

        private void DGclientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = DGclientes.CurrentRow.Index;
            TBnomCliente.Text = DGclientes[0,pos].Value.ToString();
            TBapeCliente.Text = DGclientes[1, pos].Value.ToString();
            TBdniCliente.Text = DGclientes[2, pos].Value.ToString();
            //TBsexoCliente.Text = DGclientes[0, pos].Value.ToString();
            TBtelCliente.Text = DGclientes[4, pos].Value.ToString();
            TBdireCliente.Text = DGclientes[5, pos].Value.ToString();

        }

        private void bagregar_Click(object sender, EventArgs e)
        {
            string sexo;
            if (RBmujer.Checked == true)
            {
                sexo = RBmujer.Text;
            }
            else
            {
                sexo = RBhombre.Text;
            }

            //mostrar en datagrid
            DGclientes.Rows.Add(TBnomCliente.Text, TBapeCliente.Text, TBdniCliente.Text, sexo, TBtelCliente.Text, TBdireCliente.Text);

        }
    }
}
