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
            abrirFormularioHijo(new ReporteVentas());
        }

        private void Bproducto_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new ReporteProductos());
        }

        private void MDIgerente_Load(object sender, EventArgs e)
        {
        }


        private void BcerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Finicio loginForm = new Finicio();
            loginForm.Show();
        }
    }
}
