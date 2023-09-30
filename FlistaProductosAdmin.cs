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

            if (string.IsNullOrWhiteSpace(TBnomProdu.Text) || string.IsNullOrEmpty(TBprecio.Text) || string.IsNullOrWhiteSpace(TBcantidadProdu.Text))
            {
                MessageBox.Show("Debe completar los campos obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var res = MessageBox.Show("¿Desea guardar los datos del producto: " + TBnomProdu.Text + "", "Guardar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    bool exito = Cproducto.AgregarProducto(TBnomProdu.Text, CtipoProd.SelectedIndex+1, Convert.ToDecimal(TBprecio.Text), TBdetalle.Text, TBcantidadProdu.Text, Convert.ToDateTime(dtFecha.Text), DGlistaProductos);

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
        {/*
            if (e.ColumnIndex == DGlistaProductos.Columns["estado"].Index && e.Value != null)
            {
                bool estado = Convert.ToBoolean(e.Value);
                e.Value = estado ? true : false;
                e.FormattingApplied = true;
               
            }*/
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

        private void TBnomProdu_TextChanged(object sender, EventArgs e){}
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

        private void BeditarProd_Click(object sender, EventArgs e)
        {
            DGlistaProductos[0, pos].Value = TBnomProdu.Text;
            DGlistaProductos[1, pos].Value = CtipoProd.Text;
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

        private void FlistaProductosAdmin_Load(object sender, EventArgs e)
        {
           


        }

        private void FlistaProductosAdmin_Load_1(object sender, EventArgs e)
        {
            

        }
    } 
}
