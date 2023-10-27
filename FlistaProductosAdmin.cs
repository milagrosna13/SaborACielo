using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Collections;
using SaborAcielo.datos;
using System.IO;
using System.Security.Cryptography;


namespace SaborAcielo
{
    public partial class FlistaProductosAdmin : Form
    {
        private List<DateTime> fechasDisponibles = new List<DateTime>();
        public FlistaProductosAdmin()
        {
            InitializeComponent();
            BcancelarEditar.Visible = false;
            BeditarProd.Visible = false;
            Cproducto producto = new Cproducto();
            CargarFechasDisponibles();
            InicializarComboBoxes();
            bool resultado = producto.CargarProductos(DGlistaProductos);
            Cproducto.AgregarColumnasBoton(DGlistaProductos);
            
        }

        private void limpiarTextBox()
        {
            TBnomProdu.Clear();
            TBdetalle.Clear();
            TBprecio.Clear();
            TBcantidadProdu.Clear();
            CtipoProd.SelectedIndex = -1;
            PBproducto.Image = Properties.Resources.ProductosInicio;
        }
        private string rutaImagenSeleccionada;
        private void TBnomProdu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        private void TBcantidadProdu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TBprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
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

        private void BagregarProdu_Click_1(object sender, EventArgs e)
        {
            // Cproducto produ = new Cproducto();
          

            if (string.IsNullOrWhiteSpace(TBnomProdu.Text) || string.IsNullOrEmpty(TBprecio.Text) || string.IsNullOrWhiteSpace(TBcantidadProdu.Text) || CtipoProd.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar los campos obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var res = MessageBox.Show("¿Desea guardar los datos del producto: " + TBnomProdu.Text + "", "Guardar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        imagenBytes = ImageToByteArray(Properties.Resources.ProductosInicio); // Usar la imagen por defecto
                        
                    }
                    rutaImagenSeleccionada = string.Empty;
                    bool exito = Cproducto.AgregarProducto(TBnomProdu.Text, CtipoProd.SelectedIndex + 1, Convert.ToDecimal(TBprecio.Text), TBdetalle.Text, TBcantidadProdu.Text, Convert.ToDateTime(dtFecha.Text), imagenBytes, DGlistaProductos);


                    if (exito) //se actualiza la tabla con el registro cargado
                    {
                        Cproducto producto = new Cproducto();
                        bool resultado = producto.CargarProductos(DGlistaProductos);
                        MessageBox.Show("Producto agregado con éxito", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    limpiarTextBox();
                }
                else
                {
                    limpiarTextBox();
                }

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

      
        private byte[] ImageToByteArray(Bitmap image)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, ImageFormat.Png);
                return stream.ToArray();
            }
        }
        private void DGlistaProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }
        // En tu formulario
       
       




        private void BexaminarImProdu_Click_1(object sender, EventArgs e)
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
                    PBproducto.Image = Image.FromFile(rutaImagen);

