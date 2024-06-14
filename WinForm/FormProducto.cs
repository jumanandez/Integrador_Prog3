using Proyecto.Core.Business.Interfaces;
using Proyecto.Core.Entities;
using System.Data;
using Krypton.Toolkit;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForm
{
    public partial class FormProducto : KryptonForm
    {
        private readonly ICategoriaBusiness _categoriaBusiness;
        private readonly IProductoBusiness _productoBusiness;
        private readonly IUsuarioBusiness _usuarioBusiness;
        private Producto _productoACargar;
        private Producto _productoSeleccionado;
        public Usuario _loggedUser;
        private string _orderType = " ";
        bool sidebaropen;
        bool filteropen;

        public FormProducto(ICategoriaBusiness catbusi, IProductoBusiness produbusi, IUsuarioBusiness usuariobusi, Usuario usalog)
        {
            _categoriaBusiness = catbusi;
            _productoBusiness = produbusi;
            _usuarioBusiness = usuariobusi;
            _productoACargar = new Producto();
            _loggedUser = usalog;
            //         button1.Font = new Font("Wingdings 3", 16, FontStyle.Bold);
            //button1.Text = Char.ConvertFromUtf32(81);
            InitializeComponent();
            LblBienvenido.Text = ($"Bienvenenido \n{_loggedUser.Nombre}");
            numericUpDown1.Value = 1;
        }
        //AL REACTIVARSE (CERRAR UNA SEGUNDA FORMS) SE ACTUALIZA SIN NECESIDAD DE REFRESH)
        private void FormProducto_Activated(object sender, EventArgs e)
        {
            cmbBoxCategorias.DataSource = CategoriasParaComboBox();// Linea 340
            cmbBoxCategorias.DisplayMember = "Nombre";
            RefreshGrid(null);
        }

        #region ABM DE PRODUCTOS
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducto.CurrentRow != null)
            {
                if (dataGridViewProducto.SelectedRows.Count == 1)
                {

                    var i = dataGridViewProducto.CurrentRow.Index;
                    var prod = dataGridViewProducto.SelectedRows[0];
                    _productoSeleccionado = (Producto)prod.DataBoundItem;
                    Form2 AddAPart = new Form2(_productoSeleccionado, _categoriaBusiness, _productoBusiness);
                    AddAPart.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Solo se puede modificar un elemento a la vez", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BTNdelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducto.SelectedRows.Count < 2)
            {
                if (dataGridViewProducto.CurrentRow != null)
                {
                    var i = dataGridViewProducto.CurrentRow.Index;
                    var prod = dataGridViewProducto.SelectedRows[0];
                    _productoSeleccionado = (Producto)prod.DataBoundItem;
                    DialogResult dialogResult = MessageBox.Show("Eliminar este elemento?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _productoBusiness.DeleteProducto(_productoSeleccionado);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningun producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                List<int> selectedRowIndices = new List<int>();
                foreach (DataGridViewRow row in dataGridViewProducto.SelectedRows)
                {
                    selectedRowIndices.Add(row.Index);
                }

                DialogResult dialogResult = MessageBox.Show($"Eliminar {selectedRowIndices.Count} elementos?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    foreach (int index in selectedRowIndices)
                    {
                        if (index >= 0 && index < dataGridViewProducto.Rows.Count)
                        {
                            dataGridViewProducto.Rows[index].Selected = true;
                        }
                    }
                    foreach (DataGridViewRow prod in dataGridViewProducto.SelectedRows)
                    {
                        _productoBusiness.DeleteProducto((Producto)prod.DataBoundItem);
                    }
                }
            }
            RefreshGrid(null);
        }
        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            Form2 AddAPart = new Form2(_categoriaBusiness, _productoBusiness);
            AddAPart.ShowDialog();
        }
        #endregion


        //REFACTORIZACION DE METODO REFRESHGRID
        public void RefreshGrid(List<Producto>? source)
        {
            dataGridViewProducto.AutoGenerateColumns = false;

            if (source != null)
            {
                dataGridViewProducto.DataSource = source;
                _orderType = "x";
            }
            else//RefreshGrid(null) debe ser la llamada para que funcione
            {
                dataGridViewProducto.DataSource = _productoBusiness.GetAll();
                textBox1.Clear();
                cmbBoxCategorias.SelectedIndex = 0;
            }

            CargarEstadoStock();
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
        public void CargarEstadoStock()
        {
            var Stock = dataGridViewProducto.Columns["ColumnStock"].Index;
            var Compras = dataGridViewProducto.Columns["ColumnCompras"].Index;
            var Ventas = dataGridViewProducto.Columns["ColumnVentas"].Index;

            foreach (DataGridViewRow row in dataGridViewProducto.Rows)
            {
                if (!row.IsNewRow)
                {
                    var producto = (Producto)row.DataBoundItem;

                    row.Cells[Compras].Value = producto.Compras.Select(c => c.Cantidad).Sum();

                    row.Cells[Ventas].Value = producto.Venta.Select(c => c.Cantidad).Sum();

                    row.Cells[Stock].Value = (int)row.Cells[Compras].Value - (int)row.Cells[Ventas].Value;
                }
            }
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

        #region FILTRADO DE DATAGRID
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.ToLower().Trim();
            var productos = _productoBusiness.GetAll();

            if (cmbBoxCategorias.SelectedIndex == 0)
            {
                if (rdiobtnTodos.Checked)
                {
                    RefreshGrid(FilterByText(productos, searchText));
                }
                else if (rdiobtnHabilitado.Checked)
                {
                    RefreshGrid(FilterByTextHabilitado(productos, true));
                }
                else if (rdiobtnDeshabilitado.Checked)
                {
                    RefreshGrid(FilterByTextHabilitado(productos, false));
                }

            }
            else
            {
                if (rdiobtnTodos.Checked)
                {
                    RefreshGrid(FilterCategoriaYTexto(productos));
                }
                else if (rdiobtnHabilitado.Checked)
                {
                    RefreshGrid(TripleFilter(productos, true));
                }
                else if (rdiobtnDeshabilitado.Checked)
                {
                    RefreshGrid(TripleFilter(productos, false));
                }
            }
        }
        private void cmbBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

            var productos = _productoBusiness.GetAll();

            if (cmbBoxCategorias.SelectedIndex == 0)
            {//SELECIONADO 'Todos' EN COMBOBOX

                //NO HAY TEXTO EN EL TEXTBOX
                if (textBox1.Text.Trim() == "" && rdiobtnTodos.Checked) //condicion para checkear que textbox este vacia
                {
                    RefreshGrid(null);
                }
                else if (textBox1.Text.Trim() == "" && rdiobtnHabilitado.Checked)
                {
                    RefreshGrid(FilterHabilitados(productos, true));//Habilitados 
                }
                else if (textBox1.Text.Trim() == "" && rdiobtnDeshabilitado.Checked)
                {
                    RefreshGrid(FilterHabilitados(productos, false));//Deshabilitados
                }

                //HAY TEXTO EN EL TEXTBOX
                else if (rdiobtnTodos.Checked) //en caso de tener algo escrito
                {
                    RefreshGrid(FilterByText(productos, textBox1.Text.ToLower().Trim()));
                }
                else if (rdiobtnHabilitado.Checked)
                {
                    RefreshGrid(FilterByTextHabilitado(productos, true));//Busca texto y Habilitados 
                }
                else if (rdiobtnDeshabilitado.Checked)
                {
                    RefreshGrid(FilterByTextHabilitado(productos, false));//Busca texto y Deshabilitados
                }
            }
            else
            {//SELECION DISTINTA DE 'Todos' EN COMBOBOX

                //NO HAY TEXTO EN EL TEXTBOX
                if (textBox1.Text.Trim() == "" && rdiobtnTodos.Checked)
                {
                    RefreshGrid(FilterByCategoria(productos));
                }
                else if (textBox1.Text.Trim() == "" && rdiobtnHabilitado.Checked)
                {
                    RefreshGrid(FilterByCategoriaHabilitado(productos, true));
                }
                else if (textBox1.Text.Trim() == "" && rdiobtnDeshabilitado.Checked)
                {
                    RefreshGrid(FilterByCategoriaHabilitado(productos, false));
                }

                //HAY TEXTO EN EL TEXTBOX
                else if (rdiobtnTodos.Checked)
                {
                    RefreshGrid(FilterCategoriaYTexto(productos));
                }
                else if (rdiobtnHabilitado.Checked)
                {
                    RefreshGrid(TripleFilter(productos, true));
                }
                else if (rdiobtnDeshabilitado.Checked)
                {
                    RefreshGrid(TripleFilter(productos, false));
                }
            }
        }
        private void rdiobtnHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            var productos = _productoBusiness.GetAll();
            if (rdiobtnHabilitado.Checked && cmbBoxCategorias.SelectedIndex == 0 && textBox1.Text.Trim() == "")
            {
                RefreshGrid(FilterHabilitados(productos, true));
            }
            else if (rdiobtnHabilitado.Checked && cmbBoxCategorias.SelectedIndex == 0)
            {
                RefreshGrid(FilterByTextHabilitado(productos, true));//Filtra Texto y Habilitados
            }
            else if (rdiobtnHabilitado.Checked && textBox1.Text.Trim() == "")
            {
                RefreshGrid(FilterByCategoriaHabilitado(productos, true));//Filtra Combo y Habilitados
            }
            else if (rdiobtnHabilitado.Checked)
            {
                RefreshGrid(TripleFilter(productos, true));//Filtra texto, Combo y Habilitados
            }
        }
        private void rdiobtnDeshabilitado_CheckedChanged(object sender, EventArgs e)
        {
            var productos = _productoBusiness.GetAll();
            if (rdiobtnDeshabilitado.Checked && cmbBoxCategorias.SelectedIndex == 0 && textBox1.Text.Trim() == "")
            {
                RefreshGrid(FilterHabilitados(productos, false));//false busca Deshabilitados
            }
            else if (rdiobtnDeshabilitado.Checked && cmbBoxCategorias.SelectedIndex == 0)
            {
                RefreshGrid(FilterByTextHabilitado(productos, false));//Filtra Texto y Deshabilitados
            }
            else if (rdiobtnDeshabilitado.Checked && textBox1.Text.Trim() == "")
            {
                RefreshGrid(FilterByCategoriaHabilitado(productos, false));//Filtra Combo y Deshabilitado
            }
            else if (rdiobtnDeshabilitado.Checked)
            {
                RefreshGrid(TripleFilter(productos, false));// Filtra Texto, Combo y Deshabilitados
            }
        }
        private void rdiobtnTodos_CheckedChanged(object sender, EventArgs e)
        {
            var idSeleccionado = ((Categoria)cmbBoxCategorias.SelectedItem).CategoriaId;

            var productos = _productoBusiness.GetAll();
            if (rdiobtnTodos.Checked && cmbBoxCategorias.SelectedIndex == 0 && textBox1.Text.Trim() == "")
            {
                RefreshGrid(null);
            }
            else if (rdiobtnTodos.Checked && cmbBoxCategorias.SelectedIndex == 0)
            {
                RefreshGrid(FilterByText(productos, textBox1.Text.ToLower().Trim()));
            }
            else if (rdiobtnTodos.Checked && textBox1.Text.Trim() == "")
            {
                RefreshGrid(FilterByCategoria(productos));
            }
            else
            {
                RefreshGrid(FilterCategoriaYTexto(productos));
            }
        }
        #endregion

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
                    //producomp.Venta.Add(new Venta { Cantidad = ((int)numericUpDown1.Value), Fecha = DateTime.Now, UsuarioId = _loggedUser.UsuarioId }); //testear ventas
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
        private void button1_Click(object sender, EventArgs e)
        {
            RefreshGrid(null);
        }
        private void dataGridViewProducto_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dataGridViewProducto.Columns[e.ColumnIndex].Name;
            List<Producto> on = (List<Producto>)dataGridViewProducto.DataSource;
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip2.Show(Cursor.Position);
            }
            else
            {
                switch (columnName)
                {
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
                    case "ColumnCompras":
                        if (_orderType != "cp")
                        {
                            RefreshGrid(on.OrderByDescending(p => p.Compras.Select(c => c.Cantidad).Sum()).ToList());
                            _orderType = "cp";
                            break;
                        }
                        else
                        {
                            RefreshGrid(on.OrderBy(p => p.Compras.Select(c => c.Cantidad).Sum()).ToList());
                            _orderType = "x";
                            break;
                        }
                    case "ColumnVentas":
                        if (_orderType != "v")
                        {
                            RefreshGrid(on.OrderByDescending(p => p.Venta.Select(c => c.Cantidad).Sum()).ToList());
                            _orderType = "v";
                            break;
                        }
                        else
                        {
                            RefreshGrid(on.OrderBy(p => p.Venta.Select(c => c.Cantidad).Sum()).ToList());
                            _orderType = "x";
                            break;
                        }
                }
            }
        }


        #region FUNCIONES DE FILTRADO PARA NO REPETIR CODE
        private List<Producto> TripleFilter(List<Producto> productos, bool valor)
        {
            return (from p in FilterCategoriaYTexto(productos)
                    where p.Habilitado == valor
                    select p).ToList();
        }
        public List<Producto> FilterCategoriaYTexto(List<Producto> productos)
        {
            var doublefilt = from p in FilterByText(productos, textBox1.Text.ToLower().Trim())//Llama a medtodo de filtrado y pide lista filtrada con el texto del textbox
                             where p.CategoriaId == ((Categoria)cmbBoxCategorias.SelectedItem).CategoriaId
                             select p;

            return doublefilt.ToList();
        }
        public List<Producto> FilterByCategoria(List<Producto> productos)
        {
            var filtradosCategoria = from p in productos
                                     where p.CategoriaId == ((Categoria)cmbBoxCategorias.SelectedItem).CategoriaId
                                     select p;

            return filtradosCategoria.ToList();
        }
        private List<Producto> FilterByCategoriaHabilitado(List<Producto> productos, bool valor)
        {
            return (from p in FilterByCategoria(productos)
                    where p.Habilitado == valor
                    select p).ToList();
        }
        public List<Producto> FilterByText(List<Producto> productos, string searchText)
        {
            var filteredProductos = from prod in productos
                                    where prod.Nombre.ToLower().Contains(searchText)
                                    select prod;

            return filteredProductos.ToList();
        }
        public List<Producto> FilterByTextHabilitado(List<Producto> productos, bool valor)
        {
            return (from p in FilterByText(productos, textBox1.Text.ToLower().Trim())
                    where p.Habilitado == valor
                    select p).ToList();
        }
        public static List<Producto> FilterHabilitados(List<Producto> productos, bool valor)
        {
            return (from prod in productos
                    where prod.Habilitado == valor
                    select prod).ToList();
        }
        #endregion

        #region Codigo UI/UEX
        private void sidebartimer_Tick(object sender, EventArgs e)//Timer de animacion de menu
        {
            if (sidebaropen)
            {
                menupanel.Width -= 10;
                if (menupanel.Width == menupanel.MinimumSize.Width)
                {
                    sidebaropen = false;
                    filteropen = false;
                    sidebartimer.Stop();
                    kryptonButton1.Enabled = false;
                }
            }
            else
            {
                menupanel.Width += 10;
                if (menupanel.Width == menupanel.MaximumSize.Width)
                {
                    sidebaropen = true;
                    sidebartimer.Stop();
                }
            }

        }

        private void menubutton_Click(object sender, EventArgs e)//Inicio de timer de boton menu
        {
            if (!filteropen)
            {
                flowLayoutPanel1.Height = flowLayoutPanel1.MinimumSize.Height;
                kryptonButton1.Enabled = true;
                filteropen = false;
            }
            sidebartimer.Start();
        }

        private void filtertimer_Tick(object sender, EventArgs e)//Timer de animacion de filtros
        {
            if (filteropen)
            {
                flowLayoutPanel1.Height += 10;
                if (flowLayoutPanel1.Height == flowLayoutPanel1.MaximumSize.Height)
                {
                    filteropen = false;
                    filtertimer.Stop();
                }
            }
            else if (!filteropen)
            {
                flowLayoutPanel1.Height -= 10;
                if (flowLayoutPanel1.Height == flowLayoutPanel1.MinimumSize.Height)
                {
                    filteropen = true;
                    filtertimer.Stop();
                }
            }

        }

        private void kryptonButton1_Click(object sender, EventArgs e)//Inicio de timer de filtros
        {
            filtertimer.Start();
        }
        #region Codigo para mover la forma presionando donde sea
        private void FormProducto_MouseDown(object sender, MouseEventArgs e)// al presionar en la forma
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void kryptonLabel2_MouseDown(object sender, MouseEventArgs e)//al presionar el text label
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        private void dataGridViewProducto_MouseDown(object sender, MouseEventArgs e)//Seleccionar un objeto al abrir el menu contextual
        {
            //if (dataGridViewProducto.SelectedColumns == null)
            //{
            if (e.Button == MouseButtons.Right)
            {
                var hti = dataGridViewProducto.HitTest(e.X, e.Y);
                dataGridViewProducto.ClearSelection();
                if (hti.RowIndex != -1)
                {
                    dataGridViewProducto.Rows[hti.RowIndex].Selected = true;
                }
            }
            //}
        }
        private void toolStripMenuItem1ToolStripMenuItem_Click(object sender, EventArgs e)//Opcion de agregar nuevo del menu contextual
        {
            btnNuevoProducto_Click(sender, e);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)//Opcion de eliminar del menu contextual
        {
            BTNdelete_Click(sender, e);
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)//Opcion de modificar del menu contextual
        {
            btnModificar_Click(sender, e);
        }

        private void detallesToolStripMenuItem_Click(object sender, EventArgs e)//No implementado, codigo para mostrar mas detalles de un elemento seleccionado
        {

        }

        private void refrescarToolStripMenuItem_Click(object sender, EventArgs e)//refrescar datagrid menu contexto
        {
            RefreshGrid(null);
        }

        private void ordenarToolStripMenuItem1_Click(object sender, EventArgs e)//No implementado codigo para combo box de seleccionar orden
        {

        }
        #endregion

    }
}


