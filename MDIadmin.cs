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
    public partial class MDIadmin : Form
    {
        private int childFormNumber = 0;

        public MDIadmin()
        {
            InitializeComponent();
        }

        private void esconderSubmenu()
        {
            if (PsubmClientes.Visible == true)
                PsubmClientes.Visible = false;
            if (PsubmUsuarios.Visible == true)
                PsubmUsuarios.Visible = false; 
            if (PsubmProductos.Visible == true)
                PsubmProductos.Visible = false;
            if (PsubmVentas.Visible == true)
                PsubmVentas.Visible = false;
         

        }
        private void mostrarSubMenu(Panel subMenus) {
            if (subMenus.Visible == false)
            {
                esconderSubmenu();
                subMenus.Visible = true;
            }
            else
            {
                subMenus.Visible = false;
            }
        
        }

        private void Busuarios_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(PsubmUsuarios);
        }

        private void Bproductos_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(PsubmProductos);
        }

        private void Bventas_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(PsubmVentas);
        }

        private void Bclientes_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(PsubmClientes);
        }

        private Form activeForm = null;
        private void abrirFormularioHijo(Form formHijo)
        {
            if (activeForm != null) { activeForm.Close(); }
            activeForm = formHijo;
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            PchildAdmin.Controls.Add(formHijo);
            PchildAdmin.Tag = formHijo;//asocia el panel con el formulario hijo
            formHijo.BringToFront();//traer el formulario al frente
            formHijo.Show();
        }

        private void BlistaUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FlistaUsuarios());
        }

        private void BlistarProductos_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FlistaProductosAdmin());
        }

        private void BagregarUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FlistaUsuariosAdmin());
        }

        private void BagregarProdu_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FlistaProductosAdmin());
        }

        private void BlistarClientes_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FlistarClientes());
        }

        private void BlistarVentas_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FVentasEm());
        }

        private void BcerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Finicio loginForm = new Finicio();
            loginForm.Show();
        }

        private void BbajaCliente_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FlistarClientes());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Fusuarios());
        }
    }
}
