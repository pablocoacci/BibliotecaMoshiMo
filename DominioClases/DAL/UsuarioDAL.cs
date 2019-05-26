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
    public class UsuarioDAL : Base_DAL
    {
        public UsuarioDAL(BibliotecaContext unContexto = null) : base(unContexto) { }

        #region Metodos Publicos Usuario

        public Usuario LoginUser(string nombre, string pass)
        {
            if (nombre == "" || pass == "")
            {
                _errorMsg = "El nombre o la contraseña son incorrectos";
                return null;
            }

            Usuario user = _contexto.Usuarios.Where(a => a.Nombre.ToUpper() == nombre.ToUpper()).FirstOrDefault();
            if (user == null)
            {
                _errorMsg = "El nombre o la contraseña son incorrectos";
                return null;
            }

            if (user.Password != pass)
            {
                _errorMsg = "El nombre o la contraseña son incorrectos";
                return null;
            }

            return user;
        }

        public Usuario GetUserById(int id_usuario)
        {
            return _contexto.Usuarios.Where(a => a.Id == id_usuario).FirstOrDefault();
        }

        public List<Usuario> GetUsuarios()
        {
            return _contexto.Usuarios.OrderBy(a => a.Nombre).ToList();
        }

        public bool Valid(Usuario user)
        {
            if (user == null)
            {
                _errorMsg = "El usuario es null";
                return false;
            }
            if (user.Nombre == "")
            {
                _errorMsg = "El nombre no puede ser vacio";
                return false;
            }
            if (user.Nombre.Length > 50)
            {
                _errorMsg = "El nombre no puede superar los 50 caracteres";
                return false;
            }
            if (user.Password == "")
            {
                _errorMsg = "El password no puede ser vacio";
                return false;
            }
            if (user.Password.Length > 50)
            {
                _errorMsg = "El password no puede superar los 50 caracteres";
                return false;
            }
            if (_contexto.Usuarios.Where(a => a.Nombre.ToUpper() == user.Nombre.ToUpper()).Count() > 0)
            {
                _errorMsg = "Ya existe un usuario con el mismo nombre";
                return false;
            }

            return true;
        }

        public bool IsEliminable(Usuario user)
        {
            if (user == null)
            {
                _errorMsg = "El usuario es null";
                return false;
            }
            if (_contexto.Libros.Where(a => a.Id_Usuario == user.Id).Count() > 0)
            {
                _errorMsg = "El usuario no puede ser eliminado ya que es autor de algunos libros";
                return false;
            }

            return true;
        }

        public bool GuardarUsuario(Usuario user)
        {
            try
            {
                if (!Valid(user))
                    return false;

                if (user.Id == 0)
                    _contexto.Usuarios.Add(user);

                _contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                StaticFileManager.LogError(ex);
                _errorMsg = "Ocurrio un error mientras se guardaba el usuario. Ver LogError";
                return false;
            }
        }

        public bool EliminarUsuario(Usuario user)
        {
            try
            {
                if (user.Id == 0) return true;
                if (!IsEliminable(user)) return false;

                _contexto.Usuarios.Remove(user);
                _contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                StaticFileManager.LogError(ex);
                _errorMsg = "Ocurrio un error al eliminar al usuario. Ver LogError";
                return false;
            }
        }

        #endregion
    }
}
