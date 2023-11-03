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

namespace SaborAcielo.Empleado
{
    public partial class Ffactura : Form
    {
        public Ffactura()
        {
            InitializeComponent();
        }

        private void Bimprimir_Click(object sender, EventArgs e)
        {
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            // Configura la fuente y el pincel
            Font font = new Font("Arial", 12);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Dibuja el contenido de la factura
            g.DrawString("Factura de Venta", font, brush, 100, 100);
            g.DrawString("Fecha: " + DateTime.Now.ToShortDateString(), font, brush, 100, 130);

            // Dibuja los labels del formulario
            foreach (Control control in Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;
                    g.DrawString(label.Text, font, brush, label.Left, label.Top);
                }
            }
            // e.HasMorePages = true; // Si hay más páginas
            // e.HasMorePages = false; // Si no hay más páginas
        }
        private void FormularioFactura_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Configura la fuente y el pincel
            Font font = new Font("Arial", 12);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Dibuja el contenido de la factura
            g.DrawString("Factura de Venta", font, brush, 100, 100);
            g.DrawString("Fecha: " + DateTime.Now.ToShortDateString(), font, brush, 100, 130);

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
