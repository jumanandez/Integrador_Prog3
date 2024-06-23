using Proyecto.Core.Business.Interfaces;
using Proyecto.Core.Data.Interfaces;
using Proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Core.Business
{
    public class UsuarioBusiness : IUsuarioBusiness
    {
        private readonly IProjectRepository _projectRepository;

        public UsuarioBusiness(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public bool CompareUserToDB(string Username)
        {
            return _projectRepository.CompareUserToDB(Username);
        }
        public byte[] GetUsuarioHash(string Username)
        {
            return _projectRepository.GetUsuarioHash(Username);
        }
        public byte[] GetUsuarioSalt(string Username)
        {
            return _projectRepository.GetUsuarioSalt(Username);
        }
        public bool ? ChangePass(string username, string passwordActual, string  passwordNueva)
        {
            var usuarioAux = ObtainUsuario(username);

            if (usuarioAux != null)
            {
                var hashGenerado = CryptoHelper.HashPassword(passwordActual, usuarioAux.Salt);

                var coincideConDB = hashGenerado.SequenceEqual(usuarioAux.HashPassword);

                if (coincideConDB)
                {
                    usuarioAux.HashPassword = CryptoHelper.HashPassword(passwordNueva, CryptoHelper.GenerateSalt());

                    return _projectRepository.ChangePass(usuarioAux);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return null;
            }	
        }
        public Usuario ObtainUsuario(string Username)
        {
            return _projectRepository.ObtainUsuario(Username);
        }
		public bool CreateUsuario(string userName, string password)
		{
            if (CompareUserToDB(userName))
            {
                return false;
            }
            else
            {
                var saltBytes = CryptoHelper.GenerateSalt();

                byte[] hashedPassword = CryptoHelper.HashPassword(password, saltBytes);

                return _projectRepository.CreateUser(userName, hashedPassword, saltBytes);
            }
		}

        public List<Usuario> GetAllUsuarios()
        {
            return _projectRepository.GetAllUsuarios();
        }

    }
}
