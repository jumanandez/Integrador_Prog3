using Microsoft.Extensions.Logging;
using Proyecto.Core.Business;
using Proyecto.Core.Business.Interfaces;
using Proyecto.Core.Data.Interfaces;
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
        private readonly ILogger _logger;
        private readonly ICatergoriaBusiness _categoríaBusiness;
        private readonly IProductoBusiness _productoBusiness;
        //private readonly IProjectRepository _projectRepository;
        private Producto _productoACargar;
		public FormProducto(ILogger<FormProducto> logger, ICatergoriaBusiness catbusi, IProductoBusiness produbusi/*, IProjectRepository prorepo*/)
		{
            _logger = logger;
            _categoríaBusiness = catbusi;
			//_projectRepository = prorepo;
			_productoBusiness = produbusi;
            _productoACargar = new Producto();
            InitializeComponent();
        }

		private void FormProducto_Load(object sender, EventArgs e)
		{


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
