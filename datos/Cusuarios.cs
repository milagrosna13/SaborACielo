using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SaborAcielo.datos
{
    internal class Cusuarios
    {
        public static int AutenticarUsuario(string nombreUsuario, string contrasenia)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SaborAcieloConnectionString"].ConnectionString))
            {
                connection.Open();

                // Realiza la consulta SQL para buscar el usuario en la base de datos
                string consulta = "SELECT contrasenia, salt, id_tipoUsuario FROM Usuario WHERE nom_usuario = @nombreUsuario";

                using (SqlCommand command = new SqlCommand(consulta, connection))
                {
                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            byte[] hashAlmacenado = (byte[])reader["contrasenia"];
                            byte[] salt = (byte[])reader["salt"];
                            byte[] contraseniaBytes = Encoding.UTF8.GetBytes(contrasenia);

                            if (ByteArrayEquals(hashAlmacenado, AplicarHashAContraseña(contraseniaBytes, salt)))
                            {
                                // Las credenciales son válidas, devuelve el tipo de usuario
                                return (int)reader["id_tipoUsuario"];
                            }
                        }
                    }
                }
            }

            // Si no se encuentra el usuario o las credenciales son incorrectas, devuelve un valor negativo
            return -1;
        }

        private static bool ByteArrayEquals(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
                return false;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    return false;
            }

            return true;
        }

        private static byte[] AplicarHashAContraseña(byte[] contraseñaBytes, byte[] salt)
        {
            using (var deriveBytes = new Rfc2898DeriveBytes(contraseñaBytes, salt, 10000, HashAlgorithmName.SHA256))
            {
                return deriveBytes.GetBytes(32); // El hash tiene un tamaño de 32 bytes
            }
        }




    }
}