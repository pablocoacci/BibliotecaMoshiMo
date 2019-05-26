using DominioClases.Clases;
using DominioClases.DAL;
using DominioClases.StaticHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class frmLogin : Form
    {
        private UsuarioDAL _usuarioDAL = new UsuarioDAL();
        public bool _loginResult = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string pass = txtPass.Text;

            Usuario user = _usuarioDAL.LoginUser(nombre, pass);

            if (user == null)
            {
                MessageBox.Show(_usuarioDAL._errorMsg, "Atencion...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StaticUserLogin.SetUserLogin(user);
            _loginResult = true;
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !chkMostrarPass.Checked;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Usuario nuevoUser = new Usuario() { Nombre = txtNombre.Text, Password = txtPass.Text };

            if(!_usuarioDAL.GuardarUsuario(nuevoUser))
            {
                MessageBox.Show(_usuarioDAL._errorMsg, "Atencion...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StaticUserLogin.SetUserLogin(nuevoUser);
            _loginResult = true;
            this.Close();
        }
    }
}
