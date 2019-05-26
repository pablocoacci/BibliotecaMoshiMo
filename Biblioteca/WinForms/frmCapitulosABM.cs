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
    public partial class frmCapitulosABM : Form
    {
        private LibroDAL _libroDAL = new LibroDAL();
        private Libro _libroSelect;

        public frmCapitulosABM(int id_Libro)
        {
            InitializeComponent();

            _libroSelect = _libroDAL.GetLibroById(id_Libro);

            if (_libroSelect.Id_Usuario != StaticUserLogin.Id)
                InhabilitarControles();
        }

        private void InhabilitarControles()
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnNuevo.Enabled = false;
        }

        private void ResetBindigsForms()
        {
            //_libroDAL.ResetContexto();
            bsListaCapitulos.DataSource = _libroDAL.GetCapitulosByLibro(_libroSelect.Id);
            bsListaCapitulos.ResetBindings(true);
        }

        private void frmCapitulosABM_Load(object sender, EventArgs e)
        {
            this.Text = "Capitulos - Libro Nº " + _libroSelect.Id.ToString() + " - Titulo: " + _libroSelect.Titulo;
            ResetBindigsForms();
        }

        private void grvCapitulos_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Capitulo cap = (Capitulo)bsListaCapitulos.Current;
            if (cap == null) return;
            richTexCapitulo.RtfText = cap.ContenidoCuerpo;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCapituloAddMod frmEditarCap = new frmCapituloAddMod(_libroSelect, _libroDAL._contexto);
            frmEditarCap.ShowDialog();
            ResetBindigsForms();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Capitulo capSelect = (Capitulo)bsListaCapitulos.Current;
            if (capSelect == null) return;

            frmCapituloAddMod frmEditarCap = new frmCapituloAddMod(capSelect, _libroDAL._contexto);
            frmEditarCap.ShowDialog();
            ResetBindigsForms();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se eliminara el capitulo seleccionado.¿Desea continuar?", "Atencion...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            Capitulo capSelect = (Capitulo)bsListaCapitulos.Current;
            if (capSelect == null) return;

            if (_libroDAL.EliminarCapitulo(capSelect))
            {
                MessageBox.Show("El capitulo se ha eliminado exitosamente", "Atencion...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetBindigsForms();
            }
            else
                MessageBox.Show(_libroDAL._errorMsg, "Atencion...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
