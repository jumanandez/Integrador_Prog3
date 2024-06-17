using Proyecto.Core.Business.Interfaces;
using Proyecto.Core.Configurations;
using Proyecto.Core.Data;
using Proyecto.Core.Data.Interfaces;
using Proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Core.Business
{
	public class CategoriaBusiness : ICategoriaBusiness
	{
        private readonly IProjectRepository _projectRepository;

        public CategoriaBusiness(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public List<Categoria> GetAll()
        {
          return _projectRepository.GetCategorias();
        }

        public bool Add(Categoria categoriaNueva)
        {
			    return _projectRepository.AddCategoria(categoriaNueva);
        }
	}
}
