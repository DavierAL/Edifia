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
    public partial class frmLogin : Form
    {
        private UsuarioBL _usuarioBL;

        public frmLogin()
        {
            InitializeComponent();
            _usuarioBL = new UsuarioBL(); // Inicializamos UsuarioBL
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtUsuario.Text.Trim();
            string password = txtContra.Text.Trim();

            try
            {
                // Verifica la conexión a la base de datos
                if (!_usuarioBL.TestConnection())
                {
                    MessageBox.Show("No se pudo conectar a la base de datos. Por favor, verifica la configuración.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salimos si no hay conexión
                }

                // Obtenemos el usuario desde el método Login
                UsuarioBE usuario = _usuarioBL.Login(login, password);
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Asignamos los valores del usuario obtenido a las credenciales estáticas
                clsCredenciales.Usuario = usuario.LoginUsuario;
                clsCredenciales.Password = usuario.PassUsuario;
                clsCredenciales.Nivel = usuario.NivelUsuario;

                // Redireccionamos a la pantalla principal
                MDIPrincipal mdiprincipal = new MDIPrincipal();
                mdiprincipal.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                // Mostramos el mensaje de error y limpiamos los campos solo en caso de error
                MessageBox.Show("Credenciales incorrectas. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            txtContra.Text = String.Empty;
            txtUsuario.Text = String.Empty;
            txtUsuario.Focus(); // Colocamos el foco en el campo de usuario
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Preguntamos si la tecla pulsada fue Enter
            if (e.KeyChar == (char)13)
            {
                // Ejecutamos el evento de click del botón de login
                btnLogin.PerformClick();
            }
        }
    }
}