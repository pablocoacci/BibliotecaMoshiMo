using DominioClases.Clases;
using DominioClases.DAL;
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
    public partial class frmTipoEstanteABM : Form
    {
        private EstanteriaDAL _estanteriaDAL = new EstanteriaDAL();

        public frmTipoEstanteABM()
        {
            InitializeComponent();
        }

        #region Metodos Privados

        private void ResetForm()
        {
            //_estanteriaDAL.ResetContexto();
            //lbxTiposEstantes.Items.Clear();
            lbxTiposEstantes.DataSource = _estanteriaDAL.GetTiposEstantes();
            bsTipoEstante.DataSource = new Tipo_Estante();
            bsTipoEstante.ResetBindings(true);
            lbxTiposEstantes.ClearSelected();
        }

        #endregion

        #region Eventos

        private void frmTipoEstanteABM_Load(object sender, EventArgs e)
        {
            ResetForm();
            //lbxTiposEstantes.DataSource = _estanteriaDAL.GetTiposEstantes();
            //lbxTiposEstantes.ClearSelected();
        }

        private void lbxTiposEstantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tipo_Estante estanteSelected = (Tipo_Estante)lbxTiposEstantes.SelectedItem;
            if (estanteSelected == null) return;
            bsTipoEstante.DataSource = estanteSelected;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Tipo_Estante estanteSelected = (Tipo_Estante)bsTipoEstante.Current;

            if (_estanteriaDAL.GuardarTipoEstante(estanteSelected))
                MessageBox.Show("Los cambios se guardaron exitosamente", "Atencion...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(_estanteriaDAL._errorMsg, "Atencion...", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ResetForm();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se eliminara el tipo estante seleccionado.¿Desea continuar?", "Atencion...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            Tipo_Estante estanteSelected = (Tipo_Estante)bsTipoEstante.Current;

            if(estanteSelected==null)
            {
                MessageBox.Show("No se selecciono ningún item para ser eliminado", "Atencion...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_estanteriaDAL.EliminarTipoEstante(estanteSelected))
                MessageBox.Show("El tipo estante se elimino exitosamente", "Atencion...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(_estanteriaDAL._errorMsg, "Atencion...", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ResetForm();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        #endregion
    }
}
