using Microsoft.Extensions.Logging;
using Proyecto.Core.Business;
using Proyecto.Core.Business.Interfaces;
using Proyecto.Core.Entities;
namespace WinForm
{
	//public partial class Form1 : Form
	//{
	//	private readonly ILogger _logger;
	//	private readonly ICatergoriaBusiness _categor�aBusiness;
	//	public Form1(ILogger<Form1> logger, ICatergoriaBusiness business)
	//	{
	//		_logger = logger;
	//		_categor�aBusiness = business;
	//		InitializeComponent();
	//	}

	//	private void button1_Click(object sender, EventArgs e)
	//	{
	//		string nombreCategoria = txtNombreCategoria.Text;

	//		Categoria categoriaNueva = new Categoria
	//		{
	//			Nombre = nombreCategoria
	//		};

	//		lblResultado.Text = _categor�aBusiness.Add(categoriaNueva).ToString();
	//	}

	//	private void Form1_Load(object sender, EventArgs e)
	//	{

	//	}

	//	private void btnRefresh_Click(object sender, EventArgs e)
	//	{
	//		dataGridView1.DataSource = _categor�aBusiness.GetAll();
	//	}

	//	private void lblResultado_Click(object sender, EventArgs e)
	//	{
	//		lblResultado.Text = "Resultado...";
	//	}
	//}
}
