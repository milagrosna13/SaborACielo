using SaborAcielo.datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SaborAcielo
{
    public partial class Finicio : Form
    {

        public Finicio()
        {
            InitializeComponent();
        }

        private void Bcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bingresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = TBusuario.Text;
            string contrasenia = TBcontraseña.Text;

            int tipoUsuario = Cusuarios.AutenticarUsuario(nombreUsuario, contrasenia);

            if (tipoUsuario != -1)
            {
                UserLogin.NombreUsuario = nombreUsuario;
                UserLogin.TipoUsuario = tipoUsuario;

                switch (tipoUsuario)
                {
                    case 1:
                        // Redirige al formulario para el tipo de usuario 1 (Administrador)
                        MDIadmin formAdmin = new MDIadmin();
                        formAdmin.Show();
                        break;

                    case 2:
                        // Redirige al formulario para el tipo de usuario 2 (Gerente)
                        MDIgerente formGerente = new MDIgerente();
                        formGerente.Show();
                        break;

                    case 3:
                        // Redirige al formulario para el tipo de usuario 3 (Empleado)
                        MDIempleado formEmpleado = new MDIempleado();
                        formEmpleado.Show();
                        break;

                    default:
                        MessageBox.Show("Tipo de usuario desconocido.");
                        break;
                }

                // Oculta el formulario de inicio de sesión (Finicio)
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }


        }
    }
}
