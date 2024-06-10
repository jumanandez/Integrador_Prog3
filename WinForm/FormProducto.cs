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
		private readonly ICategoriaBusiness _categoríaBusiness;
		private readonly IProductoBusiness _productoBusiness;
		//private readonly IProjectRepository _projectRepository;
		private Producto _productoACargar;
		public FormProducto(ILogger<FormProducto> logger, ICategoriaBusiness catbusi, IProductoBusiness produbusi/*, IProjectRepository prorepo*/)
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

		//DESCOMENTAR LA REGION PARA CARGAR SUS PRODUCTOS

		#region BOTON DE PRIMERA CARGA
		private void btnPrimerCarga_Click(object sender, EventArgs e)
		{
			var categorias = _categoríaBusiness.GetAll();

			var idMotor = categorias[0].CategoriaId;
			var productos = new List<Producto>();

			#region PRIMERA CARGA DE PRODUCTOS
			productos.Add(new Producto { Nombre = "Pistones", CategoriaId = idMotor });
			productos.Add(new Producto { Nombre = "Bloque del motor", CategoriaId = idMotor });
			productos.Add(new Producto { Nombre = "Cilindros", CategoriaId = idMotor }); productos.Add(new Producto { Nombre = "Pistones", CategoriaId = idMotor });
			productos.Add(new Producto { Nombre = "Bielas", CategoriaId = idMotor });
			productos.Add(new Producto { Nombre = "cigueñal", CategoriaId = idMotor });
			productos.Add(new Producto { Nombre = "Correa de distribución", CategoriaId = idMotor });
			productos.Add(new Producto { Nombre = "Cadena de distribución", CategoriaId = idMotor });
			productos.Add(new Producto { Nombre = "Engranajes", CategoriaId = idMotor });
			productos.Add(new Producto { Nombre = "Tensores", CategoriaId = idMotor });

			productos.Add(new Producto { Nombre = "Bujías", CategoriaId = idMotor });
			productos.Add(new Producto { Nombre = "Bobinas de encendido", CategoriaId = idMotor });
			productos.Add(new Producto { Nombre = "Distribuidor", CategoriaId = idMotor });
			productos.Add(new Producto { Nombre = "Cables de bujías", CategoriaId = idMotor });

			productos.Add(new Producto { Nombre = "Bomba de combustible", CategoriaId = idMotor });
			productos.Add(new Producto { Nombre = "Inyectores", CategoriaId = idMotor });
			productos.Add(new Producto { Nombre = "Filtros de combustible", CategoriaId = idMotor });
			productos.Add(new Producto { Nombre = "Carburador", CategoriaId = idMotor });
			productos.Add(new Producto { Nombre = "Riel de inyección", CategoriaId = idMotor });

			productos.Add(new Producto { Nombre = "Colectores de escape", CategoriaId = idMotor });
			productos.Add(new Producto { Nombre = "Silenciador", CategoriaId = idMotor });
			productos.Add(new Producto { Nombre = "Catalizador", CategoriaId = idMotor });
			productos.Add(new Producto { Nombre = "Tubo de escape", CategoriaId = idMotor });

			productos.Add(new Producto { Nombre = "Bomba de aceite", CategoriaId = idMotor });
			productos.Add(new Producto { Nombre = "Filtro de aceite", CategoriaId = idMotor });
			productos.Add(new Producto { Nombre = "Cárter de aceite", CategoriaId = idMotor });

			productos.Add(new Producto { Nombre = "Radiador", CategoriaId = idMotor });
			productos.Add(new Producto { Nombre = "Ventilador", CategoriaId = idMotor });
			productos.Add(new Producto { Nombre = "Bomba de agua", CategoriaId = idMotor });
			productos.Add(new Producto { Nombre = "Termostato", CategoriaId = idMotor });
			productos.Add(new Producto { Nombre = "Mangueras de refrigeración", CategoriaId = idMotor });

			var idTransmision = categorias[1].CategoriaId;


			productos.Add(new Producto { Nombre = "Engranajes", CategoriaId = idTransmision });
			productos.Add(new Producto { Nombre = "Ejes", CategoriaId = idTransmision });
			productos.Add(new Producto { Nombre = "Sincronizadores", CategoriaId = idTransmision });
			productos.Add(new Producto { Nombre = "Rodamientos", CategoriaId = idTransmision });

			productos.Add(new Producto { Nombre = "Disco de embrague", CategoriaId = idTransmision });
			productos.Add(new Producto { Nombre = "Placa de presión", CategoriaId = idTransmision });
			productos.Add(new Producto { Nombre = "Volante", CategoriaId = idTransmision });
			productos.Add(new Producto { Nombre = "Cable de embrague", CategoriaId = idTransmision });
			productos.Add(new Producto { Nombre = "Cilindro maestro", CategoriaId = idTransmision });
			productos.Add(new Producto { Nombre = "Cilindro esclavo", CategoriaId = idTransmision });

			productos.Add(new Producto { Nombre = "Árbol de transmisión", CategoriaId = idTransmision });
			productos.Add(new Producto { Nombre = "Juntas universales", CategoriaId = idTransmision });
			productos.Add(new Producto { Nombre = "Cojinetes", CategoriaId = idTransmision });

			var idSistema = categorias[2].CategoriaId;


			productos.Add(new Producto { Nombre = "Batería", CategoriaId = idSistema });
			productos.Add(new Producto { Nombre = "Cables de batería", CategoriaId = idSistema });
			productos.Add(new Producto { Nombre = "Conectores", CategoriaId = idSistema });

			productos.Add(new Producto { Nombre = "Alternador", CategoriaId = idSistema });
			productos.Add(new Producto { Nombre = "Motor de arranque", CategoriaId = idSistema });
			productos.Add(new Producto { Nombre = "Relés", CategoriaId = idSistema });
			productos.Add(new Producto { Nombre = "Solenoide", CategoriaId = idSistema });

			productos.Add(new Producto { Nombre = "Faros delanteros", CategoriaId = idSistema });
			productos.Add(new Producto { Nombre = "Luces traseras", CategoriaId = idSistema });
			productos.Add(new Producto { Nombre = "Luces de freno", CategoriaId = idSistema });
			productos.Add(new Producto { Nombre = "Luces intermitentes", CategoriaId = idSistema });
			productos.Add(new Producto { Nombre = "Bombillas", CategoriaId = idSistema });

			productos.Add(new Producto { Nombre = "Fusibles", CategoriaId = idSistema });
			productos.Add(new Producto { Nombre = "Relés", CategoriaId = idSistema });
			productos.Add(new Producto { Nombre = "Interruptores", CategoriaId = idSistema });
			productos.Add(new Producto { Nombre = "Módulos de control", CategoriaId = idSistema });

			var idSuspension = categorias[3].CategoriaId;


			productos.Add(new Producto { Nombre = "Amortiguadores", CategoriaId = idSuspension });
			productos.Add(new Producto { Nombre = "Resortes", CategoriaId = idSuspension });
			productos.Add(new Producto { Nombre = "Brazos de control", CategoriaId = idSuspension });
			productos.Add(new Producto { Nombre = "Barras estabilizadoras", CategoriaId = idSuspension });
			productos.Add(new Producto { Nombre = "Bujes", CategoriaId = idSuspension });

			productos.Add(new Producto { Nombre = "Caja de dirección", CategoriaId = idSuspension });
			productos.Add(new Producto { Nombre = "Cremallera de dirección", CategoriaId = idSuspension });
			productos.Add(new Producto { Nombre = "Barras de dirección", CategoriaId = idSuspension });
			productos.Add(new Producto { Nombre = "Extremos de dirección", CategoriaId = idSuspension });
			productos.Add(new Producto { Nombre = "Columna de dirección", CategoriaId = idSuspension });

			var idFrenos = categorias[4].CategoriaId;

			productos.Add(new Producto { Nombre = "Discos de freno", CategoriaId = idFrenos });
			productos.Add(new Producto { Nombre = "Tambores de freno", CategoriaId = idFrenos });
			productos.Add(new Producto { Nombre = "Pastillas de freno", CategoriaId = idFrenos });
			productos.Add(new Producto { Nombre = "Zapatas de freno", CategoriaId = idFrenos });

			productos.Add(new Producto { Nombre = "Cilindros maestros", CategoriaId = idFrenos });
			productos.Add(new Producto { Nombre = "Cilindros de rueda", CategoriaId = idFrenos });
			productos.Add(new Producto { Nombre = "Líneas de freno", CategoriaId = idFrenos });
			productos.Add(new Producto { Nombre = "Mangueras de freno", CategoriaId = idFrenos });

			productos.Add(new Producto { Nombre = "Cable de freno de mano", CategoriaId = idFrenos });
			productos.Add(new Producto { Nombre = "Palanca de freno de mano", CategoriaId = idFrenos });

			var idCarroceria = categorias[5].CategoriaId;

			productos.Add(new Producto { Nombre = "Parachoques", CategoriaId = idCarroceria });
			productos.Add(new Producto { Nombre = "Puertas", CategoriaId = idCarroceria });
			productos.Add(new Producto { Nombre = "Guardabarros", CategoriaId = idCarroceria });
			productos.Add(new Producto { Nombre = "Capó", CategoriaId = idCarroceria });
			productos.Add(new Producto { Nombre = "Techo", CategoriaId = idCarroceria });
			productos.Add(new Producto { Nombre = "Maletero", CategoriaId = idCarroceria });

			productos.Add(new Producto { Nombre = "Asientos", CategoriaId = idCarroceria });
			productos.Add(new Producto { Nombre = "Alfombras", CategoriaId = idCarroceria });
			productos.Add(new Producto { Nombre = "Paneles de puertas", CategoriaId = idCarroceria });
			productos.Add(new Producto { Nombre = "Tablero", CategoriaId = idCarroceria });
			productos.Add(new Producto { Nombre = "Cinturones de seguridad", CategoriaId = idCarroceria });

			productos.Add(new Producto { Nombre = "Parabrisas", CategoriaId = idCarroceria });
			productos.Add(new Producto { Nombre = "Lunas laterales", CategoriaId = idCarroceria });
			productos.Add(new Producto { Nombre = "Luneta trasera", CategoriaId = idCarroceria });
			productos.Add(new Producto { Nombre = "Espejos retrovisores", CategoriaId = idCarroceria });

			productos.Add(new Producto { Nombre = "Limpiaparabrisas", CategoriaId = idCarroceria });
			productos.Add(new Producto { Nombre = "Emblemas", CategoriaId = idCarroceria });
			productos.Add(new Producto { Nombre = "Molduras", CategoriaId = idCarroceria });
			productos.Add(new Producto { Nombre = "Antenas", CategoriaId = idCarroceria });

			var idClimatizacion = categorias[6].CategoriaId;

			productos.Add(new Producto { Nombre = "Compresor", CategoriaId = idClimatizacion });
			productos.Add(new Producto { Nombre = "Condensador", CategoriaId = idClimatizacion });
			productos.Add(new Producto { Nombre = "Evaporador", CategoriaId = idClimatizacion });
			productos.Add(new Producto { Nombre = "Filtros", CategoriaId = idClimatizacion });
			productos.Add(new Producto { Nombre = "Mangueras", CategoriaId = idClimatizacion });

			productos.Add(new Producto { Nombre = "Radiador de calefacción", CategoriaId = idClimatizacion });
			productos.Add(new Producto { Nombre = "Ventiladores", CategoriaId = idClimatizacion });
			productos.Add(new Producto { Nombre = "Termostato", CategoriaId = idClimatizacion });

			var idNeumaticos = categorias[7].CategoriaId;

			productos.Add(new Producto { Nombre = "Neumáticos", CategoriaId = idNeumaticos });
			productos.Add(new Producto { Nombre = "Válvulas", CategoriaId = idNeumaticos });
			productos.Add(new Producto { Nombre = "Sensores de presión", CategoriaId = idNeumaticos });

			productos.Add(new Producto { Nombre = "Llantas", CategoriaId = idNeumaticos });
			productos.Add(new Producto { Nombre = "Tapacubos", CategoriaId = idNeumaticos });
			productos.Add(new Producto { Nombre = "Tuercas de rueda", CategoriaId = idNeumaticos });

			var idSistemas = categorias[8].CategoriaId;

			productos.Add(new Producto { Nombre = "Módulos de airbag", CategoriaId = idSistemas });
			productos.Add(new Producto { Nombre = "Sensores", CategoriaId = idSistemas });
			productos.Add(new Producto { Nombre = "Unidades de control", CategoriaId = idSistemas });

			productos.Add(new Producto { Nombre = "ABS", CategoriaId = idSistemas });
			productos.Add(new Producto { Nombre = "Sensores de aparcamiento", CategoriaId = idSistemas });
			productos.Add(new Producto { Nombre = "Cámaras", CategoriaId = idSistemas });

			var idOtros = categorias[9].CategoriaId;

			productos.Add(new Producto { Nombre = "Llaves", CategoriaId = idOtros });
			productos.Add(new Producto { Nombre = "Gatos", CategoriaId = idOtros });
			productos.Add(new Producto { Nombre = "Compresores de aire", CategoriaId = idOtros });

			productos.Add(new Producto { Nombre = "Aceites", CategoriaId = idOtros });
			productos.Add(new Producto { Nombre = "Refrigerantes", CategoriaId = idOtros });
			productos.Add(new Producto { Nombre = "Limpiadores", CategoriaId = idOtros });
			productos.Add(new Producto { Nombre = "Aditivos", CategoriaId = idOtros });
			#endregion 

			foreach (Producto p in productos)
			{
				_productoBusiness.AddProducto(p);
			}

			btnPrimerCarga.Visible = false;
		}
		#endregion NO TOCAR

		//COMENTAR Y NO VOLVER A TOCAR SI QUIEREN SER FELICES
	}
}
//### Transmisión
//### 3. Sistema Eléctrico
//### 4. Suspensión y Dirección
//### 5. Frenos
//### 6. Carrocería y Accesorios
//### 7. Climatización
//### 8. Neumáticos y Ruedas
//### 9. Sistemas de Seguridad
//### 10. Otros

