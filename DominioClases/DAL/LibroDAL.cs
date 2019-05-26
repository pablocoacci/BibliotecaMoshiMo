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
    public class LibroDAL : Base_DAL
    {
        public LibroDAL(BibliotecaContext unContexto = null) : base(unContexto) { }

        #region Metodos Publicos Libros

        public Libro GetLibroById(int id_Libro)
        {
            return _contexto.Libros.Where(a => a.Id == id_Libro).FirstOrDefault();
        }

        public List<Libro> GetLibros()
        {
            return _contexto.Libros.Where(a => a.Id_Usuario == StaticUserLogin.Id || a.IsPublico).OrderBy(a => a.Titulo).ToList();
        }

        public List<Libro> GetLibroPrueba(ParamBusquedaLibro param, bool incluirPublicos = true)
        {
            var libros = _contexto.Database.SqlQuery<Libro>("").ToList();

            return libros;
        }

        public List<Libro> GetLibros(ParamBusquedaLibro param, bool incluirPublicos = true)
        {
            try
            {
                //var libros = (from l in _contexto.Libros
                //              where
                //              (l.Id_Usuario == StaticUserLogin.Id || l.IsPublico)
                //              && (param.Id_Libro == 0 || (param.Id_Libro != 0 && l.Id == param.Id_Libro))
                //              && (param.Id_Estanteria == 0 || (param.Id_Estanteria != 0 && l.Id_Estanteria == param.Id_Estanteria))
                //              && (param.Id_Tipo_Estante == 0 || (param.Id_Tipo_Estante != 0 && l.Estanteria.Id_Tipo_Estante == param.Id_Tipo_Estante))
                //              && (param.TituloLibro == "" || (param.TituloLibro != "" && l.Titulo.ToUpper().Contains(param.TituloLibro.ToUpper())))
                //              select l).OrderBy(a => a.Titulo).ToList();

                string query = string.Format("select l.Id " +
"from Libros l " +
"inner join Estanterias e on l.Id_Estanteria = e.Id " +
"inner join Usuarios u on l.Id_Usuario = u.Id " +
"left join Capitulos c on l.Id = c.Id_Libro " +
"where " +
"(l.Id_Usuario = {0} or l.IsPublico = 1) " +
"and({1} = 0 or({1} <> 0 and l.Id = {1})) " +
"and({2} = 0 or({2} <> 0 and l.Id_Estanteria = {2})) " +
"and('{3}' = '' or('{3}' <> '' and l.Titulo like '%{3}%')) " +
"and({4} = 0 or({4} <> 0 and c.Id = {4})) " +
"and('{5}' = '' or('{5}' <> '' and c.Titulo like '%{5}%'))", StaticUserLogin.Id, param.Id_Libro, param.Id_Estanteria, param.TituloLibro, param.Id_Capitulo, param.TituloCapitulo);

                List<int> ids_Libros = _contexto.Database.SqlQuery<int>(query).ToList();
                var libros = _contexto.Libros.Where(a => ids_Libros.Contains(a.Id)).ToList();

                if (!incluirPublicos)
                    libros.RemoveAll(a => a.Id_Usuario != StaticUserLogin.Id && a.IsPublico);

                return libros;
            }
            catch (Exception ex)
            {
                StaticFileManager.LogError(ex);
                _errorMsg = "Ocurrio un error al realizar la busqueda";
                return null;
            }
        }

        public List<Libro> GetLibrosFavoritos()
        {
            return _contexto.Libros.Where(a => a.Id_Usuario == StaticUserLogin.Id && a.IsFavorito).ToList();
        }

        public bool MarcarDesmarcarLibroFavorito(Libro unLibro)
        {
            try
            {
                if (unLibro.Id != StaticUserLogin.Id)
                {
                    _errorMsg = "No se puede marcar/Desmarcar como favorito un libro de otro usuario";
                    return false;
                }

                unLibro.IsFavorito = !unLibro.IsFavorito;
                _contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                StaticFileManager.LogError(ex);
                _errorMsg = "Ocurrio un error al marcar el libro como favorito";
                return false;
            }
        }

        public bool Valid(Libro unLibro)
        {
            if (unLibro == null)
            {
                _errorMsg = "El libro es null";
                return false;
            }
            if (unLibro.Titulo == null || unLibro.Titulo == "")
            {
                _errorMsg = "El titulo no puede ser vacio";
                return false;
            }
            if (unLibro.Titulo.Length > 50)
            {
                _errorMsg = "El titulo no puede tener mas de 50 caracteres";
                return false;
            }
            if (unLibro.Descripcion.Length > 250)
            {
                _errorMsg = "La descripcion no puede superar los 250 caracteres";
                return false;
            }
            if (unLibro.Link.Length > 1000)
            {
                _errorMsg = "El link no puede tener mas de 1000 caracteres";
                return false;
            }
            if (unLibro.Estanteria == null)
            {
                _errorMsg = "El campo estanteria es obligatorio";
                return false;
            }
            if (unLibro.Estanteria.Id == 0)
            {
                _errorMsg = "El campo estanteria es obligatorio";
                return false;
            }

            return true;
        }

        public bool IsLibroEliminable(Libro unLibro)
        {
            if (unLibro == null)
            {
                _errorMsg = "El libro no puede ser null";
                return false;
            }

            return true;
        }

        public bool GuardarLibro(Libro unLibro)
        {
            if (unLibro.Descripcion == null)
                unLibro.Descripcion = "";

            try
            {
                if (!Valid(unLibro)) return false;

                if (unLibro.Id == 0)
                    _contexto.Libros.Add(unLibro);

                _contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _errorMsg = "Ocurrio un error al guardar el libro. Ver el LogError";
                StaticFileManager.LogError(ex);
                return false;
            }

        }

        public bool EliminarLibro(Libro unLibro)
        {
            try
            {
                if (!IsLibroEliminable(unLibro)) return false;
                if (unLibro.Id == 0) return true;

                _contexto.Capitulos.RemoveRange(_contexto.Capitulos.Where(a => a.Id_Libro == unLibro.Id));
                _contexto.Libros.Remove(unLibro);
                _contexto.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                _errorMsg = "Ocurrio un error al eliminar el libro. Ver el log Error";
                StaticFileManager.LogError(ex);
                return false;
            }
        }

        #endregion

        #region Metodos Publicos Capitulos

        public List<Capitulo> GetCapitulosByLibro(int id_Libro)
        {
            return _contexto.Capitulos.Where(a => a.Id_Libro == id_Libro).OrderBy(a => a.Titulo).ToList();
        }

        public bool Valid(Capitulo unCapitulo)
        {
            if (unCapitulo == null)
            {
                _errorMsg = "El capitulo no puede ser null";
                return false;
            }
            if (unCapitulo.Id_Libro == 0)
            {
                _errorMsg = "El capitulo debe tener un libro asociado";
                return false;
            }
            if (unCapitulo.Titulo == "" || unCapitulo.Titulo == null)
            {
                _errorMsg = "El campo titulo del capitulo es obligatorio";
                return false;
            }
            if (unCapitulo.Titulo.Length > 50)
            {
                _errorMsg = "El titulo del capitulo no puede superar los 50 caracteres";
                return false;
            }

            return true;
        }

        public bool GuardarCapitulo(Capitulo unCapitulo/*,string textoRTF*/)
        {
            try
            {
                Libro libro = _contexto.Libros.Where(a => a.Id == unCapitulo.Id_Libro).FirstOrDefault();

                if (libro == null)
                    throw new Exception("No se encontro el libro. Error al guardar el nuevo capitulo");

                if (!Valid(unCapitulo)) return false;

                if (unCapitulo.Id == 0)
                {
                    _contexto.Capitulos.Add(unCapitulo);
                    libro.Total_Capitulos++;
                }
                //else
                //{
                //    if (!StaticFileManager.DeleteRTFDoc(unCapitulo.DocPath))
                //        throw new Exception("Ocurrio un error mientras generaba/actualizaba el documento rtf");
                //}

                unCapitulo.DocPath = "";
                //string docPath = StaticFileManager.SaveRTFDoc(libro.Estanteria.Titulo_Estante, libro.Titulo, unCapitulo.Titulo, textoRTF);
                //if (docPath != "")
                //    unCapitulo.DocPath = docPath;
                //else
                //    throw new Exception("Ocurrio un error mientras generaba/actualizaba el documento rtf");

                _contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                StaticFileManager.LogError(ex);
                _errorMsg = "Ocurrio un error al guardar el capitulo. Ver el LogError";
                return false;
            }
        }

        public bool IsCapituloEliminable(Capitulo unCapitulo)
        {
            if (unCapitulo == null)
            {
                _errorMsg = "El capitulo no puede ser null";
                return false;
            }

            return true;
        }

        public bool EliminarCapitulo(Capitulo unCapitulo)
        {
            try
            {
                if (!IsCapituloEliminable(unCapitulo)) return false;
                if (unCapitulo.Id == 0) return true;

                Libro unLibro = this.GetLibroById(unCapitulo.Id_Libro);
                unLibro.Total_Capitulos--;
                if (unLibro.Total_Capitulos < 0) unLibro.Total_Capitulos = 0;

                if (!StaticFileManager.DeleteRTFDoc(unCapitulo.DocPath))
                    throw new Exception("Ocurrio un error cuando se intento eliminar el documento rtf del disco");

                _contexto.Capitulos.Remove(unCapitulo);
                _contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                StaticFileManager.LogError(ex);
                _errorMsg = "Ocurrio un error al eliminar el capitulo. Ver el LogError";
                return false;
            }
        }

        #endregion

        public class ParamBusquedaLibro
        {
            public int Id_Libro { get; set; }
            public int Id_Estanteria { get; set; }
            public int Id_Tipo_Estante { get; set; }
            public string TituloLibro { get; set; }
            //public bool IsFavorito { get; set; }
            public int Id_Capitulo { get; set; }
            public string TituloCapitulo { get; set; }

            public ParamBusquedaLibro()
            {
                Id_Libro = 0;
                Id_Estanteria = 0;
                Id_Tipo_Estante = 0;
                TituloLibro = "";
                Id_Capitulo = 0;
                TituloCapitulo = "";
            }
        }
    }
}
