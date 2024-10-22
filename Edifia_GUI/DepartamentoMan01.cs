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

namespace Edifia_GUI
{
    public partial class DepartamentoMan01 : Form
    {
        DepartamentoBL objDepartamentoBL = new DepartamentoBL();
        DataView dtv;

        public DepartamentoMan01()
        {
            InitializeComponent();
        }

        private void DepartamentoMan01_Load(object sender, EventArgs e)
        {
            dtgDatos.AutoGenerateColumns = false;

            CargarDatosDepartamento("");
        }

        private void CargarDatosDepartamento(String strFiltro)
        {
            DataTable dt = objDepartamentoBL.ListarDepartamento();

            // Agregar una nueva columna como cadena
            dt.Columns.Add("numeroStr", typeof(string));

            // Llenar la nueva columna con los valores convertidos
            foreach (DataRow row in dt.Rows)
            {
                row["numeroStr"] = row["numero"].ToString();
            }

            dtv = new DataView(dt);

            // Si el filtro no es nulo o vacío, aplica un filtro a la vista de datos.
            if (!string.IsNullOrEmpty(strFiltro))
            {
                // Establece el filtro para mostrar solo las filas donde "numeroStr" comience con el texto de strFiltro.
                dtv.RowFilter = "numeroStr like '" + strFiltro + "%'";
            }

            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtv.Count.ToString();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatosDepartamento(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

    }
}
