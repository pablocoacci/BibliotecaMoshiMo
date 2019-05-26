using DominioClases.Clases;
using DominioClases.Mappings;
using DominioClases.StaticHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioClases.DAL
{
    public class EstanteriaDAL : Base_DAL
    {
        public EstanteriaDAL(BibliotecaContext unContexto = null) : base(unContexto) { }

        #region Metodos Publicos Tipo Estante

        public List<Tipo_Estante> TiposEstantesDataSource { get { return this.GetTiposEstantes(); } }

        public List<Tipo_Estante> GetTiposEstantes()
        {
            return this._contexto.Tipo_Estantes.OrderBy(a => a.Descripcion).ToList();
        }

        public bool Valid(Tipo_Estante tipoEstante)
        {
            if (tipoEstante == null)
            {
                _errorMsg = "El tipo de estante es null";
                return false;
            }
            if (tipoEstante.Descripcion.Length == 0)
            {
                _errorMsg = "La descripcion no puede ser vacia";
                return false;
            }
            if (tipoEstante.Descripcion.Length > 50)
            {
                _errorMsg = "La descripcion no puede superar los 50 caracteres";
                return false;
            }

            return true;
        }

        public bool IsTipoEstanteEliminable(Tipo_Estante tipoEstante)
        {
            if (tipoEstante == null)
            {
                _errorMsg = "El tipo de estante es null";
                return false;
            }
            if (_contexto.Estanterias.Where(a => a.Id_Tipo_Estante == tipoEstante.Id).Count() != 0)
            {
                _errorMsg = "Existen estantes de este tipo. No puede ser eliminado";
                return false;
            }

            return true;
        }

        public bool GuardarTipoEstante(Tipo_Estante tipoEstante)
        {
            try
            {
                if (!Valid(tipoEstante))
                    return false;

                if (tipoEstante.Id == 0)
                    this._contexto.Tipo_Estantes.Add(tipoEstante);

                this._contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _errorMsg = "Ocurrio un error al eliminar el tipo estante. Ver el LogError";
                StaticFileManager.LogError(ex);
                return false;
            }
        }

        public bool EliminarTipoEstante(Tipo_Estante tipoEstante)
        {
            try
            {
                if (tipoEstante.Id == 0) return true;

                if (!this.IsTipoEstanteEliminable(tipoEstante)) return false;

                _contexto.Tipo_Estantes.Remove(tipoEstante);
                _contexto.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                _errorMsg = "Ocurrio un error al eliminar el tipo estante. Ver el LogError";
                StaticFileManager.LogError(ex);
                return false;
            }
        }

        #endregion

        #region Metodos publicos Estanteria

        public List<Estanteria> GetEstanterias()
        {
            return _contexto.Estanterias.OrderBy(a => a.Titulo_Estante).ToList();
        }

        public Estanteria GetEstanteriaById(int id_estante)
        {
            return _contexto.Estanterias.Where(a => a.Id == id_estante).FirstOrDefault();
        }

        public bool Valid(Estanteria unEstante)
        {
            if (unEstante == null)
            {
                _errorMsg = "El estante es null";
                return false;
            }
            if (unEstante.Descripcion.Length > 250)
            {
                _errorMsg = "La descripcion no puede tener mas de 250 caracteres";
                return false;
            }

            if (unEstante.Tipo_Estante == null)
            {
                _errorMsg = "El campo tipo estante es obligatorio";
                return false;
            }
            if(unEstante.Tipo_Estante.Id==0)
            {
                _errorMsg = "El campo tipo estante es obligatorio";
                return false;
            }

            return true;
        }

        public bool IsEstanteEliminable(Estanteria unEstante)
        {
            if (unEstante == null)
            {
                _errorMsg = "El estante es null";
                return false;
            }
            if (unEstante == null)
            {
                _errorMsg = "El estante es null";
                return false;
            }
            if (_contexto.Libros.Where(a => a.Id_Estanteria == unEstante.Id).Count() > 0)
            {
                _errorMsg = "El estante tiene libros asociados. No puede ser eliminado";
                return false;
            }

            return true;
        }

        public bool GuardarEstante(Estanteria unEstante)
        {
            try
            {
                if (!Valid(unEstante)) return false;

                if (unEstante.Id == 0)
                    _contexto.Estanterias.Add(unEstante);

                _contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _errorMsg = "Ocurrio un error mientras se guardan los cambios. Ver el LogError";
                StaticFileManager.LogError(ex);
                return false;
            }
        }

        public bool EliminarEstante(Estanteria unEstante)
        {
            try
            {
                if (!IsEstanteEliminable(unEstante)) return false;

                _contexto.Estanterias.Remove(unEstante);
                _contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _errorMsg = "Ocurrio un error al eliminar el estante. Ver el LogError";
                StaticFileManager.LogError(ex);
                return false;
            }
        }

        #endregion
    }
}
