using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar....
using System.Data;
using System.Data.SqlClient;
using Edifia_BE;

namespace Edifia_ADO
{
    public class DepartamentoADO
    {
        ConexionADO _conexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarDepartamento()
        {
            try
            {
                cnx.ConnectionString = _conexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Tb_Departamento_Listar";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();

                ada.Fill(dts, "Departamentos");
                return dts.Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DepartamentoBE ConsultarDepartamento(String strDepartamento)
        {
            try
            {
                DepartamentoBE objDepartamentoBE = new DepartamentoBE();
                cnx.ConnectionString = _conexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Tb_Departamento_Consultar_";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID", strDepartamento);

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objDepartamentoBE.id = Convert.ToInt16(dtr["id"]);
                    objDepartamentoBE.numero = Convert.ToInt16(dtr["numero"]);
                    objDepartamentoBE.piso = Convert.ToInt16(dtr["piso"]);
                    objDepartamentoBE.edificio_id = Convert.ToInt16(dtr["edificio_id"]);
                    objDepartamentoBE.plano = (byte[])dtr["plano"];
                }
                dtr.Close();
                return objDepartamentoBE;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally 
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public Boolean InsertarDepartamento(DepartamentoBE objDepartamentoBE)
        {

            try
            {
                cnx.ConnectionString = _conexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Tb_Departamento_Insertar";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@numero", objDepartamentoBE.numero);
                cmd.Parameters.AddWithValue("@piso", objDepartamentoBE.piso);
                cmd.Parameters.AddWithValue("@edificio_id", objDepartamentoBE.edificio_id);
                cmd.Parameters.AddWithValue("@usu_registro", objDepartamentoBE.Usu_registro);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }
        public Boolean ActualizarDepartamento(DepartamentoBE objDepartamentoBE)
        {
            try
            {
                cnx.ConnectionString = _conexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Tb_Departamento_Actualizar";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@numero", objDepartamentoBE.numero);
                cmd.Parameters.AddWithValue("@piso", objDepartamentoBE.piso);
                cmd.Parameters.AddWithValue("@edificio_id", objDepartamentoBE.edificio_id);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public Boolean EliminarDepartamento(String strCodigo)
        {
            try
            {
                cnx.ConnectionString = _conexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Tb_Departamento_Eliminar";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID", strCodigo);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                return false;
                throw new Exception(x.Message);

            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }
    }
}
