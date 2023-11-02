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
    public partial class FlistaUsuarios : Form
    {
        public FlistaUsuarios()
        {
            InitializeComponent();

            Cempleado empleado = new Cempleado();
            bool resultado = empleado.CargarEmpleados(DGlistaUsuarios);
            ComboBoxNombre.AutoCompleteCustomSource = empleado.ObtenerSugerenciasNombre();
            CBoxApellido.AutoCompleteCustomSource = empleado.ObtenerSugerenciasApellido();
            InicializarDateTimePicker();
        }
        private List<DateTime> fechasDisponibles;
        private void InicializarDateTimePicker()
        {
            Cempleado empleado = new Cempleado();
            fechasDisponibles = empleado.ObtenerFechasDisponibles();

            // Configura el DateTimePicker para mostrar la primera fecha disponible.
            if (fechasDisponibles.Count > 0)
            {
                DTfechaIng.Value = fechasDisponibles[0];
            }

            // Asocia el evento ValueChanged para controlar las fechas seleccionadas.
            DTfechaIng.ValueChanged += new System.EventHandler(this.dateTimePickerFechaIngreso_ValueChanged);
        }
        private void dateTimePickerFechaIngreso_ValueChanged(object sender, EventArgs e)
        {

        }
        private void BbuscarUsuario_Click(object sender, EventArgs e)
        {
            // Obtiene los parámetros de búsqueda desde la interfaz de usuario
            int dni = 0;
            string nombre = string.Empty;
            string apellido = string.Empty;
            DateTime? fecha = CBfecha.Checked ? DTfechaIng.Value : (DateTime?)null;

            if (CBnombre.Checked)
            {
                nombre = ComboBoxNombre.Text;
            }

            if (CBapellido.Checked)
            {
                apellido = CBoxApellido.Text;
            }
            if (CBdni.Checked) { dni = Convert.ToInt32(TBoxDni.Text); }

            // Verifica si el checkbox "Todos los productos" está marcado
            if (CBtodosEmp.Checked)
            {
                dni = 0;
                nombre = string.Empty;  // Ignora la búsqueda por nombre
                apellido = string.Empty;    // Ignora la búsqueda por tipo
                fecha = null;           // Ignora la búsqueda por fecha
            }

            // Llama al método de la clase CProducto para obtener los resultados
            var empleados = Cempleado.ObtenerEmpleados(nombre, apellido, dni, fecha);

            // Muestra los resultados en el DataGridView
            DGlistaUsuarios.DataSource = empleados;
        }
        private void TBoxDni_TextChanged(object sender, EventArgs e)
        {
            Cempleado empleado = new Cempleado();
            int dniBusqueda;

            if (int.TryParse(TBoxDni.Text, out dniBusqueda))
            {
                LBdni.Visible = true;

                DataTable resultados = empleado.BuscarDni(dniBusqueda);

                LBdni.Items.Clear();
                foreach (DataRow row in resultados.Rows)
                {
                    LBdni.Items.Add(row["dni_empleado"].ToString());
                }
            }
            else
            {
                LBdni.Items.Clear();
                LBdni.Visible = false;
            }
        }

        private void LBdni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBdni.SelectedIndex >= 0)
            {
                TBoxDni.Text = LBdni.SelectedItem.ToString();
            }
            LBdni.Visible = false;
        }
    }
}
