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

namespace Biblioteca.WinForms
{
    public partial class frmUsuariosABM : Form
    {
        UsuarioDAL _usuariosDAL = new UsuarioDAL();

        public frmUsuariosABM()
        {
            InitializeComponent();
        }

        public void ResetForm()
        {
            lbxUsuarios.DataSource = _usuariosDAL.GetUsuarios();
            bsUsuario.DataSource = new Usuario();
            bsUsuario.ResetBindings(true);
            lbxUsuarios.ClearSelected();
        }

        private void frmUsuariosABM_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void lbxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuario userSelect = (Usuario)lbxUsuarios.SelectedItem;
            if (userSelect == null) return;

            if (userSelect == null)
            {
                txtNombre.Enabled = true;
                txtPassword.Enabled = true;
                return;
            }

            bsUsuario.DataSource = userSelect;
            bsUsuario.ResetBindings(true);

            if (StaticUserLogin.Id == userSelect.Id || userSelect.Id == 0)
            {
                txtNombre.Enabled = true;
                txtPassword.Enabled = true;
                chkMostrarPass.Enabled = true;
            }
            else
            {
                txtNombre.Enabled = false;
                txtPassword.Enabled = false;
                chkMostrarPass.Enabled = false;
                chkMostrarPass.Checked = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario userSelect = (Usuario)bsUsuario.Current;

            if (_usuariosDAL.GuardarUsuario(userSelect))
                MessageBox.Show("Los cambios fueron guardados exitosamente", "Atencion...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(_usuariosDAL._errorMsg, "Atencion...", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ResetForm();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se eliminara el usuario seleccionado.¿Desea continuar?", "Atencion...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            Usuario userSelect = (Usuario)bsUsuario.Current;

            if (_usuariosDAL.EliminarUsuario(userSelect))
                MessageBox.Show("El usuario se ha eliminado exitosamente", "Atencion...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(_usuariosDAL._errorMsg, "Atencion...", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ResetForm();
        }

        private void chkMostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkMostrarPass.Checked;
        }
    }
}
