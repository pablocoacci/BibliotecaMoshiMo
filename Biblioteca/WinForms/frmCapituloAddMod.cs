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

namespace Biblioteca.WinForms
{
    public partial class frmCapituloAddMod : Form
    {
        private LibroDAL _libroDAL;
        private Libro _libro;
        private Capitulo _capitulo;
        //private Libro _libroSelect;

        public frmCapituloAddMod(Capitulo cap, BibliotecaContext contexto)
        {
            InitializeComponent();

            _capitulo = cap;
            _libroDAL = new LibroDAL(contexto);
            _libro = _libroDAL.GetLibroById(cap.Id_Libro);
        }

        public frmCapituloAddMod(Libro libro, BibliotecaContext contexto)
        {
            InitializeComponent();
            _libro = libro;
            _libroDAL = new LibroDAL(contexto);

            _capitulo = new Capitulo();
        }

        public frmCapituloAddMod(int id_Libro, BibliotecaContext contexto)
        {
            InitializeComponent();
            
            _libroDAL = new LibroDAL(contexto);
            _libro = _libroDAL.GetLibroById(id_Libro);
            _capitulo = new Capitulo();
        }

        private void btnGuardarCapitulo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_capitulo.Id == 0)
            {
                _capitulo.Id_Libro = _libro.Id;
                _capitulo.Fecha_Add = DateTime.Now;
            }

            _capitulo.ContenidoCuerpo = richTextCapitulo.RtfText;
            _capitulo.Titulo = txtTitulo.Text;
            //_capitulo.Cuerpo = richTextCapitulo.RtfText;

            if (_libroDAL.GuardarCapitulo(_capitulo))
            {
                MessageBox.Show("El capitulo se ha guardado exitosamente", "Atencion...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show(_libroDAL._errorMsg, "Atencion...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmNuevoCapitulo_Load(object sender, EventArgs e)
        {
            this.Text = "Capitulo - Libro Id Nº " + _libro.Id.ToString() + " - Titulo: " + _libro.Titulo;

            if(_capitulo.Id!=0)
            {
                txtTitulo.Text = _capitulo.Titulo;
                richTextCapitulo.RtfText = _capitulo.ContenidoCuerpo;
            }
        }
    }
}
