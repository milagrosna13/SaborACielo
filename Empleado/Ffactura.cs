﻿using System;
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
using iText.Kernel.Events;
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
                TBtotal.Text = datosVenta["total"].ToString();

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

        

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int yCabecera = ImprimirCabecera(e.Graphics);

            Font font = new Font("Times New Roman", 14);
            SolidBrush brush = new SolidBrush(Color.Black);
            int xPosTexto = 50;
            int yPosTexto = yCabecera + 100; // Ajusta la posición según tus necesidades

            g.DrawString("-----------------------------------------------------------------------------------------------------",
                font, brush, xPosTexto, yPosTexto);
            yPosTexto += 20;

            // Imprimir nombres de las columnas
            g.DrawString("Producto", font, brush, xPosTexto, yPosTexto);
            xPosTexto += 120; // Ajusta el espacio entre los nombres de las columnas

            g.DrawString("Tipo", font, brush, xPosTexto, yPosTexto);
            xPosTexto += 120;

            g.DrawString("Detalle", font, brush, xPosTexto, yPosTexto);
            xPosTexto += 170;

            g.DrawString("Precio Unit", font, brush, xPosTexto, yPosTexto);
            xPosTexto += 120;

            g.DrawString("Cantidad", font, brush, xPosTexto, yPosTexto);
            xPosTexto += 120;

            g.DrawString("Subtotal", font, brush, xPosTexto, yPosTexto);
            

            yPosTexto += 20;
            xPosTexto = 50;
            g.DrawString("-----------------------------------------------------------------------------------------------------",
                font, brush, xPosTexto, yPosTexto);


            ImprimirDataGridView(e, yPosTexto+10);
        }

        private int ImprimirCabecera(Graphics g)
        {
            Font fontPanel = new Font("Times New Roman", 14);
            Font font = new Font("Arial", 12);
            SolidBrush brush = new SolidBrush(Color.Black);
            int xInicial = 80;
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
                            g.DrawString(label.Text, fontPanel, brush, xInicial + panel.Left + label.Left, panel.Top + label.Top);
                            ultimaPosicionY = panel.Top + label.Top + label.Height; // Actualiza la última posición Y
                        }

                        if (panelControl is TextBox)
                        {

                            TextBox textBox = (TextBox)panelControl;
                            textBox.BackColor = Color.LightGray;
                            // Dibuja el fondo del TextBox
                            g.FillRectangle(new SolidBrush(textBox.BackColor), xInicial + panel.Left + textBox.Left, panel.Top + textBox.Top, textBox.Width, textBox.Height);

                            // Dibuja el contenido del TextBox
                            g.DrawString(textBox.Text, fontPanel, brush, xInicial + panel.Left + textBox.Left, panel.Top + textBox.Top);
                        }
                    }
                }
            }
            return ultimaPosicionY;
        }

        private void ImprimirDataGridView(PrintPageEventArgs e, int yTexto)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 12);
            SolidBrush brush = new SolidBrush(Color.Black);
            int xPos = 50;
            int yPos = yTexto + 20; 
            int columDetalle = dataGridView1.Columns["Detalle"].Index;
            using (Pen pen = new Pen(Color.Black, 1)) // para los bordes
            {
                
                xPos = 50;
                yPos += dataGridView1.ColumnHeadersHeight; // Ajusta la posición para imprimir los datos

                // Imprimir los datos del DataGridView
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {// Dibujar el contenido de la celda
                        if (cell.Value != null)
                        {
                            g.DrawString(cell.Value.ToString(), font, brush, xPos, yPos);
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
                    xPos = 50;
                    yPos += row.Height;
                }
            }
        }

    }
}
