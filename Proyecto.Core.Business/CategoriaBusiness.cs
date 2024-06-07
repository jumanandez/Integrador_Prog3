using Proyecto.Core.Configurations;
using Proyecto.Core.Data;
using Proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Core.Business
{
	public class CategoriaBusiness
	{
		private readonly ProjectRepository _projetRepository;
		public Config config = new();
		public CategoriaBusiness()
		{
			config.ConnectionString = "Persist Security Info=True;Initial Catalog=IntegradorProg3;Data Source=.; Application Name=DemoApp; Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True;";
			_projetRepository = new ProjectRepository(config);
		}
		public List<Categoria> GetAll()
		{
			return _projetRepository.GetCategorias();
		}

		public bool Add(Categoria categoriaNueva)
		{
			return _projetRepository.AddCategoría(categoriaNueva);
		}
	}
}
