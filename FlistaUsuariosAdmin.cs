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

namespace SaborAcielo
{
    public partial class FlistaUsuariosAdmin : Form
    {
        public FlistaUsuariosAdmin()
        {
            InitializeComponent();
            
            BeditarUs.Visible = false;
            Cempleado empleado= new Cempleado();
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
            // Cempleado em = new CEmpleado();

            if (string.IsNullOrWhiteSpace(TBdniUsuario.Text) || string.IsNullOrEmpty(TBnomUsuario.Text) ||  string.IsNullOrEmpty(TBapeUsuario.Text) || string.IsNullOrEmpty(TBtelefono.Text) || string.IsNullOrWhiteSpace(TBdireccion.Text) )
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
                        // Si se ha seleccionado una imagen, conviértela a bytes
                        imagenBytes = ConvertirImagenABytes(rutaImagenSeleccionada);
                    }
                    else
                    {
                        // Si no se ha seleccionado una imagen, carga la imagen por defecto en forma de bytes
                        imagenBytes = ImageToByteArray((Bitmap)PBusuario.Image); // Reemplaza "ruta_imagen_por_defecto.jpg" con la ruta de tu imagen por defecto
                    }
                   
                    bool exito = Cempleado.AgregarEmpleado(Convert.ToInt32(TBdniUsuario.Text),TBnomUsuario.Text, TBapeUsuario.Text, TBemail.Text, Convert.ToInt32(TBtelefono.Text), TBdireccion.Text, Convert.ToDateTime(dtFecha.Text), imagenBytes, DGlistaUsuarios);


                    if (exito) //se actualiza la tabla con el registro cargado
                    {
                        Cempleado empleado = new Cempleado();
                        bool resultado = empleado.CargarEmpleados(DGlistaUsuarios);
                        MessageBox.Show("Empleado agregado con éxito", "Agregar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                image.Save(stream, ImageFormat.Png); // Cambia a otro formato si es necesario
                return stream.ToArray();
            }
        }




        private void BeditarUs_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBnomUsuario.Text) || string.IsNullOrEmpty(TBapeUsuario.Text) || string.IsNullOrWhiteSpace(TBdniUsuario.Text))
            {
                MessageBox.Show("Debe completar los campos obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataGridViewRow row = DGlistaUsuarios.Rows[DGlistaUsuarios.CurrentCell.RowIndex];
                row.Cells["nom_em"].Value = TBnomUsuario.Text;
                row.Cells["ape_em"].Value = TBapeUsuario.Text;
                row.Cells["dni_em"].Value = TBdniUsuario.Text;
                row.Cells["email_em"].Value = TBemail.Text;
                row.Cells["dire_em"].Value = TBdireccion.Text;
                row.Cells["tel_em"].Value = TBtelefono.Text;
                row.Cells["perfil_em"].Value = CBusuarioTipo.SelectedItem?.ToString();
                MessageBox.Show("Usuario editado con exito", "Editar", MessageBoxButtons.OK);
                limpiar();
                BagregarUs.Visible = true;

            }
        }

        private void DGlistaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DGlistaUsuarios.Rows[e.RowIndex];
            DataGridViewCell nombreCell = row.Cells["nom_em"];
            DataGridViewCell editarCell = row.Cells["editar_em"];
            DataGridViewCell eliminarCell = row.Cells["eliminar_em"];

            if (string.IsNullOrWhiteSpace(Convert.ToString(nombreCell.Value)))
            {
                editarCell.ReadOnly = true;
            }
            else
            {
                editarCell.ReadOnly = false;
                eliminarCell.ReadOnly = false;

                if (e.RowIndex >= 0 && e.ColumnIndex == DGlistaUsuarios.Columns["editar_em"].Index)
                {
                    var msg = MessageBox.Show("Desea editar el empleado?", "Confirmar editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {

                        BagregarUs.Visible = false;
                        BeditarUs.Visible = true;
                        TBnomUsuario.Text = row.Cells["nom_em"].Value.ToString();
                        TBapeUsuario.Text = row.Cells["ape_em"].Value.ToString();
                        TBdniUsuario.Text = row.Cells["dni_em"].Value.ToString();
                        TBemail.Text = row.Cells["email_em"].Value.ToString();
                        TBtelefono.Text = row.Cells["tel_em"].Value.ToString();
                        TBdireccion.Text = row.Cells["dire_em"].Value.ToString();
                        if (CBtipoUsuario.SelectedIndex != -1)
                        {
                            CBusuarioTipo.SelectedItem = row.Cells["perfil_em"].Value.ToString();
                        }
                    }
                }

                if (e.RowIndex >= 0 && e.ColumnIndex == DGlistaUsuarios.Columns["eliminar_em"].Index)
                {
                    var msg = MessageBox.Show("Desea eliminar el empleado?", "Confirmar eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        row.Cells["estado_em"].Value = "Inactivo";
                    }
                }
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
    }
}