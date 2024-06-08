using Proyecto.Core.Business.Interfaces;
using Proyecto.Core.Data;
using Proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Core.Business
{
    public class CompraBusiness : ICompraBusiness
    {
        private readonly ProjectRepository _projectRepository;

        public CompraBusiness(ProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public void AddCompra(Compra compra)
        {
            _projectRepository.AddCompra(compra);
        }

        public List<Compra> GetCompras()
        {
            return _projectRepository.GetCompras();
        }

        public void DeleteCompra(int id)
        {
            _projectRepository.DeleteCompra(id);
        }

    }
}
