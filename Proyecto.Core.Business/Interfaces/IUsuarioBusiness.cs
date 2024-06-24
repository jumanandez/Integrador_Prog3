using Proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Core.Business.Interfaces
{
    public interface IUsuarioBusiness
    {
        public bool CompareUserToDB(string Username);
        public byte[] GetUsuarioHash(string Username);

        public byte[] GetUsuarioSalt(string Username);
        public Usuario ObtainUsuario(string Username);
        public bool CreateUsuario(string userName, string password);

        public bool? ChangePass(string username, string passwordActual, string passwordNueva);
        List<Usuario> GetAllUsuarios();
    }
}
