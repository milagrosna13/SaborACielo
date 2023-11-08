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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SaborAcielo
{
    public partial class FVentasEm : Form
    {
        Cventas cventa = new Cventas();
        Cusuarios cusuarios = new Cusuarios();
        Cproducto cproducto = new Cproducto();  
        private int tipoUsuario;
        private string usuario;
        public FVentasEm()
        {
            InitializeComponent();

            tipoUsuario = EstablecerUsuario();

            bool exito = cventa.cargarVentas(DGventas, tipoUsuario);
            if(exito)
            {
                Cventas.botonDetalle(DGventas);
            }

            comboBoxes();
            
        }

        private void comboBoxes()
        {
            List<string> medios = cproducto.ObtenerModoPago();
            CBmedios.Items.AddRange(medios.ToArray());

            List<string> estados = new List<string> { "Activo", "Inactivo" };
            Cestado.Items.AddRange(estados.ToArray());
        }

        private int EstablecerUsuario()
        {
            usuario = UserLogin.NombreUsuario;
            int dni = cusuarios.ObtenerDniUsuario(usuario);
            int tipoUs = UserLogin.TipoUsuario;

            //es administrador
            if (tipoUs == 1)
            {
                Lusuario.Text = usuario;
                return tipoUs;
            } else if(tipoUs == 3)//es vendedor
            {
                CBem.Visible = false;
                LdniE.Visible = false;
                LnomE.Visible = false;
                TBnomE.Visible = false;
                TBdniE.Visible = false;
                Lusuario.Text = usuario;
                LdniEM.Text = Convert.ToString(dni);
                return tipoUs;
            } else
            {
                this.Close();
                return 0;
            }

        }

        private void Fcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Tbem_TextChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void TBdniC_TextChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void TBdniE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void CBfecha_CheckedChanged(object sender, EventArgs e)
        {
            if (CBfecha.Checked)
            {
                DTdesde.Enabled = true;
                DThasta.Enabled = true;
                
            }
        }

        private void filtrar()
        {
            string nomc;
            string nome;
            int dnic;
            int dnie;
            int estado;
            int pago;
            
            if(CBcliente.Checked == true)
            {
                if (!string.IsNullOrEmpty(TBdniC.Text)) { dnic = Convert.ToInt32(TBdniC.Text); }
                else dnic = 0;
                nomc = TBnomC.Text;
                
            } else { nomc = string.Empty; dnic = 0; }
            if(CBem.Checked  == true)
            {
                if (!string.IsNullOrEmpty(TBdniE.Text)) { dnie = Convert.ToInt32(TBdniE.Text); }
                else dnie = 0;
                nome = TBnomE.Text;
            } else
            {
                nome = string.Empty;
                dnie = 0;
            }
            if (CBestado.Checked == true)
            {
                estado = (string)Cestado.SelectedItem == "Activo" ? 1 : 0;
            }
            else estado = -1;

            if (CBpago.Checked == true && CBmedios.SelectedIndex != -1)
            {
                pago = CBmedios.SelectedIndex + 1;
            }
            else pago = -1;
            
            bool filtrar = cventa.filtrarVenta(dnic, nomc, dnie, nome, estado, pago, null, null, tipoUsuario, DGventas);
        }

        private void DGventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGventas.Columns["Detalle"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(DGventas.Rows[e.RowIndex].Cells["ID"].Value);
                Cventas.MostrarResumen(id, DGdetalle);
            }
        }

        private void DTdesde_ValueChanged(object sender, EventArgs e)
        {
            cventa.buscarFecha(DTdesde.Value, DThasta.Value, DGventas);
        }

        private void DThasta_ValueChanged(object sender, EventArgs e)
        {
            cventa.buscarFecha(DTdesde.Value, DThasta.Value, DGventas);
        }


        private void CBestado_CheckedChanged(object sender, EventArgs e)
        {
            if (CBestado.Checked == true) {
                Cestado.Enabled = true;
            } else
            {
                Cestado.Enabled = false;
            }

        }

        private void CBcliente_CheckedChanged(object sender, EventArgs e)
        {
            if (CBcliente.Checked == true)
            {
                TBdniC.Enabled = true;
                TBnomC.Enabled = true;
            } else
            {
                TBdniC.Enabled = false;
                TBnomC.Enabled = false;
            }
        }

        private void CBem_CheckedChanged(object sender, EventArgs e)
        {
            if(CBem.Checked == true)
            {
                TBdniE.Enabled = true;
                TBnomE.Enabled = true;
            } else
            {
                TBdniE.Enabled = false;
                TBnomE.Enabled = false;
            }
        }

        private void CBpago_CheckedChanged(object sender, EventArgs e)
        {
            
            if (CBpago.Checked == true)
            {
                CBmedios.Enabled = true;
            } else
            {
                CBmedios.Enabled = false;
            }
        }

        private void CBmedios_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void Cestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void TBnomC_TextChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void TBnomE_TextChanged(object sender, EventArgs e)
        {
            filtrar();
        }
    }
}