                    rutaImagenSeleccionada = rutaImagen;


                }
                else
                {
                    MessageBox.Show("El archivo seleccionado no es una imagen válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
       

        private void TBnomProdu_TextChanged(object sender, EventArgs e) { }
        int pos;

        //editar
        
        private void BeditarProd_Click(object sender, EventArgs e)
        {
            Cproducto producto = new Cproducto();
            int idProductoSeleccionado = idprodu;
            byte[] nuevaImagen;
            if (idProductoSeleccionado != -1)
            {
                
                DateTime nuevaFecha = dtFecha.Value;
                // Lógica para obtener la imagen editada
                if (!string.IsNullOrEmpty(rutaImagenSeleccionada))
                {
                    nuevaImagen = ConvertirImagenABytes(rutaImagenSeleccionada);
                    rutaImagenSeleccionada = string.Empty;
                } else
                {
                    nuevaImagen = producto.ObtenerImagenDesdeBaseDeDatos(idProductoSeleccionado);
                }
                bool exito;
                // Actualiza el producto en la base de datos
                if (string.IsNullOrWhiteSpace(TBnomProdu.Text) || string.IsNullOrEmpty(TBprecio.Text) || string.IsNullOrWhiteSpace(TBcantidadProdu.Text))
                {
                    exito = false;
                    MessageBox.Show("Debe completar los campos obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } else
                {

                    exito = Cproducto.ActualizarProducto(idProductoSeleccionado, TBnomProdu.Text, TBdetalle.Text, Convert.ToDecimal(TBprecio.Text), Convert.ToInt32(TBcantidadProdu.Text), nuevaFecha, nuevaImagen); ;
                }
                if (exito)
                {
                    // Actualización exitosa, mostrar un mensaje de éxito
                    MessageBox.Show("Producto actualizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Vuelve a cargar los datos en el DataGridView después de la edición
                   
                    bool resultado = producto.CargarProductos(DGlistaProductos);
                    // Restablece el formulario al modo de inserción
                    BeditarProd.Visible = false;
                    BcancelarEditar.Visible = false;
                    BagregarProdu.Visible = true;
                    BcancelProdu.Visible = true;
                    CtipoProd.Enabled = true;
                    limpiarTextBox(); // Limpia los campos del formulario
                }
                else
                {
                    // Hubo un error en la actualización, muestra un mensaje de error
                    MessageBox.Show("Error al actualizar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

               
            }
            else MessageBox.Show("Error "+idProductoSeleccionado, "");
        }  
           
        private void BcancelProdu_Click(object sender, EventArgs e)
        {
            this.limpiarTextBox();
        }
        int idprodu;
        private void DGlistaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGlistaProductos.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                idprodu = Convert.ToInt32(DGlistaProductos.Rows[e.RowIndex].Cells["ID"].Value);
                
                //se cargan los campos del producto
                Cproducto producto = new Cproducto();
                DataRow detalle = producto.obtenerProducto(idprodu);

                if (detalle != null)
                {                  
                    TBnomProdu.Text = detalle["nombre_produ"].ToString();
                    TBprecio.Text = detalle["precio"].ToString();
                    TBdetalle.Text = detalle["detalle"].ToString();
                    CtipoProd.SelectedIndex = Convert.ToInt32(detalle["id_tipoProdu"].ToString())-1;
                    TBcantidadProdu.Text = detalle["stock"].ToString();
                    DateTime fechaProducto = (DateTime)detalle["fecha"];
                    dtFecha.Value = fechaProducto;
                    producto.MostrarImagenEnPictureBox(idprodu, PBproducto);

                    BagregarProdu.Visible = false;
                    BcancelProdu.Visible = false;
                    BcancelarEditar.Visible = true;
                    BeditarProd.Visible = true;
                    CtipoProd.Enabled = false;
                }

            }
            // Verificar si se hizo clic en una celda de botón "Eliminar"
            if (e.ColumnIndex == DGlistaProductos.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                // Obtener el valor de la columna "Estado" en la fila actual como cadena
                string estadoStr = DGlistaProductos.Rows[e.RowIndex].Cells["Estado"].Value.ToString();

                // Verificar si el estado es "Activo" para permitir la eliminación
                if (estadoStr.Equals("Activo", StringComparison.OrdinalIgnoreCase))
                {
                    // Obtener el ID del producto
                    int idProdu = Convert.ToInt32(DGlistaProductos.Rows[e.RowIndex].Cells["ID"].Value);

                    // Mostrar un mensaje de confirmación
                    var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este producto?",
                                                       "Confirmar Eliminación",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question);

                    if (confirmResult == DialogResult.Yes)
                    {
                        // El usuario confirmó la eliminación, proceder con la eliminación
                        Cproducto.EliminarProducto(idProdu);

                        // Volver a cargar los datos en el DataGridView
                        Cproducto producto = new Cproducto();
                        bool resultado = producto.CargarProductos(DGlistaProductos);
                    }
                }
                else
                {
                    // Mostrar un mensaje indicando que no se puede eliminar un producto inactivo
                    MessageBox.Show("No se puede eliminar un producto inactivo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BcancelarEditar_Click(object sender, EventArgs e)
        {
            Cproducto producto = new Cproducto();
            DataRow detalle = producto.obtenerProducto(idprodu);
            TBnomProdu.Text = detalle["nombre_produ"].ToString();
            TBprecio.Text = detalle["precio"].ToString();
            TBdetalle.Text = detalle["detalle"].ToString();
            CtipoProd.SelectedIndex = Convert.ToInt32(detalle["id_tipoProdu"].ToString()) - 1;
            TBcantidadProdu.Text = detalle["stock"].ToString();
            producto.MostrarImagenEnPictureBox(idprodu, PBproducto);
            
        }

        private void FlistaProductosAdmin_Load(object sender, EventArgs e)
        {
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
