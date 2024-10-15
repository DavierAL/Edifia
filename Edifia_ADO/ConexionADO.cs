using System;
using System.Data.SqlClient;
using System.Configuration;

namespace Edifia_ADO
{
    public class ConexionADO
    {
        // Método para obtener la cadena de conexión desde el archivo de configuración
        public string GetCnx()
        {
            string strCnx = ConfigurationManager.ConnectionStrings["Edifia"].ConnectionString;
            return string.IsNullOrEmpty(strCnx) ? string.Empty : strCnx;
        }

        // Método para probar la conexión a la base de datos
        public bool TestConnection()
        {
            using (SqlConnection con = new SqlConnection(GetCnx()))
            {
                try
                {
                    con.Open(); // Intenta abrir la conexión
                    return true; // La conexión fue exitosa
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                    return false; // La conexión falló
                }
            }
        }
    }
}
