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
    public partial class frmLibrosABM : Form
    {
        private LibroDAL _libroDAL = new LibroDAL();

        public frmLibrosABM()
        {
            InitializeComponent();

            UsuarioDAL userDAL = new UsuarioDAL(_libroDAL._contexto);
            Usuario user = userDAL.GetUserById(StaticUserLogin.Id);
            Libro nuevoLibro = new Libro() { Id_Usuario = user.Id, Usuario = user, Fecha_Add = DateTime.Now };
            bsLibro.DataSource = nuevoLibro;
        }

        public frmLibrosABM(int id_Libro)
        {
            InitializeComponent();

            Libro unLibro = _libroDAL.GetLibroById(id_Libro);

            if (unLibro == null)
            {
                MessageBox.Show("El libro no puede ser null", "Atencion...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (unLibro.Id_Usuario != StaticUserLogin.Id)
                InhabilitarControles();

            bsLibro.DataSource = unLibro;
        }

        private void InhabilitarControles()
        {
            txtTitulo.Enabled = false;
            txtDescripcion.Enabled = false;
            txtLink.Enabled = false;
            cboEstanteria.Enabled = false;
            chkPublico.Enabled = false;
        }


        private void frmLibrosABM_Load(object sender, EventArgs e)
        {
            EstanteriaDAL estatenriaDAL = new EstanteriaDAL(_libroDAL._contexto);
            List<Estanteria> dtEstanteria = new List<Estanteria>();
            dtEstanteria.Add(new Estanteria() { Id = 0, Descripcion = "" });
            dtEstanteria.AddRange(estatenriaDAL.GetEstanterias());
            cboEstanteria.DataSource = dtEstanteria;

            bsLibro.ResetBindings(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Validate();
            Libro unLibro = (Libro)bsLibro.Current;

            if (_libroDAL.GuardarLibro(unLibro))
            {
                MessageBox.Show("El libro se ha guardado exitosamente", "Atencion...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show(_libroDAL._errorMsg, "Atencion...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
