using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaborAcielo
{
    public partial class Finicio : Form
    {
        string user = "v01";
        string pass = "1234";
        public Finicio()
        {
            InitializeComponent();
        }

        private void Bcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bingresar_Click(object sender, EventArgs e)
        {
            this.Close();

            // Crea un nuevo formulario MDI
            MDIempleado nuevoFormularioMDI = new MDIempleado();
            nuevoFormularioMDI.Show();
        }
    }
}
