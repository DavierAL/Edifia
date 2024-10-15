using System;
using System.Data.SqlClient;
using Edifia_BE;

namespace Edifia_ADO
{
    public class UsuarioADO
    {
        private readonly ConexionADO _conexion;

        public UsuarioADO()
        {
            _conexion = new ConexionADO(); // Inicializamos la clase de conexión
        }

        public UsuarioBE Login(string login, string password)
        {
            UsuarioBE usuario = null;

            using (SqlConnection con = new SqlConnection(_conexion.GetCnx())) // Usamos GetCnx para obtener la cadena
            {
                string query = "EXEC usp_IniciarSesion @login_Usuario, @pass_Usuario"; // Llamando al procedimiento almacenado
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@login_Usuario", login);
                cmd.Parameters.AddWithValue("@pass_Usuario", password); // Considera encriptar la contraseña

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Verificamos el mensaje devuelto
                    string mensaje = reader["mensaje"].ToString();
                    if (mensaje == "Inicio de sesión exitoso")
                    {
                        usuario = new UsuarioBE
                        {
                            Id = (short)Convert.ToInt32(reader["id_Usuario"]),
                            NivelUsuario = (short)Convert.ToInt32(reader["nivel_Usuario"]),
                            LoginUsuario = login // Asignamos el login al objeto usuario
                        };
                    }
                    else
                    {
                        // Si el usuario está inactivo o las credenciales son incorrectas, lanzar una excepción
                        throw new Exception(mensaje);
                    }
                }
                else
                {
                    throw new Exception("Error: No se pudo procesar la solicitud.");
                }
            }

            return usuario;
        }
    }
}
