﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edifia_BE;
using System.Data.SqlClient;
using System.Data;


namespace Edifia_ADO
{

    public class EmpleadoADO
    {

        private readonly ConexionADO _conexion;

        public EmpleadoADO()
        {
            _conexion = new ConexionADO();
        }

        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarEmpleado()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_Tb_Empleado_Listar";
            try
            {

                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Empleados");
                return dts.Tables["Empleados"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
