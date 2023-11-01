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
            CargarFechasDisponibles(); 
            InicializarComboBoxes();
        }

        private void InicializarComboBoxes()
        {
            Cproducto cProducto = new Cproducto(); // Crea una instancia de la clase Cproducto

            // Obtiene los nombres y tipos de productos desde la base de datos utilizando la instancia cProducto
            List<string> nombres = cProducto.ObtenerNombresUnicos();
            List<string> tipos = cProducto.ObtenerTipos();

            // Llena los ComboBox con los valores obtenidos
            CnombreProd.Items.AddRange(nombres.ToArray());
            CfiltroTipo.Items.AddRange(tipos.ToArray());
        }
        private void BbuscarProducto_Click(object sender, EventArgs e)
        {

            // Obtiene los parámetros de búsqueda desde la interfaz de usuario
            string nombre = string.Empty;
            string tipo = string.Empty;
            DateTime? fecha = CBfecha.Checked ? DTfechaIng.Value : (DateTime?)null;

            if (CBnombre.Checked)
            {
                nombre = CnombreProd.SelectedItem.ToString();
            }

            if (CBtipo.Checked)
            {
                tipo = CfiltroTipo.SelectedItem.ToString();
            }

            // Verifica si el checkbox "Todos los productos" está marcado
            if (CBtodosProductos.Checked)
            {
                nombre = string.Empty;  // Ignora la búsqueda por nombre
                tipo = string.Empty;    // Ignora la búsqueda por tipo
                fecha = null;           // Ignora la búsqueda por fecha
            }

            // Llama al método de la clase CProducto para obtener los resultados
            var productos = Cproducto.ObtenerProductos(nombre, tipo, fecha);

            // Muestra los resultados en el DataGridView
            DGlistaProductos.DataSource = productos;

        }

        private List<DateTime> fechasDisponibles = new List<DateTime>();
        private void CargarFechasDisponibles()
        {
            Cproducto cProducto = new Cproducto(); // Crear una instancia de la clase CProducto
                                                   // Utiliza el método en la instancia de la clase CProducto
            fechasDisponibles = cProducto.ObtenerFechasDisponibles();

            // Si hay fechas disponibles, habilita el control DateTimePicker
            if (fechasDisponibles.Count > 0)
            {
                DTfechaIng.Enabled = true;
            }
            else
            {
                DTfechaIng.Enabled = false;
            }
        }

        private void CBnombre_CheckedChanged(object sender, EventArgs e)
        {
            CnombreProd.Enabled = CBnombre.Checked;
        }

        private void CBtipo_CheckedChanged(object sender, EventArgs e)
        {
            CfiltroTipo.Enabled = CBtipo.Checked;
        }
    }
}
