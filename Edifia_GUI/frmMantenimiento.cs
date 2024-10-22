using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Edifia_BL;
using Edifia_BE;

namespace Edifia_GUI
{
    public partial class frmMantenimiento : Form
    {
        // Instancias...
        MantenimientoBL objMantenimientoBL = new MantenimientoBL();
        MantenimientoBE objMantenimientoBE = new MantenimientoBE();
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        ActividadMantenimientoBL objActividadMantenimientoBL = new ActividadMantenimientoBL();
        EdificioBL objEdificioBL = new EdificioBL();

        public frmMantenimiento()
        {
            InitializeComponent();
        }

        private void frmMantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                DataTable dt = objEmpleadoBL.ListarEmpleado();
                DataRow dr;
                dr = dt.NewRow();
                dr["id"] = 0;
                dr["nombre"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboActividad.DataSource = dt;
                cboActividad.ValueMember = "id";
                cboActividad.DisplayMember = "nombre";

                dt = objActividadMantenimientoBL.ListarActividadMantenimiento();
                dr = dt.NewRow();
                dr["id"] = 0;
                dr["descripcion"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboResponsable.DataSource = dt;
                cboResponsable.ValueMember = "id";
                cboResponsable.DisplayMember = "descripcion";

                dt = objEdificioBL.ListarEdificio();
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
    }
}

