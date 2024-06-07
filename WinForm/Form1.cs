using Proyecto.Core.Business;
using Proyecto.Core.Entities;
namespace WinForm
{
	public partial class Form1 : Form
	{
		private CategoriaBusiness _categorķaBusiness;
		public Form1()
		{
			InitializeComponent();
			_categorķaBusiness = new CategoriaBusiness();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string nombreCategoria = txtNombreCategoria.Text;

			Categoria categoriaNueva = new Categoria
			{
				Nombre = nombreCategoria
			};

			lblResultado.Text = _categorķaBusiness.Add(categoriaNueva).ToString();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = _categorķaBusiness.GetAll();
		}

		private void lblResultado_Click(object sender, EventArgs e)
		{
			lblResultado.Text = "Resultado...";
		}
	}
}
