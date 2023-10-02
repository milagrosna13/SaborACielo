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
    public partial class MDIgerente : Form
    {
        public MDIgerente()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void esconderSubMenu()
        {
            if (Pvendedores.Visible == true)
            {
                Pvendedores.Visible = false;
            }
            if (Pclientes.Visible == true)
            {
                Pclientes.Visible = false;
            }
            if (Pventas.Visible == true)
            {
                Pventas.Visible = false;
            }
            if (Pprodu.Visible == true)
            {
                Pprodu.Visible = false;
            }
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                esconderSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private Form activeForm = null;
        private void abrirFormularioHijo(Form formHijo)
        {
            if (activeForm != null) { activeForm.Close(); }
            activeForm = formHijo;
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            PchildForm.Controls.Add(formHijo);
            PchildForm.Tag = formHijo;//asocia el panel con el formulario hijo
            formHijo.BringToFront();//traer el formulario al frente
            formHijo.Show();
        }

        private void Bvendedor_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(Pvendedores);
        }
        private void BeditarVendedor_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FlistaUsuariosAdmin());
        }

        private void Bproducto_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(Pprodu);
        }
        private void BlistarProdu_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Fproducto());
        }

        private void Bclientes_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(Pclientes);
        }

        private void Bventas_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(Pventas);
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

        private void MDIgerente_Load(object sender, EventArgs e)
        {
            esconderSubMenu();
        }

        private void BlistarVendedores_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FlistaUsuarios());
        }
    }
}
