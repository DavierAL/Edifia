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
    public partial class PersonaMan01 : Form
    {
        PersonaBL objPersonaBL = new PersonaBL();
        DataView dtv;
        public PersonaMan01()
        {
            InitializeComponent();
        }

        private void PersonaMan01_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }

        private void CargarDatos(String strFiltro)
        {
            dtv = new DataView(objPersonaBL.ListarPersona());
            dtv.RowFilter = "apellido like '%" + strFiltro + "%'";
            dtgDatos.DataSource = dtv;


        }
    }
}
