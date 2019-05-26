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
    public partial class frmEstanteABM : Form
    {
        private EstanteriaDAL _estanteriaDAL = new EstanteriaDAL();
        private Estanteria _unEstante;

        public frmEstanteABM(int id_Estante = 0)
        {
            InitializeComponent();

            if (id_Estante == 0)
                _unEstante = new Estanteria();
            else
                _unEstante = _estanteriaDAL.GetEstanteriaById(id_Estante);
        }

        private void frmEstanteABM_Load(object sender, EventArgs e)
        {
            List<Tipo_Estante> tipoEstantes = new List<Tipo_Estante>();
            tipoEstantes.Add(new Tipo_Estante { Id = 0, Descripcion = "" });
            tipoEstantes.AddRange(_estanteriaDAL.GetTiposEstantes());
            cboTipoEstante.DataSource = tipoEstantes;
            bsEstante.DataSource = _unEstante;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(_estanteriaDAL.GuardarEstante(_unEstante))
            {
                MessageBox.Show("Los cambios fueron guardados exitosamente", "Atencion...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show(_estanteriaDAL._errorMsg, "Atencion...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
