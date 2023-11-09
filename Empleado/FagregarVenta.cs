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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace SaborAcielo
{
    public partial class FagregarVenta : Form
    {
        public int venta;
        private Ccliente clienteDatos = new Ccliente();
        private Cventas cventas = new Cventas();
        private Cproducto cproducto = new Cproducto();
        private Cusuarios cusuario = new Cusuarios();
        private Cempleado cempleado = new Cempleado();
        public FagregarVenta()
        {
            InitializeComponent();
            CtipoProd.DisplayMember = "Nombre";

            bool datos = cproducto.ObtenerProductosActivos(string.Empty, string.Empty, string.Empty, DGprodu);

            Cproducto.botonAgregar(DGprodu);
            InicializarComboBoxes();

            agregarColumnasCarrito();

            inicializarDatos();
                        
        }

        private void InicializarComboBoxes()
        {
            List<string> nombres = cproducto.ObtenerNombresUnicos();
            List<string> tipos = cproducto.ObtenerTipos();
            List<string> detalles = cproducto.ObtenerDetalles();
            List<string> medios = cproducto.ObtenerModoPago();

            // Llena los ComboBox con los valores obtenidos
            CBproducto.Items.AddRange(nombres.ToArray());
            CtipoProd.Items.AddRange(tipos.ToArray());
            CBDetalle.Items.AddRange(detalles.ToArray());
            CBpago.Items.AddRange(medios.ToArray());
        }

        private void inicializarDatos()
        {
            
            string user = UserLogin.NombreUsuario;
            int dni = cusuario.ObtenerDniUsuario(user);

            string nombre = cempleado.ObtenerNombreEmpleado(dni);

            TBNem.Text = nombre;
            TBDemp.Text = Convert.ToString(dni);
            TBfactura.Text = Convert.ToString(cventas.obtenerMaxVenta() + 1);

            if (!string.IsNullOrEmpty(TBdnicliente.Text))
            {
                DataTable dt = clienteDatos.BuscarClientePorDNI(Convert.ToInt32(TBdnicliente.Text));
                DataRow row = dt.Rows[0];
                nomCliente.Text = row["nombre_cliente"].ToString();
                aCliente.Text = row["apellido_cliente"].ToString();
                tCliente.Text = row["tel_cliente"].ToString();
                direCliente.Text = row["dire_cliente"].ToString();
                emCliente.Text = row["email_cliente"].ToString();
            }
        }
        private void limpiar()
        {
            TBdnicliente.Clear();
            nomCliente.Clear();
            aCliente.Clear();
            direCliente.Clear();
            tCliente.Clear();
            emCliente.Clear();
            
        }


        private void Bcompra_Click(object sender, EventArgs e)
        {
            string user = UserLogin.NombreUsuario;
            
            if (DGcarrito.Rows.Count > 0 && !string.IsNullOrEmpty(TBdnicliente.Text) && CBpago.SelectedIndex != -1 && Convert.ToInt16(DGcarrito.Rows[0].Cells["ID"].Value) > 0)
            {
                DialogResult res = MessageBox.Show("Desea finalizar la compra?", "Confirmar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    int filas = DGcarrito.Rows.Count - 1;
                    MessageBox.Show("filas= " + filas + "; cantidades= " + cantidad());
                    int ventaMax = cventas.obtenerMaxVenta();
                    venta = ventaMax + 1;
                    decimal total = calcularTotal();
                    int empleado = cusuario.ObtenerDniUsuario(user);

                    
                    if (cantidadesIngresadas())
                    {
                        bool ventaExitosa = cventas.agregarCabecera(Convert.ToInt32(TBdnicliente.Text), venta, empleado, DateTime.Now, total, CBpago.SelectedIndex + 1);
                        bool detalleExitoso = cventas.agregarDetalle(venta, DGcarrito);

                        if (ventaExitosa && detalleExitoso)
                        {
                            
                            cproducto.actualizarStock(DGcarrito,DGprodu);
                            cproducto.ObtenerProductosActivos(string.Empty, string.Empty, string.Empty, DGprodu);
                            
                            limpiar();
                            DGcarrito.Rows.Clear();
                            int proxF = Convert.ToInt32(TBfactura.Text) + 1;
                            TBfactura.Text = Convert.ToString(proxF);
                            TBtotal.Clear();
                            CBpago.SelectedIndex = -1;

                            DialogResult resp = MessageBox.Show("Compra realizada. ¿Desea ver la factura?", "Compra", MessageBoxButtons.YesNo);
                            if(resp == DialogResult.Yes)
                            {
                                cventas.verFactura(venta, DGcarrito);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar la cantidad de producto a comprar", "Error", MessageBoxButtons.OK);
                    }
                }
            }
            else if(DGcarrito.Rows.Count < 0)
            {
                MessageBox.Show("Debe agregar productos al carrito", "Error", MessageBoxButtons.OK);
            } else if(string.IsNullOrEmpty(TBdnicliente.Text))
            {
                MessageBox.Show("Debe ingresar los datos del cliente", "Error", MessageBoxButtons.OK);
            } else 
            {
                MessageBox.Show("Debe seleccionar el método de pago", "Error", MessageBoxButtons.OK);

            }

        }

        private bool cantidadesIngresadas()
        {
            int cant = 0;
            foreach (DataGridViewRow row in DGcarrito.Rows)
            {
                if (Convert.ToInt16(row.Cells["Cantidad"].Value) > 0)
                {
                    cant ++;
                }
            }
            return cant == DGcarrito.Rows.Count-1;
        }

        private int cantidad()
        {
            int cant = 0;
            foreach (DataGridViewRow row in DGcarrito.Rows)
            {
                if (Convert.ToInt16(row.Cells["Cantidad"].Value) > 0)
                {
                    cant++;
                }
            }
            return cant;
        }


        private decimal calcularTotal()
        {
            decimal suma = 0; 

            foreach (DataGridViewRow row in DGcarrito.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    suma += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                }
            }
            return suma;

        }

        private bool existeEnCarrito(int id)
        {
            bool existe = false;
            foreach (DataGridViewRow row in DGcarrito.Rows)
            {
                if (Convert.ToInt32(row.Cells["ID"].Value) == id)
                {
                    MessageBox.Show("El producto ya se encuentra en el carrito");
                    existe = true;
                    break;
                } 
            }
            
            return existe;
        }


        private void BcancelarCompra_Click(object sender, EventArgs e)
        {
            CBDetalle.SelectedIndex = -1;
            CBproducto.SelectedIndex = -1;
            CtipoProd.SelectedIndex = -1;
        }

        private void TBdnicliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Bbuscardni_Click(object sender, EventArgs e)
        {

            DataTable dt = clienteDatos.BuscarClientePorDNI(Convert.ToInt32(TBdnicliente.Text));

            if (dt.Rows != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                nomCliente.Text = row["nombre_cliente"].ToString();
                aCliente.Text = row["apellido_cliente"].ToString();
                tCliente.Text = row["tel_cliente"].ToString();
                direCliente.Text = row["dire_cliente"].ToString();
                emCliente.Text = row["email_cliente"].ToString();

            }
            else
            {
                DialogResult res = MessageBox.Show("El cliente no se encuentra. ¿Desea registrarlo?", "Error", MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        int dni = Convert.ToInt32(TBdnicliente.Text);
                        FagregarCliente fagregarCliente = new FagregarCliente(this, dni);
                        fagregarCliente.Show();
                        break;
                    case DialogResult.No:
                        limpiar();
                        break;

                }

            }

        }

        private void FiltrarProducto()
        {
            string nombre;
            string tipo;
            string detalle;

            if (CBproducto.SelectedIndex > -1)
            {
                nombre = CBproducto.SelectedItem.ToString();
            }
            else nombre = string.Empty; ;
            if (CtipoProd.SelectedIndex > -1)
            {
                tipo = CtipoProd.SelectedItem.ToString();
            }
            else tipo = string.Empty;
            if (CBDetalle.SelectedIndex > -1)
            {
                detalle = CBDetalle.SelectedItem.ToString();
            }
            else detalle = string.Empty;

            bool datos = cproducto.ObtenerProductosActivos(nombre, tipo, detalle, DGprodu);


        }

        private void CtipoProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarProducto();
        }

        private void CBproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarProducto();
        }

        private void CBDetalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarProducto();
        }

        public void agregarColumnasCarrito()
        {
            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.HeaderText = "Producto";
            colNombre.Name = "Nombre";
            DataGridViewTextBoxColumn coltipo = new DataGridViewTextBoxColumn();
            coltipo.HeaderText = "Tipo";
            coltipo.Name = "Tipo";
            DataGridViewTextBoxColumn colDet = new DataGridViewTextBoxColumn();
            colDet.HeaderText = "Detalle";
            colDet.Name = "Detalle";
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.HeaderText = "ID";
            colId.Name = "ID";
            DataGridViewTextBoxColumn colPrecio = new DataGridViewTextBoxColumn();
            colPrecio.HeaderText = "Precio";
            colPrecio.Name = "Precio";
            DataGridViewTextBoxColumn colCant = new DataGridViewTextBoxColumn();
            colCant.HeaderText = "Cantidad";
            colCant.Name = "Cantidad";


            DataGridViewTextBoxColumn colSubTotal = new DataGridViewTextBoxColumn();
            colSubTotal.HeaderText = "SubTotal";
            colSubTotal.Name = "Subtotal";

            DataGridViewButtonColumn columnaQuitar = new DataGridViewButtonColumn();
            columnaQuitar.Name = "Quitar";
            columnaQuitar.Text = "Quitar";
            columnaQuitar.UseColumnTextForButtonValue = true;

            DGcarrito.Columns.Add(colId);
            DGcarrito.Columns.Add(colNombre);
            DGcarrito.Columns.Add(coltipo);
            DGcarrito.Columns.Add(colDet);
            DGcarrito.Columns.Add(colPrecio);
            DGcarrito.Columns.Add(colCant);
            DGcarrito.Columns.Add(colSubTotal);
            DGcarrito.Columns.Add(columnaQuitar);

        }

        //agregar producto al carrito
        private void DGprodu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGprodu.Columns["Agregar"].Index && e.RowIndex >= 0 && Convert.ToInt32(DGprodu.Rows[e.RowIndex].Cells["ID"].Value) > 0) 
            {
                int id = Convert.ToInt32(DGprodu.Rows[e.RowIndex].Cells["ID"].Value);

                if (!existeEnCarrito(id))
                {
                    DataRow datosProdu = cproducto.obtenerProdu(id);

                    if (datosProdu != null)
                    {
                        DGcarrito.Rows.Add(datosProdu["id_produ"], datosProdu["nombre_produ"], datosProdu["desc_tipoProd"], datosProdu["detalle"], datosProdu["precio"]);
                    }
                }
                
            }

        }

        //quitar producto del carrito
        private void DGcarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGcarrito.Columns["Quitar"].Index && e.RowIndex >= 0)
            {
                DialogResult res = MessageBox.Show("Se eliminará el producto del carrito", "Confirmar", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    DGcarrito.Rows.RemoveAt(e.RowIndex);
                    TBtotal.Text = "$ " + calcularTotal();
                }
            }

        }

        //definir la cantidad del produ a comprar
        private void DGcarrito_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewColumn columnaCantidad = DGcarrito.Columns["Cantidad"];
            DataGridViewColumn columnaPrecio = DGcarrito.Columns["Precio"];
            DataGridViewColumn columnaSubtotal = DGcarrito.Columns["Subtotal"];

            if (e.ColumnIndex == columnaCantidad.Index)
            {
                int idProductoSeleccionado = Convert.ToInt32(DGcarrito.Rows[e.RowIndex].Cells["ID"].Value);
                int stockDisponible = 0;

                foreach (DataGridViewRow row in DGprodu.Rows)
                {
                    if (Convert.ToInt32(row.Cells["ID"].Value) == idProductoSeleccionado)
                    {
                        stockDisponible = Convert.ToInt32(row.Cells["Stock"].Value);
                    }
                }

                if (Convert.ToInt32(DGcarrito.Rows[e.RowIndex].Cells[columnaCantidad.Index].Value) > 0)
                {
                    double valorEntrada = Convert.ToDouble(DGcarrito.Rows[e.RowIndex].Cells[columnaCantidad.Index].Value);

                    if (valorEntrada <= stockDisponible)
                    {
                        double valorPrecio = Convert.ToDouble(DGcarrito.Rows[e.RowIndex].Cells[columnaPrecio.Index].Value);

                        double resultado = valorEntrada * valorPrecio;

                        DGcarrito.Rows[e.RowIndex].Cells[columnaSubtotal.Index].Value = resultado;

                        TBtotal.Text = "$ " + calcularTotal();

                    }
                    else
                    {
                        MessageBox.Show("Valor ingresado supera el stock disponible", "error", MessageBoxButtons.OK);
                        DGcarrito.Rows[e.RowIndex].Cells[columnaCantidad.Index].Value = 0;
                    }
                }
            }
            else { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void CBpago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DGcarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void DGcarrito_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FagregarVenta_Load(object sender, EventArgs e)
        {
            inicializarDatos();
        }
    }
}
