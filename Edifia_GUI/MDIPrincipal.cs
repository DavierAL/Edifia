using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edifia_GUI
{
    public partial class MDIPrincipal : Form
    {
        TimeSpan horaEntrada = new TimeSpan();

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // fecha y hora del sistema
            this.Text = "Edifia - Menu Principal      " + DateTime.Now.ToString();

            // tiempo de sesion 
            lblTiempo.Text = "Tiempo: " + DateTime.Now.TimeOfDay.Subtract(horaEntrada).ToString().Substring(0, 8);
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            horaEntrada = DateTime.Now.TimeOfDay;
            lblUsuario.Text = $"Usuario: {clsCredenciales.Usuario?.ToString() ?? "Desconocido"}";
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartamentoMan01 objDepartamentoMan01 = new DepartamentoMan01();
            objDepartamentoMan01.MdiParent = this;
            objDepartamentoMan01.Show();

        }
    }
}
