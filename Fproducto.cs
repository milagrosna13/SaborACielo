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
    public partial class Fproducto : Form
    {
        public Fproducto()
        {
            InitializeComponent();
            Cproducto producto = new Cproducto();
            bool resultado = producto.CargarProductos(DGlistaProductos);
        }
    }
}
