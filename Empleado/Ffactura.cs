using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using SaborAcielo.datos;

namespace SaborAcielo.Empleado
{
    public partial class Ffactura : Form
    {
        private int idventa;
        private Cventas cventas = new Cventas();
        public Ffactura(int id)
        {
            InitializeComponent();
            idventa = id;
            PanelCabecera();
            DetallesVenta();
        }

        private void PanelCabecera()
        {
            DataRow datosVenta = cventas.CabeceraVenta(idventa);
            if(datosVenta != null )
            {
                TBfecha.Text = datosVenta["fecha_venta"].ToString();
                TBcliente.Text = datosVenta["dni_cliente"].ToString() + " - " + datosVenta["nombre_cliente"].ToString();
                TBvendedor.Text = datosVenta["dni_empleado"].ToString() + " - " + datosVenta["nombre"].ToString();
                TBmedio.Text = datosVenta["desc_tipomedio"].ToString();
                TBfactura.Text = datosVenta["id_venta"].ToString();
            }
        }
        private void DetallesVenta()
        {
            bool cargar = Cventas.MostrarResumen(idventa, dataGridView1);
        }
        private void Bimprimir_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings printerSettings = new PrinterSettings();
            printDocument1.PrinterSettings = printerSettings;
            printDocument1.PrintPage += Imprimir;

            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", this.Width, this.Height);    

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        

        private void Bpdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos PDF|*.pdf";
                saveFileDialog.Title = "Guardar factura como PDF";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    using (PdfWriter writer = new PdfWriter(saveFileDialog.FileName))
                    {
                        using (PdfDocument pdf = new PdfDocument(writer))
                        {
                            Document document = new Document(pdf);

                            // Aquí puedes agregar contenido al PDF, como texto, tablas, etc.
                            // Por ejemplo:
                            document.Add(new Paragraph("Factura de Venta"));
                            document.Add(new Paragraph("Fecha: " + DateTime.Now.ToShortDateString()));
                            // ... agregar el resto del contenido de la factura

                            MessageBox.Show("Factura guardada como PDF.");
                        }
                    }
                }
            }
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int yCabecera = ImprimirCabecera(e.Graphics);

            Font font = new Font("Arial", 14);
            SolidBrush brush = new SolidBrush(Color.Black);
            int xPosTexto = 50;
            int yPosTexto = yCabecera + 50; // Ajusta la posición según tus necesidades

            g.DrawString("-----------------------------------------------------------------------", font, brush, xPosTexto, yPosTexto);
            yPosTexto += 20;

            // Imprimir nombres de las columnas
            g.DrawString("Producto", font, brush, xPosTexto, yPosTexto);
            xPosTexto += 120; // Ajusta el espacio entre los nombres de las columnas

            g.DrawString("Tipo", font, brush, xPosTexto, yPosTexto);
            xPosTexto += 120;

            g.DrawString("Detalle", font, brush, xPosTexto, yPosTexto);
            xPosTexto += 160;

            g.DrawString("Precio Unit", font, brush, xPosTexto, yPosTexto);
            xPosTexto += 120;

            g.DrawString("Cantidad", font, brush, xPosTexto, yPosTexto);
            xPosTexto += 120;

            g.DrawString("Subtotal", font, brush, xPosTexto, yPosTexto);
            

            yPosTexto += 20;
            xPosTexto = 50;
            g.DrawString("-----------------------------------------------------------------------", font, brush, xPosTexto, yPosTexto);


            ImprimirDataGridView(e, yPosTexto+10);
        }

        private int ImprimirCabecera(Graphics g)
        {
            Font fontPanel = new Font("Script MT", 14);
            Font font = new Font("Arial", 14);
            SolidBrush brush = new SolidBrush(Color.Black);
            
            int ultimaPosicionY = 0;

            foreach (Control control in Controls)
            {
                if (control is Panel)
                {
                    Panel panel = (Panel)control;

                    foreach (Control panelControl in panel.Controls)
                    {
                        if (panelControl is Label)
                        {
                            Label label = (Label)panelControl;
                            g.DrawString(label.Text, fontPanel, brush, panel.Left + label.Left, panel.Top + label.Top);
                            ultimaPosicionY = panel.Top + label.Top + label.Height; // Actualiza la última posición Y
                        }

                        if (panelControl is TextBox)
                        {
                            TextBox textBox = (TextBox)panelControl;
                            g.DrawString(textBox.Text, font, brush, panel.Left + textBox.Left + 10, panel.Top + textBox.Top);
                        }
                    }
                }
            }
            return ultimaPosicionY;
        }

        private void ImprimirDataGridView(PrintPageEventArgs e, int yTexto)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 14);
            SolidBrush brush = new SolidBrush(Color.Black);
            int xPos = 50;
            int yPos = yTexto + 20; // Ajusta la posición inicial según tus necesidades
            
            int columDetalle = dataGridView1.Columns["Detalle"].Index;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Dibujar el contenido de la celda
                    if (cell.Value != null)
                    {
                        string cellValue = cell.Value.ToString();

                        // Verificar si la columna es "Detalle" y si el texto supera los 15 caracteres
                        if (cell.ColumnIndex == dataGridView1.Columns["Detalle"].Index && cellValue.Length > 15)
                        {
                            // Dividir el texto en líneas de máximo 15 caracteres
                            int maxLength = 15;
                            for (int i = 0; i < cellValue.Length; i += maxLength)
                            {
                                int remainingLength = Math.Min(maxLength, cellValue.Length - i);
                                g.DrawString(cellValue.Substring(i, remainingLength), font, brush, xPos, yPos);
                                yPos += 20; // Ajusta el espacio entre las líneas
                            }
                        }
                        else
                        {
                            g.DrawString(cell.Value.ToString(), font, brush, xPos, yPos);
                        }
                    }
                    // Ajustar la posición para la siguiente celda
                    if (cell.ColumnIndex == columDetalle)
                    {
                        xPos += cell.Size.Width + 60;
                    }
                    else
                    {
                        xPos += cell.Size.Width + 20;
                    }
                }

                // Restablecer la posición para la siguiente fila
                xPos = 50;
                yPos += row.Height + 10; // Espaciado entre filas
            }
        }




        private void FormularioFactura_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Configura la fuente y el pincel
            Font font = new Font("Arial", 12);
            SolidBrush brush = new SolidBrush(Color.Black);

            /* Dibuja el contenido de la factura
            g.DrawString("Factura de Venta", font, brush, 100, 100);
            g.DrawString("Fecha: " + DateTime.Now.ToShortDateString(), font, brush, 100, 130);*/

            // Dibuja los labels del formulario
            foreach (Control control in Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;
                    g.DrawString(label.Text, font, brush, label.Left, label.Top);
                }
            }
        }
    }
}
