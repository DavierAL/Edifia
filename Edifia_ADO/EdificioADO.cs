using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
=======
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> ad178f82718c561339c10efb5feae9ded6c688e0

namespace Edifia_ADO
{
    public class EdificioADO
    {
<<<<<<< HEAD
        ConexionADO _conexion = new ConexionADO();
=======
        private readonly ConexionADO _conexion;

        public EdificioADO()
        {
            _conexion = new ConexionADO();
        }

        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
>>>>>>> ad178f82718c561339c10efb5feae9ded6c688e0
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

<<<<<<< HEAD
        public DataTable ListarEdificios()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = _conexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarEdificios";
            try
            {
<<<<<<<< HEAD:Edifia_ADO/EdificioADO.cs

========
                cnx.ConnectionString = _conexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Tb_Mantenimiento_FechaProgramada";
>>>>>>>> ad178f82718c561339c10efb5feae9ded6c688e0:Edifia_ADO/MantenimientoADO.cs
=======
        public DataTable ListarEdificio()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_Tb_Edificio_Listar";
            try
            {

>>>>>>> ad178f82718c561339c10efb5feae9ded6c688e0
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Edificios");
                return dts.Tables["Edificios"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
