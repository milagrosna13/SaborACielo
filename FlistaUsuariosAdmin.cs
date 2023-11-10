using SaborAcielo.datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace SaborAcielo
{
    public partial class FlistaUsuariosAdmin : Form
    {
        public FlistaUsuariosAdmin()
        {
            InitializeComponent();
            CBeditarUs.Visible = false;
            BeditarUs.Visible = false;
            CBeditarContrasenia.Visible = false;
            CBtipoEditar.Visible = false;
            BcancelarEditar.Visible = false;
            Cempleado empleado = new Cempleado();
            bool resultado = empleado.CargarEmpleados(DGlistaUsuarios);
            Cproducto.AgregarColumnasBoton(DGlistaUsuarios);
            ComboBoxNombre.AutoCompleteCustomSource = empleado.ObtenerSugerenciasNombre();
            CBoxApellido.AutoCompleteCustomSource = empleado.ObtenerSugerenciasApellido();
            InicializarDateTimePicker();
        }

        private Cempleado empleado = new Cempleado();

        private void TBdniUsuario_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TBnomUsuario_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void TBapeUsuario_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void TBdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBtelefono_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private string rutaImagenSeleccionada;
        private void limpiar()
        {
            TBapeUsuario.Clear();

            TBnomUsuario.Clear();

            TBdireccion.Clear();
            TBtelefono.Clear();
            TBdniUsuario.Clear();

            CBusuarioTipo.SelectedIndex = -1;
            CBtipoEditar.SelectedIndex = -1;
            TBusuario.Clear();
            TBcontrasenia.Clear();
            CBasignaUsuario.Checked = false;
            TBemail.Clear();
            PBusuario.Image = Properties.Resources.EmpleadosInicio;

        }

        private void BcancelProdu_Click(object sender, EventArgs e)
        {
            limpiar();
        }


        private void BagregarUs_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBdniUsuario.Text) || string.IsNullOrEmpty(TBnomUsuario.Text) || string.IsNullOrEmpty(TBapeUsuario.Text) || string.IsNullOrEmpty(TBtelefono.Text) || string.IsNullOrWhiteSpace(TBdireccion.Text))
            {
                MessageBox.Show("Debe completar los campos obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var res = MessageBox.Show("¿Desea guardar los datos del empleado: " + TBnomUsuario.Text + "", "Guardar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    byte[] imagenBytes;
                    if (!string.IsNullOrEmpty(rutaImagenSeleccionada))
                    {
                        // Si se ha seleccionado una imagen, conviérte a bytes
                        imagenBytes = ConvertirImagenABytes(rutaImagenSeleccionada);
                    }
                    else
                    {
                        // Si no se ha seleccionado una imagen, carga la imagen por defecto en forma de bytes
                        imagenBytes = ImageToByteArray((Bitmap)PBusuario.Image);
                    }


                    // Agregar el empleado
                    bool exitoEmpleado = Cempleado.AgregarEmpleado(Convert.ToInt32(TBdniUsuario.Text), TBnomUsuario.Text, TBapeUsuario.Text, TBemail.Text, Convert.ToInt32(TBtelefono.Text), TBdireccion.Text, Convert.ToDateTime(dtFecha.Text), imagenBytes, DGlistaUsuarios);

                    if (exitoEmpleado)
                    {
                        // Si se agregó el empleado con éxito, verifica si se debe agregar un usuario
                        if (CBasignaUsuario.Checked)
                        {
                            if (CBusuarioTipo.SelectedIndex == -1)
                            {
                                MessageBox.Show("Debe completar los campos obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {

                                bool exitoUsuario = Cempleado.CrearUsuario(Convert.ToInt32(TBdniUsuario.Text), TBusuario.Text, TBcontrasenia.Text, CBusuarioTipo.SelectedIndex + 1);

                                if (exitoUsuario)
                                {
                                    // Actualizar la tabla con el registro de usuarios
                                    Cempleado empleado = new Cempleado();
                                    bool resultado = empleado.CargarEmpleados(DGlistaUsuarios);
                                    MessageBox.Show("Empleado y usuario agregados con éxito", "Agregar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Error al agregar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            // Actualizar la tabla solo con el registro de empleados

                            bool resultado = empleado.CargarEmpleados(DGlistaUsuarios);
                            MessageBox.Show("Empleado agregado con éxito", "Agregar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    limpiar();
                }
                else
                {
                    limpiar();
                }
            }
        }

        private byte[] ImageToByteArray(Bitmap image)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, ImageFormat.Png);
                return stream.ToArray();
            }
        }


        private void CBasignaUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (CBasignaUsuario.Checked)
            {
                // Si el CheckBox está marcado, habilita los TextBox para nombre de usuario y contraseña
                CBusuarioTipo.Enabled = true;
                TBusuario.Enabled = true;
                TBcontrasenia.Enabled = true;
            }
            else
            {
                // Si el CheckBox no está marcado, deshabilita los TextBox para nombre de usuario y contraseña
                CBusuarioTipo.Enabled = false;
                TBusuario.Enabled = false;
                TBcontrasenia.Enabled = false;

                TBusuario.Text = "";
                TBcontrasenia.Text = "";
                CBusuarioTipo.SelectedIndex = -1;
            }
        }

        private byte[] ConvertirImagenABytes(string rutaImagen)
        {
            byte[] imagenBytes = null;

            try
            {
                using (FileStream fs = new FileStream(rutaImagen, FileMode.Open, FileAccess.Read))
                {
                    imagenBytes = new byte[fs.Length];
                    fs.Read(imagenBytes, 0, Convert.ToInt32(fs.Length));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al convertir la imagen a bytes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return imagenBytes;
        }

        private bool EsArchivoImagen(string rutaArchivo)
        {
            try
            {
                using (Image img = Image.FromFile(rutaArchivo))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        private void BexaminarImUs_Click_1(object sender, EventArgs e)
        {
            // Crear un cuadro de diálogo para seleccionar archivos
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configurar el cuadro de diálogo para aceptar solo imágenes
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";
            openFileDialog.Title = "Seleccionar una imagen";

            // Mostrar el cuadro de diálogo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string rutaImagen = openFileDialog.FileName;

                // Verificar si el archivo es una imagen
                if (EsArchivoImagen(rutaImagen))
                {
                    // Cargar la imagen en el PictureBox
                    PBusuario.Image = Image.FromFile(rutaImagen);

                    rutaImagenSeleccionada = rutaImagen;


                }
                else
                {
                    MessageBox.Show("El archivo seleccionado no es una imagen válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private int dniEmpleadoSeleccionado;

        private void DGlistaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGlistaUsuarios.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                BagregarUs.Visible = false;
                BeditarUs.Visible = true;
                BcancelarEditar.Visible = true;
                BcancelUs.Visible = false;
                // Obtiene el ID del empleado seleccionado desde la fila en la que se hizo clic
                dniEmpleadoSeleccionado = int.Parse(DGlistaUsuarios.Rows[e.RowIndex].Cells["DNI"].Value.ToString());

                // Llama a la clase Cempleado para cargar los datos en el formulario de edición
                Cempleado empleadoHandler = new Cempleado();
                DataTable empleadoYUsuarioData = empleadoHandler.ObtenerEmpleadoYUsuario(dniEmpleadoSeleccionado);

                if (empleadoYUsuarioData.Rows.Count > 0)
                {

                    DataRow row = empleadoYUsuarioData.Rows[0];

                    // Rellena los campos del formulario con los datos obtenidos
                    TBdniUsuario.Text = row["dni_empleado"].ToString();
                    TBnomUsuario.Text = row["nombre"].ToString();
                    TBapeUsuario.Text = row["apellido"].ToString();
                    TBemail.Text = row["mail"].ToString();
                    TBdireccion.Text = row["direccion"].ToString();
                    TBtelefono.Text = row["telefono"].ToString();
                    DateTime fechaProducto = (DateTime)row["fecha_ingreso"];
                    dtFecha.Value = fechaProducto;
                    empleadoHandler.MostrarImagenEnPictureBox(dniEmpleadoSeleccionado, PBusuario);



                    if (row["nom_usuario"] != DBNull.Value)
                    {
                        // Si el usuario existe, muestra y rellena los campos de usuario
                        CBasignaUsuario.Visible = false;
                        CBtipoEditar.Visible = true;
                       
                        CBeditarUs.Visible = true;
                        TBusuario.Text = row["nom_usuario"].ToString();
                        if (row["contrasenia"] != DBNull.Value)
                        {
                            CBeditarContrasenia.Visible = true;


                        }
                    }
                    else
                    {
                        CBeditarUs.Visible = false;
                        CBasignaUsuario.Visible = true;
                        CBtipoEditar.Visible = false;
                        TBusuario.Enabled = false;
                        TBusuario.Clear();
                        CBeditarContrasenia.Visible = false;
                    }




                    // Asigna la descripción del tipo de usuario al ComboBox

                    CBtipoEditar.Text = row["desc_tipoUs"].ToString();
                }
            }
            // Verificar si se hizo clic en una celda de botón "Eliminar"
            if (e.ColumnIndex == DGlistaUsuarios.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                // Obtener el valor de la columna "Estado" en la fila actual como cadena
                string estadoStr = DGlistaUsuarios.Rows[e.RowIndex].Cells["Estado"].Value.ToString();

                // Verificar si el estado es "Activo" para permitir la eliminación
                if (estadoStr.Equals("Activo", StringComparison.OrdinalIgnoreCase))
                {
                    // Obtener el ID del producto
                    int idProdu = Convert.ToInt32(DGlistaUsuarios.Rows[e.RowIndex].Cells["DNI"].Value);

                    // Mostrar un mensaje de confirmación
                    var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este empleado?",
                                                       "Confirmar Eliminación",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question);

                    if (confirmResult == DialogResult.Yes)
                    {
                        // El usuario confirmó la eliminación, proceder con la eliminación
                        Cempleado.EliminarEmpleado(idProdu);

                        // Volver a cargar los datos en el DataGridView
                        Cempleado empleado = new Cempleado();
                        bool resultado = empleado.CargarEmpleados(DGlistaUsuarios);
                    }
                }
                else
                {
                    // Mostrar un mensaje indicando que no se puede eliminar un producto inactivo
                    MessageBox.Show("No se puede eliminar un usuario inactivo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
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

        private void BeditarUs_Click(object sender, EventArgs e)
        {
            int empleadoID = int.Parse(TBdniUsuario.Text);
            Cempleado empleadoHandler = new Cempleado();
            DateTime nuevaFecha = dtFecha.Value;
            // Lógica para obtener la imagen editada
            byte[] nuevaImagen;
            if (!string.IsNullOrEmpty(rutaImagenSeleccionada))
            {
                nuevaImagen = ConvertirImagenABytes(rutaImagenSeleccionada);
                rutaImagenSeleccionada = string.Empty;
            }
            else
            {
                nuevaImagen = empleadoHandler.ObtenerImagenDesdeBaseDeDatos(empleadoID);
            }
            if (string.IsNullOrWhiteSpace(TBnomUsuario.Text) || string.IsNullOrWhiteSpace(TBapeUsuario.Text) ||
      string.IsNullOrWhiteSpace(TBemail.Text) || string.IsNullOrWhiteSpace(TBtelefono.Text) ||
      string.IsNullOrWhiteSpace(TBdireccion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (empleadoHandler.EditarEmpleado(empleadoID, TBnomUsuario.Text, TBapeUsuario.Text, TBemail.Text, Convert.ToInt32(TBtelefono.Text), TBdireccion.Text, nuevaFecha, nuevaImagen))
            {
                if (CBeditarUs.Checked) // Si el usuario se está editando
                {
                    bool tieneUsuario = empleadoHandler.EmpleadoTieneUsuario(empleadoID);

                    if (tieneUsuario)
                    {
                        // El empleado tiene usuario, verifica si se desea editar
                        string nombreUsuario = TBusuario.Text; // Obtener el nombre de usuario desde el formulario
                        bool editarUsuario = CBeditarUs.Checked;
                        bool cambiarContrasenia = CBeditarContrasenia.Checked;
                        byte[] nuevaContrasenia = null; // Inicializar nueva contraseña

                        if (editarUsuario)
                        {
                            TBcontrasenia.Enabled = true;


                            if (cambiarContrasenia)
                            {
                              

                                string nuevaContraseniaTexto = TBcontrasenia.Text; // Obtener el nuevo valor de la contraseña como string

                                if (string.IsNullOrWhiteSpace(nuevaContraseniaTexto))
                                {
                                    MessageBox.Show("Error: la contraseña no puede estar vacía.");
                                    return;
                                }

                                // Convertir la nueva contraseña a un array de bytes usando codificación UTF-8
                                nuevaContrasenia = Encoding.UTF8.GetBytes(nuevaContraseniaTexto);
                            }


                            if (empleadoHandler.EditarUsuario(empleadoID, nombreUsuario, CBtipoEditar.SelectedIndex + 1, cambiarContrasenia, nuevaContrasenia))
                            {
                                MessageBox.Show("Empleado y usuario editados con éxito.");
                                bool resultado = empleadoHandler.CargarEmpleados(DGlistaUsuarios);
                                CBasignaUsuario.Visible = true;
                                BagregarUs.Visible = true;
                                BeditarUs.Visible = false;
                                CBeditarUs.Visible = false;
                                BcancelarEditar.Visible = false;
                                BcancelUs.Visible = true;
                                limpiar();
                            }
                            else
                            {
                                MessageBox.Show("Error al editar el usuario.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Empleado editado con éxito.");
                            bool resultado = empleadoHandler.CargarEmpleados(DGlistaUsuarios);
                            BagregarUs.Visible = true;
                            BeditarUs.Visible = false;
                            CBeditarUs.Visible = false;
                            CBasignaUsuario.Visible = true;
                            BcancelarEditar.Visible = false;
                            BcancelUs.Visible = true;
                            limpiar();
                        }
                    }

                }
                else
                {
                    if (CBasignaUsuario.Checked)
                    {
                        if (CBusuarioTipo.SelectedItem != null) // Verifica si se ha seleccionado un elemento en el ComboBox
                        {
                            bool exitoUsuario = Cempleado.CrearUsuario(empleadoID, TBusuario.Text, TBcontrasenia.Text, CBusuarioTipo.SelectedIndex + 1);

                            if (exitoUsuario)
                            {
                                bool resultado = empleadoHandler.CargarEmpleados(DGlistaUsuarios);
                                MessageBox.Show("Empleado y usuario agregados con éxito", "Agregar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CBasignaUsuario.Visible = true;
                                BagregarUs.Visible = true;
                                BeditarUs.Visible = false;
                                CBeditarUs.Visible = false;
                                BcancelarEditar.Visible = false;
                                BcancelUs.Visible = true;
                                limpiar();
                            }
                            else
                            {
                                MessageBox.Show("Error al agregar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar un tipo de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                MessageBox.Show("Empleado editado con éxito.");
                        empleadoHandler.CargarEmpleados(DGlistaUsuarios);
                CBasignaUsuario.Visible = true;
                BagregarUs.Visible = true;
                        BeditarUs.Visible = false;
                CBeditarUs.Visible = false;
                BcancelarEditar.Visible = false;
                BcancelUs.Visible = true;
                limpiar();
            }



        }
             


        private void CBeditarContrasenia_CheckedChanged(object sender, EventArgs e)
        {
            TBcontrasenia.Enabled = CBeditarContrasenia.Checked;
            TBcontrasenia.Text = "";
        }

        private void CBeditarUs_CheckedChanged(object sender, EventArgs e)
        {
            CBtipoEditar.Enabled = CBeditarUs.Checked;
            TBusuario.Enabled = CBeditarUs.Checked;
        }

        private void BbuscarUsuario_Click(object sender, EventArgs e)
        {
            // Obtiene los parámetros de búsqueda desde la interfaz de usuario
            int dni = 0;
            string nombre = string.Empty;
            string apellido = string.Empty;
            DateTime? fecha = CBfecha.Checked ? DTfechaIng.Value : (DateTime?)null;

            if (CBnombre.Checked && !string.IsNullOrEmpty(ComboBoxNombre.Text))
            {
                nombre = ComboBoxNombre.Text;
            }

            if (CBapellido.Checked  && !string.IsNullOrEmpty(CBoxApellido.Text))
            {
                apellido = CBoxApellido.Text;
            }
            if (CBdni.Checked && !string.IsNullOrEmpty(TBoxDni.Text)) { dni = Convert.ToInt32(TBoxDni.Text); }

            // Verifica si el checkbox "Todos los productos" está marcado
            if (CBtodosUsuarios.Checked)
            {
                dni = 0;
                nombre = string.Empty;  // Ignora la búsqueda por nombre
                apellido = string.Empty;    // Ignora la búsqueda por tipo
                fecha = null;           // Ignora la búsqueda por fecha
            }

            // Llama al método de la clase CProducto para obtener los resultados
            var empleados = Cempleado.ObtenerEmpleados(nombre, apellido,dni, fecha);

            // Muestra los resultados en el DataGridView
            DGlistaUsuarios.DataSource = empleados;
        }

        private void CBtodosUsuarios_CheckedChanged(object sender, EventArgs e)
        {
            if (CBtodosUsuarios.Checked == true)
            {
                CBnombre.Checked = false;
                CBapellido.Checked = false;
                CBdni.Checked = false;
                CBfecha.Checked = false;
            }
        }

        private void ComboBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void ComboBoxNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TBoxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void BcancelarEditar_Click(object sender, EventArgs e)
        {
           
           
            // Llama a la clase Cempleado para cargar los datos en el formulario de edición
            Cempleado empleadoHandler = new Cempleado();
            DataTable empleadoYUsuarioData = empleadoHandler.ObtenerEmpleadoYUsuario(dniEmpleadoSeleccionado);

            if (empleadoYUsuarioData.Rows.Count > 0)
            {

                DataRow row = empleadoYUsuarioData.Rows[0];

                // Rellena los campos del formulario con los datos obtenidos
                TBdniUsuario.Text = row["dni_empleado"].ToString();
                TBnomUsuario.Text = row["nombre"].ToString();
                TBapeUsuario.Text = row["apellido"].ToString();
                TBemail.Text = row["mail"].ToString();
                TBdireccion.Text = row["direccion"].ToString();
                TBtelefono.Text = row["telefono"].ToString();
                DateTime fechaProducto = (DateTime)row["fecha_ingreso"];
                dtFecha.Value = fechaProducto;
                empleadoHandler.MostrarImagenEnPictureBox(dniEmpleadoSeleccionado, PBusuario);



                if (row["nom_usuario"] != DBNull.Value)
                {
                    // Si el usuario existe, muestra y rellena los campos de usuario
                    CBasignaUsuario.Visible = false;
                    CBtipoEditar.Visible = true;

                    CBeditarUs.Visible = true;
                    TBusuario.Text = row["nom_usuario"].ToString();
                    if (row["contrasenia"] != DBNull.Value)
                    {
                        CBeditarContrasenia.Visible = true;


                    }
                }
            }
            }
    }
}