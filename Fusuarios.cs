using SaborAcielo.datos;
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
    public partial class Fusuarios : Form
    {
        public Fusuarios()
        {
            InitializeComponent();
            Cempleado empleado = new Cempleado();
            empleado.CargarUsuarios(DGusuarios);
        }
    }
}
