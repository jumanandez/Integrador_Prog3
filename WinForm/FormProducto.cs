using Proyecto.Core.Business;
using Proyecto.Core.Configurations;
using Proyecto.Core.Data;
using Proyecto.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
	public partial class FormProducto : Form
	{
		private CategoriaBusiness _categoríaBusiness;
		private ProductoBusiness _productoBusiness;
		private ProjectRepository _projectRepository;
		private Config _config;
		private Producto _productoACargar;
		public FormProducto()
		{
			_config = new Config
			{
				ConnectionString = "Persist Security Info=True;Initial Catalog=IntegradorProg3;Data Source=.; Application Name=DemoApp; Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True;"
			};

			InitializeComponent();
			_projectRepository = new ProjectRepository(_config);
			_categoríaBusiness = new CategoriaBusiness();
			_productoACargar = new Producto();
		}

		private void FormProducto_Load(object sender, EventArgs e)
		{

			_projectRepository = new ProjectRepository(_config);

			_productoBusiness = new ProductoBusiness(_projectRepository);

			cmbBoxCategorias.DataSource = _categoríaBusiness.GetAll();
			cmbBoxCategorias.DisplayMember = "Nombre";

			dataGridViewProducto.DataSource = _productoBusiness.GetAll();
		}

		private void cmbBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
		{
			_productoACargar.CategoriaId = ((Categoria)cmbBoxCategorias.SelectedItem).CategoriaId;
		}

		private void btnCargarProducto_Click(object sender, EventArgs e)
		{
			_productoACargar.Nombre = txtNombreProducto.Text;
			_productoBusiness.AddProducto(_productoACargar);

		}

		private void btnRefrescar_Click(object sender, EventArgs e)
		{
			dataGridViewProducto.DataSource = _productoBusiness.GetAll();
		}
	}
}
