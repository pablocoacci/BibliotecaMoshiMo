using Biblioteca.WinForms;
using DominioClases.Clases;
using DominioClases.DAL;
using DominioClases.Mappings;
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
    public partial class frmMain : Form
    {
        private BibliotecaContext _contexto;
        private EstanteriaDAL _estanteriaDAL;
        private LibroDAL _librosDAL;

        public frmMain()
        {
            InitializeComponent();
        }

        private void ResetBingigsForms()
        {
            _contexto = new BibliotecaContext();
            _estanteriaDAL = new EstanteriaDAL(_contexto);
            _librosDAL = new LibroDAL(_contexto);

            bsListaEstantes.DataSource = _estanteriaDAL.GetEstanterias();
            RecargarGrillaLibros();
        }

        private void RecargarGrillaLibros()
        {
            Estanteria estanteriaSelect = (Estanteria)bsListaEstantes.Current;
            if (estanteriaSelect == null) return;

            LibroDAL.ParamBusquedaLibro paramBusqueda = new LibroDAL.ParamBusquedaLibro() { Id_Estanteria = estanteriaSelect.Id };
            List<Libro> libros = _librosDAL.GetLibros(paramBusqueda);
            bsListaLibros.DataSource = libros;
            bsListaLibros.ResetBindings(true);

            if (libros.Count > 0)
                bsLibroSelect.DataSource = libros.FirstOrDefault();
            else
                bsLibroSelect.Clear();

            bsLibroSelect.ResetBindings(true);

        }

        private void EditarEstante()
        {
            Estanteria estanteSelect = (Estanteria)bsListaEstantes.Current;

            if (estanteSelect == null) return;

            frmEstanteABM frmEstantes = new frmEstanteABM(estanteSelect.Id);
            frmEstantes.ShowDialog();
            ResetBingigsForms();
        }

        private void EditarLibro()
        {
            Libro libroSelect = (Libro)bsListaLibros.Current;

            if (libroSelect == null) return;

            frmLibrosABM frmLibros = new frmLibrosABM(libroSelect.Id);
            frmLibros.ShowDialog();
            ResetBingigsForms();

            bsLibroSelect.DataSource = _librosDAL.GetLibroById(libroSelect.Id);
            bsLibroSelect.ResetBindings(true);
        }

        private void btnTipoEstanteAddMod_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTipoEstanteABM frmTipoEstante = new frmTipoEstanteABM();
            frmTipoEstante.ShowDialog();
        }

        private void btnEstante_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEstanteABM frmEstantes = new frmEstanteABM();
            frmEstantes.ShowDialog();
            ResetBingigsForms();
        }

        private void btnModificarEstante_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditarEstante();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = "Biblioteca MoshiMo - Bienvenido " + StaticUserLogin.Nombre;
            ResetBingigsForms();
        }

        private void btnUsuarios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUsuariosABM frmUsuarios = new frmUsuariosABM();
            frmUsuarios.ShowDialog();
        }

        private void btnEliminarEstante_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Estanteria estanteSelect = (Estanteria)bsListaEstantes.Current;
            if (estanteSelect == null) return;
            if (MessageBox.Show("Se eliminara el estante seleccionado.¿Desea continuar", "Atencion...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            if (_estanteriaDAL.EliminarEstante(estanteSelect))
                MessageBox.Show("El estante fue eliminado exitosamente", "Atencion...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(_estanteriaDAL._errorMsg, "Atencion...", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ResetBingigsForms();
        }

        private void btnNuevoLibro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLibrosABM frmLibros = new frmLibrosABM();
            frmLibros.ShowDialog();
            ResetBingigsForms();
        }

        private void grvEstanteria_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            RecargarGrillaLibros();
        }

        private void grvLibros_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Libro libroSelect = (Libro)bsListaLibros.Current;
            if (libroSelect == null) return;
            bsLibroSelect.DataSource = libroSelect;
            bsLibroSelect.ResetBindings(true);
        }

        private void btnEditarLibro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditarLibro();
        }

        private void btnEliminarLibro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Libro libroSelect = (Libro)bsListaLibros.Current;
            if (libroSelect == null) return;
            if (MessageBox.Show("Se eliminará el libro seleccionado junto con todos sus capitulos.¿Deasea Continuar?", "Atencion...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            if (_librosDAL.EliminarLibro(libroSelect))
            {
                MessageBox.Show("El libro y sus capitulos se han eliminado exitosamente", "Atencion...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetBingigsForms();
            }
            else
                MessageBox.Show(_librosDAL._errorMsg, "Atencion...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnVerCapitulo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Libro libroSelect = (Libro)bsListaLibros.Current;
            if (libroSelect == null)
            {
                MessageBox.Show("No se ha seleccionado ningun libro", "Atencion...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmCapitulosABM frmCapitulos = new frmCapitulosABM(libroSelect.Id);
            frmCapitulos.ShowDialog();
            ResetBingigsForms();
        }

        private void lnkLibro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(lnkLibro.Text);
        }

        private void grvEstanteria_DoubleClick(object sender, EventArgs e)
        {
            EditarEstante();
        }

        private void grvLibros_DoubleClick(object sender, EventArgs e)
        {
            EditarLibro();
        }

        private void btnLibroFavorito_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Libro libroSelect = (Libro)bsListaLibros.Current;

            if (libroSelect == null) return;

            if (libroSelect.Id_Usuario != StaticUserLogin.Id)
            {
                MessageBox.Show("No se puede marcar/Desmarcar como favorito un libro de otro usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Desea marcar/desmarcar el libro como favorito?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            bool succes = _librosDAL.MarcarDesmarcarLibroFavorito(libroSelect);

            if (succes)
                MessageBox.Show("El libro se ha marcado/desmarcado exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Ha ocurrido un error al marcar/desmarcar el libro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBuscarLibro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBuscadorLibros frm = new frmBuscadorLibros(frmBuscadorLibros.EnumModoFormulario.BuscarLibro);
            frm.ShowDialog();

            ResetBingigsForms();
        }

        private void btnVerLibrosFavoritos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBuscadorLibros frm = new frmBuscadorLibros(frmBuscadorLibros.EnumModoFormulario.VerFavoritos);
            frm.ShowDialog();

            ResetBingigsForms();
        }

        private void btnVerRepositorioDocs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string path = @"";
            path = StaticParameters.DocumentosPATH + "\\" + StaticUserLogin.Id.ToString();

            try
            {
                System.Diagnostics.Process.Start(path);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Aun no se a creado un repositorio para este usuario. Debe crear al menos un capitulo a algún libro.", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnVerLogError_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string path = @"";
            path = System.IO.Directory.GetCurrentDirectory() + "\\LogError";

            try
            {
                System.Diagnostics.Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aun no existe la carpeta Log Error. No ha ocurrido ningun error en la aplicacion", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
