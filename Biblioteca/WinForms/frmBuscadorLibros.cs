using DominioClases.Clases;
using DominioClases.DAL;
using DominioClases.Mappings;
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
    public partial class frmBuscadorLibros : Form
    {
        public enum EnumModoFormulario { BuscarLibro, VerFavoritos };

        private LibroDAL _libroDal;
        private LibroDAL.ParamBusquedaLibro _paramBusqueda;
        private EnumModoFormulario _modoFormulario;

        public frmBuscadorLibros(EnumModoFormulario modo)
        {
            InitializeComponent();

            _modoFormulario = modo;
            _libroDal = new LibroDAL();
            _paramBusqueda = new LibroDAL.ParamBusquedaLibro();
        }

        private void RefresehBindings()
        {
            _libroDal.ResetContexto();

            if (_modoFormulario == EnumModoFormulario.BuscarLibro)
                BuscarLibroSegunParametros();
            else
                VerLibrosFavoritos();
        }

        private void BuscarLibroSegunParametros()
        {
            List<Libro> librosSearch = _libroDal.GetLibros(_paramBusqueda);
            bsListaLibros.DataSource = librosSearch;
            bsListaLibros.ResetBindings(true);
        }

        private void VerLibrosFavoritos()
        {
            List<Libro> librosSearch = _libroDal.GetLibrosFavoritos();
            bsListaLibros.DataSource = librosSearch;
            bsListaLibros.ResetBindings(true);
        }

        private void frmBuscadorLibros_Load(object sender, EventArgs e)
        {
            List<Estanteria> listaEstantes = new List<Estanteria>();
            listaEstantes.Add(new Estanteria() { Id = 0, Titulo_Estante = "" });
            listaEstantes.AddRange(_libroDal._contexto.Estanterias.ToList());
            cboEstante.DataSource = listaEstantes;
            bsParamBusqueda.DataSource = _paramBusqueda;

            if (_modoFormulario == EnumModoFormulario.VerFavoritos)
            {
                panelBusqueda.Visible = false;
                VerLibrosFavoritos();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarLibroSegunParametros();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            _paramBusqueda = new LibroDAL.ParamBusquedaLibro();
            bsParamBusqueda.DataSource = _paramBusqueda;
            bsParamBusqueda.ResetBindings(true);
        }

        private void verCapitulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Libro libroSelect = (Libro)bsListaLibros.Current;
            if (libroSelect == null) return;
            frmLibrosABM frm = new frmLibrosABM(libroSelect.Id);
            frm.ShowDialog();

            RefresehBindings();
        }

        private void verCapitulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Libro libroSelect = (Libro)bsListaLibros.Current;
            if (libroSelect == null) return;
            frmCapitulosABM frm = new frmCapitulosABM(libroSelect.Id);
            frm.ShowDialog();

            RefresehBindings();
        }
    }
}
