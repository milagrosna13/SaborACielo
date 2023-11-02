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
            Cusuarios usuario = new Cusuarios();
            usuario.CargarUsuarios(DGusuarios);
            ComboBoxNombre.AutoCompleteCustomSource = usuario.ObtenerSugerenciasNombre();
        }
        private void BbuscarUsuario_Click(object sender, EventArgs e)
        {
            // Obtiene los parámetros de búsqueda desde la interfaz de usuario
            int dni = 0;
            string nombre = string.Empty;
            string tipo = string.Empty;
          
            if (CBnombre.Checked)
            {
                nombre = ComboBoxNombre.Text;
            }

            if (CBtipo.Checked)
            {
                tipo = CBoxTipo.Text;
            }
            if (CBdni.Checked) { dni = Convert.ToInt32(TBoxDni.Text); }

            bool mostrarActivos = CBactivos.Checked;
            bool mostrarInactivos = CBinactivos.Checked;


            // Verifica si el checkbox "Todos los productos" está marcado
            if (CBtodosUsuarios.Checked)
            {
                dni = 0;
                nombre = string.Empty;  // Ignora la búsqueda por nombre
                tipo = string.Empty;
                // Ignora la búsqueda por tipo
                mostrarActivos = false;
                mostrarInactivos = false;
            }

            // Llama al método de la clase CProducto para obtener los resultados
            var usuarios = Cusuarios.ObtenerUsuarios(nombre, tipo, dni,mostrarActivos,mostrarInactivos);

            // Muestra los resultados en el DataGridView
            DGusuarios.DataSource = usuarios;
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
