using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Core.Configurations
{
	//La connectionString para su JSON
	//"Persist Security Info=True;Initial Catalog=IntegradorProg3;Data Source=.; Application Name=DemoApp; Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True;"
	public class Config
	{
		public string ConnectionString { get; set; }
	}
}
