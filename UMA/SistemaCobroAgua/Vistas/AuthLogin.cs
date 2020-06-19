using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//librerias que se agregaron
using SistemaCobroAgua.DAL;
using SistemaCobroAgua.Modelos;


namespace SistemaCobroAgua.Vistas
{
    public partial class AuthLoginForm : MetroFramework.Forms.MetroForm
    {
        //inicio de clase como objeto
        Usuario _usuario = new Usuario();
        AuthDAL _authDAL = new AuthDAL();
        public AuthLoginForm()
        {
            InitializeComponent();
            // The password character is an asterisk.
            txtPassword.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            txtPassword.MaxLength = 14;
        }

        //carga de tema metroframework ui
        private void AuthLoginForm_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManagerLogin;
            metroStyleManagerLogin.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManagerLogin.Style = MetroFramework.MetroColorStyle.Green;
            if (Properties.Settings.Default.Recuerdame)
            {
                txtEmail.Text = Properties.Settings.Default.Email;
                txtPassword.Text = Properties.Settings.Default.Password;
            }
        }

        //evento de boton login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //validacion
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Por favor ingrese su correo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            try
            {
                //obtener valores               
                _usuario.Email = txtEmail.Text;
                _usuario.Password = txtPassword.Text;
                //instancia de metodo
                 var userLogin = _authDAL.Login(_usuario);
                
                if (userLogin != null)
                {
                    if (userLogin.Password == txtPassword.Text)
                    {
                        using (MenuPrincipalForm formMenu = new MenuPrincipalForm())
                        {
                            this.Hide();
                            formMenu.ShowDialog();                           
                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "El correo y clave no concuerdan", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "El correo y clave no concuerdan", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chckRecuerdaDatos_CheckedChanged(object sender, EventArgs e)
        {
            if (chckRecuerdaDatos.Checked)
            {
                Properties.Settings.Default.Email = txtEmail.Text;
                Properties.Settings.Default.Password = txtPassword.Text;

            }
            else
            {
                Properties.Settings.Default.Email = null;
                Properties.Settings.Default.Password = null;
            }
            Properties.Settings.Default.Recuerdame = chckRecuerdaDatos.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
