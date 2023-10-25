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
    public partial class MDIempleado : Form
    {
        //private int childFormNumber = 0;

        public MDIempleado()
        {
            InitializeComponent();
        }

        private void esconderSubMenu()
        {
            if(PsubmnProductos.Visible == true)
            {
                PsubmnProductos.Visible = false;
            }
            if(PsubmnClientes.Visible == true)
            {
                PsubmnClientes.Visible = false;
            }
            if(PsubmnVentas.Visible == true) 
            { 
                PsubmnVentas.Visible = false;
            }
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                esconderSubMenu();
                subMenu.Visible = true;
            } else
            {
                subMenu.Visible = false;
            }
        }
        private void Bcliente_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(PsubmnClientes);
        }

        private void BagregarC_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FagregarCliente());
        }

        private void Bproducto_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(PsubmnProductos);
        }
        private void BverC_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FlistarClientes());
        }

        private void BmostrarProdu_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Fproducto());  
        }
        private void Bventa_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(PsubmnVentas);
        }
        private void BnuevaVenta_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FagregarVenta());
        }

        private Form activeForm = null;
        private void abrirFormularioHijo(Form formHijo)
        {
            if(activeForm != null) { activeForm.Close(); }
            activeForm = formHijo;
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            PchildForm.Controls.Add(formHijo);
            PchildForm.Tag = formHijo;//asocia el panel con el formulario hijo
            formHijo.BringToFront();//traer el formulario al frente
            formHijo.Show();
        }
        private void BlistarVenta_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FVentasEm());
        }

        private void BcerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Finicio loginForm = new Finicio();
            loginForm.Show();
        }
    }
}
