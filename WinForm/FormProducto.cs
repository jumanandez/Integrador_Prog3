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
        private readonly ICategoriaBusiness _categoriaBusiness;
        private readonly IProductoBusiness _productoBusiness;
        private readonly IUsuarioBusiness _usuarioBusiness;
        private Producto _productoACargar;
        private Producto _productoSeleccionado;
        public Usuario _loggedUser;
        private string _orderType = " ";

        public FormProducto(ICategoriaBusiness catbusi, IProductoBusiness produbusi, IUsuarioBusiness usuariobusi, Usuario usalog)
        {
            _categoriaBusiness = catbusi;
            _productoBusiness = produbusi;
            _usuarioBusiness = usuariobusi;
            _productoACargar = new Producto();
            _loggedUser = usalog;
            InitializeComponent();
            LblBienvenido.Text = ($"Bienvenenido {_loggedUser.Nombre}");
            numericUpDown1.Value = 1;
        }

		private void btnModificar_Click(object sender, EventArgs e)
		{
			if (dataGridViewProducto.CurrentRow != null)
			{

                var i = dataGridViewProducto.CurrentRow.Index;
                var prod = dataGridViewProducto.SelectedRows[0];
                _productoSeleccionado = (Producto)prod.DataBoundItem;
                Form2 AddAPart = new Form2(_productoSeleccionado, _categoriaBusiness, _productoBusiness);
                AddAPart.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun producto.", "Error");
            }
        }
        //AL REACTIVARSE (CERRAR UNA SEGUNDA FORMS) SE ACTUALIZA SIN NECESIDAD DE REFRESH)
        private void FormProducto_Activated(object sender, EventArgs e)
        {
            cmbBoxCategorias.DataSource = CategoriasParaComboBox();// Linea 340
            cmbBoxCategorias.DisplayMember = "Nombre";
            RefreshGrid();
        }

        private void BTNdelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducto.CurrentRow != null)
            {
                var i = dataGridViewProducto.CurrentRow.Index;
                var prod = dataGridViewProducto.SelectedRows[0];
                _productoSeleccionado = (Producto)prod.DataBoundItem;
                DialogResult dialogResult = MessageBox.Show("Seguro que quiere realizar los cambios?", "Confirme", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _productoBusiness.DeleteProducto(_productoSeleccionado);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun producto.", "Error");
            }
            RefreshGrid();
        }
        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            Form2 AddAPart = new Form2(_categoriaBusiness, _productoBusiness);
            AddAPart.ShowDialog();
        }

		private void RefreshGrid()
		{
			dataGridViewProducto.AutoGenerateColumns = false;
			dataGridViewProducto.DataSource = _productoBusiness.GetAll();
			CargarStock();
			textBox1.Clear();
			cmbBoxCategorias.SelectedIndex = 0;
			//ProductosConCategorias(_productoBusiness.GetAll(), _categoríaBusiness.GetAll());
		}
		private void RefreshGrid<T>(IEnumerable<T> source) // refresh grid que recibe listas filtradas, no reinicia cmbbox y txtbox
		{
			dataGridViewProducto.AutoGenerateColumns = false;
			dataGridViewProducto.DataSource = source;
			CargarStock();
		}


		//UTILIZAR LA PRIMERA VEZ Y NUNCA MAS, PARA CARGAR SU BASE DE DATOS CON LOS PRODUCTOS

		#region BOTON DE PRIMERA CARGA
		private void btnPrimerCarga_Click(object sender, EventArgs e)
		{
			var categorias = _categoriaBusiness.GetAll();

			var idMotor = categorias[0].CategoriaId;
			var productos = new List<Producto>();

			#region PRIMERA CARGA DE PRODUCTOS
			productos.Add(new Producto { Nombre = "Pistones", CategoriaId = idMotor });
			productos.Add(new Producto { Nombre = "Bloque del motor", CategoriaId = idMotor });
			productos.Add(new Producto { Nombre = "Cilindros", CategoriaId = idMotor });
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


			productos.Add(new Producto { Nombre = "Engranajes de transmision", CategoriaId = idTransmision });
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

			btnPrimerCarga.Enabled = false;
		}
		#endregion NO TOCAR

		//COMENTAR Y NO VOLVER A TOCAR SI QUIEREN SER FELICES

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			string searchText = textBox1.Text.ToLower().Trim();
			var productos = _productoBusiness.GetAll();
			var categorias = _categoriaBusiness.GetAll();

			if (cmbBoxCategorias.SelectedIndex == 0)
			{
				//var filteredProductos = from prod in productos
				//						where prod.Nombre.ToLower().Contains(searchText)
				//						select prod;

				RefreshGrid(FilterByText(productos, searchText));
			}
			else
			{
				var filteredProductos = from prod in productos
										where prod.CategoriaId ==
											  ((Categoria)cmbBoxCategorias.SelectedItem).CategoriaId
													&&
											  prod.Nombre.ToLower().Contains(searchText)
										select prod;

				RefreshGrid(filteredProductos.ToList());

			}
		}

		private void cmbBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
		{
			var idSeleccionado = ((Categoria)cmbBoxCategorias.SelectedItem).CategoriaId;

			var productos = _productoBusiness.GetAll();

			if (cmbBoxCategorias.SelectedIndex == 0)
			{
				if (textBox1.Text.Trim() == "") //condicion para checkear que textbox este vacia
				{
					RefreshGrid();
				}
				else //en caso de tener algo escrito
				{
					RefreshGrid(FilterByText(productos, textBox1.Text.ToLower().Trim()));
				}
			}
			else
			{
				if (textBox1.Text.Trim() == "")
				{
					RefreshGrid(FilterByCategoria(productos));
				}
				else
				{
					RefreshGrid(Doublefilter(productos));
				}
			}
		}
		private List<Categoria> CategoriasParaComboBox()
		{
			var categorias = new List<Categoria>();

			categorias.Add(new Categoria { Nombre = "Todos" });

			var cateBasicas = _categoriaBusiness.GetAll();

			foreach (Categoria categoria in cateBasicas)
			{
				categorias.Add(categoria);
			}

			return categorias;
		}

		public void CargarStock()
		{
			var Stock = dataGridViewProducto.Columns["ColumnStock"].Index;

			foreach (DataGridViewRow row in dataGridViewProducto.Rows)
			{
				if (!row.IsNewRow)
				{
					var producto = (Producto)row.DataBoundItem;

                    row.Cells[Stock].Value = producto.Compras.Select(c => c.Cantidad).Sum() //Compras
                                            - //menos
                                            producto.Venta.Select(v => v.Cantidad).Sum();//Ventas
                }
            }
        }
        public List<Producto> FilterByText(List<Producto> productos, string searchText) //funcion de filtrar por texto para no repetir code
        {
            var filteredProductos = from prod in productos
                                    where prod.Nombre.ToLower().Contains(searchText)
                                    select prod;

            return filteredProductos.ToList();
        }

        private void BtnCompra_Click(object sender, EventArgs e)
        {
            var i = dataGridViewProducto.CurrentRow.Index;//
            var prod = dataGridViewProducto.SelectedRows[0];//
            var producomp = (Producto)prod.DataBoundItem;//codigo se repite hacer una funcion de esta parte

			if (i >= 0)
			{
				if (((int)numericUpDown1.Value) >= 1)
				{
					producomp.Compras.Add(new Compra { Cantidad = ((int)numericUpDown1.Value), Fecha = DateTime.Now, UsuarioId = _loggedUser.UsuarioId });
					_productoBusiness.ModifyProduct(producomp);
					MessageBox.Show($"Se hizo el pedido de {(int)numericUpDown1.Value} {producomp.Nombre}");
				}
				else
				{
					MessageBox.Show("Ingrese una cantidad valida!.", "Error");
					numericUpDown1.Focus();
				}
			}
			else
			{
				MessageBox.Show("No se ha seleccionado ningun producto.", "Error");
			}
		}

		private void numericUpDown1_Click(object sender, EventArgs e)
		{
			BtnCompra.Enabled = true;

		}

		private void rdiobtnHabilitado_CheckedChanged(object sender, EventArgs e)
		{
			var productos = _productoBusiness.GetAll();
			if (rdiobtnHabilitado.Checked)
			{
				var habilitados = from prod in productos
								  where prod.Habilitado == true
								  select prod;

				RefreshGrid(habilitados.ToList());
			}
		}

		private void rdiobtnDeshabilitado_CheckedChanged(object sender, EventArgs e)
		{
			var productos = _productoBusiness.GetAll();
			if (rdiobtnDeshabilitado.Checked)
			{
				var deshabilitados = from prod in productos
									 where prod.Habilitado == false
									 select prod;
				RefreshGrid(deshabilitados.ToList());
			}
		}

        private void dataGridViewProducto_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dataGridViewProducto.Columns[e.ColumnIndex].Name;
            List<Producto> on = (List<Producto>)dataGridViewProducto.DataSource;
            switch (columnName){
                case "ColumnNombreProducto":
                    if (_orderType == "n")
                    {
                        RefreshGrid(on.OrderByDescending(p => p.Nombre).ToList());
                        _orderType = "x";
                        break;
                    }
                    else
                    {
                        RefreshGrid(on.OrderBy(p => p.Nombre).ToList());
                        _orderType = "n";
                        break;
                    }
                case "ColumnCategoria":
                    if (_orderType != "c")
                    {
                        RefreshGrid(on.OrderBy(p => p.Categoria.Nombre).ToList());
                        _orderType = "c";
                        break;
                    }
                    else
                    {
                        RefreshGrid(on.OrderByDescending(p => p.Categoria.Nombre).ToList());
                        _orderType = "x";
                        break;
                    }
                case "ColumnStock":
                    if (_orderType != "s")
                    {
                        RefreshGrid(on.OrderBy(p => p.Compras.Select(c => c.Cantidad).Sum() - p.Venta.Select(v => v.Cantidad).Sum()).ToList());
                        _orderType = "s";
                        break;
                    }
                    else
                    {
                        RefreshGrid(on.OrderByDescending(p => p.Compras.Select(c => c.Cantidad).Sum() - p.Venta.Select(v => v.Cantidad).Sum()).ToList());
                        _orderType = "x";
                        break;
                    }
                case "ColumnHabilitado":
                    if (_orderType != "h") 
                    {
                        RefreshGrid(on.OrderBy(p => p.Habilitado).ToList());
                        _orderType = "h";
                        break;
                    }
                    else 
                    {
                        RefreshGrid(on.OrderByDescending(p => p.Habilitado).ToList());
                        _orderType = "x";
                        break;
                    }

            }
        }
    }
		private void rdiobtnTodos_CheckedChanged(object sender, EventArgs e)
		{
			var idSeleccionado = ((Categoria)cmbBoxCategorias.SelectedItem).CategoriaId;

			var productos = _productoBusiness.GetAll();
			if (rdiobtnTodos.Checked && cmbBoxCategorias.SelectedIndex == 0 && textBox1.Text.Trim() == "")
			{
				RefreshGrid(productos);
			}
			else if(rdiobtnTodos.Checked && cmbBoxCategorias.SelectedIndex == 0)
			{
				RefreshGrid(FilterByText(productos, textBox1.Text.ToLower().Trim()));
			}
			else if(rdiobtnTodos.Checked && textBox1.Text.Trim() == "")
			{
				RefreshGrid(FilterByCategoria(productos));
			}
			else
			{
				RefreshGrid(Doublefilter(productos));
			}
		}
		private void dataGridViewProducto_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			string columnName = dataGridViewProducto.Columns[e.ColumnIndex].Name;
			switch (columnName)
			{
				case "ColumnNombreProducto":
					MessageBox.Show("Nombre");
					break;
				case "ColumnCategoria":
					MessageBox.Show("Catergoriar");
					break;
				case "ColumnStock":
					MessageBox.Show("Stokk");
					break;
				case "ColumnHabilitado":
					MessageBox.Show("abilitadon");
					break;
			}
		}

		//funciones de filtrar para no repetir code
		private List<Producto> Doublefilter(List<Producto> productos)
		{
			var doublefilt = from p in FilterByText(productos, textBox1.Text.ToLower().Trim())//Llama a medtodo de filtrado y pide lista filtrada con el texto del textbox
							 where p.CategoriaId == ((Categoria)cmbBoxCategorias.SelectedItem).CategoriaId
							 select p;

			return doublefilt.ToList();
		}
		private List<Producto> FilterByCategoria(List<Producto> productos)
		{
			var filtradosCategoria = from p in productos
									 where p.CategoriaId == ((Categoria)cmbBoxCategorias.SelectedItem).CategoriaId
									 select p;

			return filtradosCategoria.ToList();
		}
		public List<Producto> FilterByText(List<Producto> productos, string searchText) 
		{
			var filteredProductos = from prod in productos
									where prod.Nombre.ToLower().Contains(searchText)
									select prod;

			return filteredProductos.ToList();
		}

        }
}


