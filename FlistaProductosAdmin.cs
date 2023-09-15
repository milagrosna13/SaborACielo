using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SaborAcielo
{
    public partial class FlistaProductosAdmin : Form
    {
        public FlistaProductosAdmin()
        {
            InitializeComponent();
            BeditarProd.Visible = false;
        }




        private void limpiarTextBox()
        {
            TBnomProdu.Text = "";
            TBcantidadProdu.Text = "";
            TBtipoproducto.Text = "";
            TBprecio.Text = "";
            PBproducto.Image = null;
        }

        private void TBnomProdu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TBtipoproducto_KeyPress(object sender, KeyPressEventArgs e)
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
            if (string.IsNullOrWhiteSpace(TBnomProdu.Text) || string.IsNullOrEmpty(TBtipoproducto.Text) ||
               string.IsNullOrEmpty(TBprecio.Text) || string.IsNullOrWhiteSpace(TBcantidadProdu.Text))
            {
                MessageBox.Show("Debe completar los campos obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var res = MessageBox.Show("¿Desea guardar los datos del producto: " + TBnomProdu.Text + "", "Guardar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {


                    string nombre = TBnomProdu.Text;
                    string tipo = TBtipoproducto.Text;
                    string precio = TBprecio.Text;
                    string cantidad = TBcantidadProdu.Text;

                    // Obtener la imagen del PictureBox
                    Image imagen = PBproducto.Image;

                    // Agregar una nueva fila al DataGridView
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.Cells.Add(new DataGridViewTextBoxCell { Value = nombre });
                    fila.Cells.Add(new DataGridViewTextBoxCell { Value = tipo });
                    fila.Cells.Add(new DataGridViewTextBoxCell { Value = precio });
                    fila.Cells.Add(new DataGridViewTextBoxCell { Value = cantidad });
                    // Cargar la imagen en una celda de la columna de imágenes
                    DataGridViewImageCell imagenCell = new DataGridViewImageCell();
                    imagenCell.Value = imagen;
                    fila.Cells.Add(imagenCell);

                    // Agregar la fila al DataGridView
                    DGlistaProductos.Rows.Add(fila);



                    MessageBox.Show("Producto agregado con éxito", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpiarTextBox();   
                }
                else
                {
                    limpiarTextBox();
                }

            }
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
                }
                else
                {
                    MessageBox.Show("El archivo seleccionado no es una imagen válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TBnomProdu_TextChanged(object sender, EventArgs e)
        {

        }
        int pos;
        private void DGlistaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void DGlistaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DGlistaProductos.Rows[e.RowIndex];
            DataGridViewCell nombreCell = row.Cells["desc_producto"];
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

                        pos = DGlistaProductos.CurrentRow.Index;
                        TBnomProdu.Text = DGlistaProductos[0, pos].Value.ToString();
                        TBtipoproducto.Text = DGlistaProductos[1, pos].Value.ToString();
                        TBprecio.Text = DGlistaProductos[2, pos].Value.ToString();
                        TBcantidadProdu.Text = DGlistaProductos[3, pos].Value.ToString();
                        

                    }
                }
            }
        }

        private void BeditarProd_Click(object sender, EventArgs e)
        {
            DGlistaProductos[0, pos].Value = TBnomProdu.Text;
            DGlistaProductos[1, pos].Value = TBtipoproducto.Text;
            DGlistaProductos[2, pos].Value = TBprecio.Text;
            DGlistaProductos[3, pos].Value = TBcantidadProdu.Text;

            BeditarProd.Visible = false;
            BagregarProdu.Visible = true;
            limpiarTextBox();
        }

        private void BcancelProdu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
