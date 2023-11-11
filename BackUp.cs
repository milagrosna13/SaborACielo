using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;


namespace SaborAcielo
{
    public partial class BackUp : Form
    {
        public BackUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.Filter = "Backup Files (*.bak)|*.bak";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBackUpPath.Text = saveFileDialog1.FileName;
            }
        }

        private void BbackUp_Click(object sender, EventArgs e)
        {
            // Ensure the user selected a file
            if (!string.IsNullOrEmpty(txtBackUpPath.Text))
            {
                try
                {
                    datos.DB_General obj = new datos.DB_General();
                    obj.GeneralQuery("BACKUP DATABASE SaborAcielo TO DISK='" + txtBackUpPath.Text + "'");
                    MessageBox.Show("Backup exitoso.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error durante el backup: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una ubicación de archivo para el respaldo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "restaurar archivos (*.bak)|*.bak";
            openFileDialog1.ShowDialog();
            txtRestorePath.Text = openFileDialog1.FileName;
        
        }

        private void Brestaurar_Click(object sender, EventArgs e)
        {
            // Ensure the user selected a file
            if (!string.IsNullOrEmpty(txtRestorePath.Text))
            {
                try
                {
                    datos.DB_General obj = new datos.DB_General();
                    obj.GeneralQuery("USE master; RESTORE DATABASE SaborAcielo FROM DISK='" + txtRestorePath.Text + "'");
                    MessageBox.Show("Restaurado exitosamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error durante el restore: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un archivo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
