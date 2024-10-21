using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Edifia_BE;

namespace Edifia_ADO
{
    public class MantenimientoADO
    {
        ConexionADO _conexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;


        public DataTable ListarMantenimiento()
        {
            try
            {
                cnx.ConnectionString = _conexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Tb_Mantenimiento_FechaProgramada";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();

                ada.Fill(dts, "Mantenimientos");
                return dts.Tables[0];
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
