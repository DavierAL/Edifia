using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Edifia_ADO
{
    public class EdificioADO
    {
        ConexionADO _conexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarEdificios()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = _conexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarEdificios";
            try
            {

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
