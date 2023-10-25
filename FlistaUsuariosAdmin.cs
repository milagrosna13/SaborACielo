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

            BeditarUs.Visible = false;

            Cempleado empleado = new Cempleado();
            bool resultado = empleado.CargarEmpleados(DGlistaUsuarios);
            Cproducto.AgregarColumnasBoton(DGlistaUsuarios);
        }

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
            TBapellidoUsuario.Clear();
            TBnomUsuario.Clear();
            TBnombreUsuario.Clear();
            TBdireccion.Clear();
            TBtelefono.Clear();
            TBdniUsuario.Clear();
            TBdni.Clear();
            CBusuarioTipo.SelectedIndex = -1;
            CBtipoUsuario.SelectedIndex = -1;
            TBemail.Clear();
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
                        else
                        {
                            // Actualizar la tabla solo con el registro de empleados
                            Cempleado empleado = new Cempleado();
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

        private void DGlistaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGlistaUsuarios.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                // Obtiene el ID del empleado seleccionado desde la fila en la que se hizo clic
                int empleadoID = int.Parse(DGlistaUsuarios.Rows[e.RowIndex].Cells["DNI"].Value.ToString());

                // Llama a la clase Cempleado para cargar los datos en el formulario de edición
                Cempleado empleadoHandler = new Cempleado();
                DataTable empleadoYUsuarioData = empleadoHandler.ObtenerEmpleadoYUsuario(empleadoID);

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

                    // Rellena otros campos

                    if (row["nom_usuario"] != DBNull.Value)
                    {
                        // Si el usuario existe, muestra y rellena los campos de usuario

                        TBusuario.Text = row["nom_usuario"].ToString();
                        if (row["contrasenia"] != DBNull.Value)
                        {
                            byte[] encryptedPassword = (byte[])row["contrasenia"];
                            byte[] salt = (byte[])row["salt"];

                            // Pasar la contraseña proporcionada por el usuario como argumento
                            string password = empleadoHandler.DesencriptarContraseña(encryptedPassword, salt, TBcontrasenia.Text);

                            if (!string.IsNullOrEmpty(password))
                            {
                                TBcontrasenia.Text = password;
                            }
                            else
                            {
                                // No se pudo desencriptar correctamente la contraseña, manejar el error o mostrar un mensaje.
                            }
                        }




                        // Asigna la descripción del tipo de usuario al ComboBox
                        CBtipoUsuario.Visible = false;
                        CBtipoEditar.Text = row["desc_tipoUs"].ToString();
                    }
                }
            }
        }




    }
}