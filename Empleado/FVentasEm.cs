﻿using SaborAcielo.datos;
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
    public partial class FVentasEm : Form
    {
        Cventas filtroVenta = new Cventas();
        public FVentasEm()
        {
            InitializeComponent();
            bool exito = Cventas.cargarVentas(DGventas);
            if(exito)
            {
                Cventas.botonDetalle(DGventas);
            }
        }

        private void Fcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Tbem_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TBdniE.Text))
            {
                int dni = Convert.ToInt32(TBdniE.Text);
                DataSet dataSet = filtroVenta.FiltrarVentaDniEmpleado(dni);
                if(dataSet != null)
                {
                    DGventas.DataSource = dataSet.Tables["Venta_cabecera"];
                }
                
            }
        }

        private void TBdniC_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TBdniC.Text))
            {
                int dni = Convert.ToInt32(TBdniC.Text);
                DataSet dataSet = filtroVenta.FiltrarVentaPorCliente(dni);
                if (dataSet != null)
                {
                    DGventas.DataSource = dataSet.Tables["Venta_cabecera"];
                }
            }
        }

        private void TBdniE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void CBfecha_CheckedChanged(object sender, EventArgs e)
        {
            if (CBfecha.Checked)
            {
                DTdesde.Enabled = true;
                DThasta.Enabled = true;
                
            }
        }

        private void DGventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGventas.Columns["Detalle"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(DGventas.Rows[e.RowIndex].Cells["ID"].Value);
                Cventas.MostrarResumen(id, DGdetalle);
            }
        }

        private void DTdesde_ValueChanged(object sender, EventArgs e)
        {
            filtroVenta.buscarFecha(DTdesde.Value, DThasta.Value, DGventas);
        }

        private void DThasta_ValueChanged(object sender, EventArgs e)
        {
            filtroVenta.buscarFecha(DTdesde.Value, DThasta.Value, DGventas);
        }
    }
}
