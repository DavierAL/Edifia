using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Edifia_BE;
using Edifia_BL;

namespace Edifia_GUI
{
    public partial class DepartamentoMan02 : Form
    {
        DepartamentoBL objDepartamentoBL = new DepartamentoBL();
        DepartamentoBE objDepartamentoBE = new DepartamentoBE();
        EdificioBL objEdificioBL = new EdificioBL();

        public DepartamentoMan02()
        {
            InitializeComponent();
        }

        private void DepartamentoMan02_Load(object sender, EventArgs e)
        {
            try
            {
                //cargamos el combo
                DataTable dt = objEdificioBL.ListarEdificios();
                DataRow dr;
                dr = dt.NewRow();
                dr["id"] = 0;
                dr["nombre"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0); 
                cboEdificio.DataSource = dt;
                cboEdificio.ValueMember = "id";
                cboEdificio.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumero.Text.Trim() == String.Empty)
                {
                    throw new Exception("Introduzca un numero de departamento.");
                }

                if (txtPiso.Text.Trim() == String.Empty)
                {
                    throw new Exception("Introduzca un piso del edificio.");
                }
                if (cboEdificio.SelectedIndex == 0)
                {
                    throw new Exception("Elige un edificio.");
                }

                //si todo esta OK....cargamos el objDepartamentoBe
                objDepartamentoBE.numero = Convert.ToInt16(txtNumero.Text);
                objDepartamentoBE.piso = Convert.ToInt16(txtPiso.Text);
                objDepartamentoBE.edificio_id = Convert.ToInt16(cboEdificio.Text);
                objDepartamentoBE.Fec_reg = DateTime.Now;
                objDepartamentoBE.Habitado = optHabitado.Checked;
                objDepartamentoBE.Usu_registro = clsCredenciales.Usuario.ToString();

                // invocamos al metodo insertar
                if (objDepartamentoBL.InsertarDepartamento(objDepartamentoBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se realizo la accion, contactar con el admministrador de la red.");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        
    }
}
