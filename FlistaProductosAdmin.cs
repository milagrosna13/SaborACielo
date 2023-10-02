using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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


namespace SaborAcielo
{
    public partial class FlistaProductosAdmin : Form
    {
        //private readonly string connectionString = ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString;
        //private readonly SqlDataAdapter dataAdapter;
        //private readonly DataTable dataTable;
        public FlistaProductosAdmin()
        {
            InitializeComponent();
            BeditarProd.Visible = false;
            Cproducto producto = new Cproducto();
            bool resultado = producto.CargarProductos(DGlistaProductos);
            Cproducto.AgregarColumnasBoton(DGlistaProductos);

        }

        private void limpiarTextBox()
        {
            TBnomProdu.Clear();
            TBdetalle.Clear();
            TBprecio.Clear();
            TBcantidadProdu.Clear();
            CtipoProd.Text = "";
            PBproducto.Image = null;
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

            if (string.IsNullOrWhiteSpace(TBnomProdu.Text) || string.IsNullOrEmpty(TBprecio.Text) || string.IsNullOrWhiteSpace(TBcantidadProdu.Text) || string.IsNullOrEmpty(rutaImagenSeleccionada))
            {
                MessageBox.Show("Debe completar los campos obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var res = MessageBox.Show("¿Desea guardar los datos del producto: " + TBnomProdu.Text + "", "Guardar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    byte[] imagenBytes = ConvertirImagenABytes(rutaImagenSeleccionada);
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

        private void DGlistaProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

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

        private void TBnomProdu_TextChanged(object sender, EventArgs e) { }
        int pos;

        //editar
        private void DGlistaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DGlistaProductos.Rows[e.RowIndex];
            DataGridViewCell nombreCell = row.Cells["nombre"];
            DataGridViewCell editarCell = row.Cells["Editar_produ"];

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn columna = DGlistaProductos.Columns[e.ColumnIndex];
                if (columna.Name != "Editar_produ")
                {
                    // Desactivar el evento Click en celdas que no sean del tipo botón
                    DGlistaProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(Convert.ToString(nombreCell.Value)))
                    {
                        // Desactivar el botón de eliminar si la fila está vacía
                        editarCell.ReadOnly = true;
                    }
                    else
                    {
                        limpiarTextBox();
                        editarCell.ReadOnly = false;
                        BagregarProdu.Visible = false;
                        BeditarProd.Visible = true;
                        //metodo editar
                    }
                }
            }
        }
        private int idProductoSeleccionado = -1;
        private void BeditarProd_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado != -1)
            {
               
               
                
                DateTime nuevaFecha = dtFecha.Value;
                // Lógica para obtener la imagen editada
                byte[] nuevaImagen = ConvertirImagenABytes(rutaImagenSeleccionada); 

                // Actualiza el producto en la base de datos
                bool exito = Cproducto.ActualizarProducto(idProductoSeleccionado, TBnomProdu.Text, TBdetalle.Text, Convert.ToDecimal(TBprecio.Text), Convert.ToInt32(TBcantidadProdu.Text), nuevaFecha, nuevaImagen);

                if (exito)
                {
                    // Actualización exitosa, mostrar un mensaje de éxito
                    MessageBox.Show("Producto actualizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Vuelve a cargar los datos en el DataGridView después de la edición
                    Cproducto producto = new Cproducto();
                    bool resultado = producto.CargarProductos(DGlistaProductos);
                }
                else
                {
                    // Hubo un error en la actualización, muestra un mensaje de error
                    MessageBox.Show("Error al actualizar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Restablece el formulario al modo de inserción
                BeditarProd.Visible = false;
                BagregarProdu.Visible = true;
                limpiarTextBox(); // Limpia los campos del formulario
            }
        }  
           

        private void BcancelProdu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DGlistaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGlistaProductos.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                int idprodu = Convert.ToInt32(DGlistaProductos.Rows[e.RowIndex].Cells["ID"].Value);

                //se cargan los campos del producto
                Cproducto producto = new Cproducto();
                DataRow detalle = producto.obtenerProducto(idprodu);

                if (detalle != null)
                {
                    TBnomProdu.Text = detalle["nombre_produ"].ToString();
                    TBprecio.Text = detalle["precio"].ToString();
                    TBdetalle.Text = detalle["detalle"].ToString();
                    CtipoProd.SelectedIndex = Convert.ToInt32(detalle["id_tipoProdu"].ToString());
                    TBcantidadProdu.Text = detalle["stock"].ToString();
                }

                BagregarProdu.Visible = false;
                BeditarProd.Visible = true;

            }
            // Verificar si se hizo clic en una celda de botón "Eliminar"
            if (e.ColumnIndex == DGlistaProductos.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                // Obtener el valor de la columna "Estado" en la fila actual
                bool estado = Convert.ToBoolean(DGlistaProductos.Rows[e.RowIndex].Cells["Estado"].Value);

                // Verificar si el estado es 0 (inhabilitado)
                if (!estado)
                {
                    // Mostrar un mensaje indicando que no se puede eliminar un producto inhabilitado
                    MessageBox.Show("No se puede eliminar un producto dado de baja.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir del método sin realizar ninguna acción
                }

                // Si el estado es 1 (habilitado), continuar con la eliminación
                int idprodu = Convert.ToInt32(DGlistaProductos.Rows[e.RowIndex].Cells["ID"].Value);

                // Mostrar un mensaje de confirmación
                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este producto?",
                                                   "Confirmar Eliminación",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // El usuario confirmó la eliminación, proceder con la eliminación
                    Cproducto.EliminarProducto(idprodu);

                    // Volver a cargar los datos en el DataGridView
                    Cproducto producto = new Cproducto();
                    bool resultado = producto.CargarProductos(DGlistaProductos);
                }
                // Si el usuario elige "No" en el cuadro de diálogo, no se realizará ninguna acción.
            }
        }

       

        private void FlistaProductosAdmin_Load(object sender, EventArgs e)
        {

          

        }

       
            

       
    } 
}
