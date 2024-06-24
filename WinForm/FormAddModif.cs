using Proyecto.Core.Business.Interfaces;
using Proyecto.Core.Entities;
using System.Data;
using Krypton.Toolkit;
using WinForm.CustomMessageBox;
using System.Linq;

namespace WinForm
{
    public partial class FormAddModif : KryptonForm
    {
        private readonly ICategoriaBusiness _categoríaBusiness;
        private readonly IProductoBusiness _productoBusiness;
        private readonly Producto _productorSeleccionado = null!;
        private bool _new; //booleando que cambia de valor dependiendo del constructor llamado
        public FormAddModif(Producto productin, ICategoriaBusiness catbusi, IProductoBusiness productoBusiness)
        {
            _productorSeleccionado = productin;
            _categoríaBusiness = catbusi;
            _productoBusiness = productoBusiness;
            this.Text = "     Modificar Elemento";
            InitializeComponent();
            _new = false; //llamado por boton de modificar
            cmbBoxCategorias.DataSource = _categoríaBusiness.GetAll();
            cmbBoxCategorias.DisplayMember = "Nombre";
            int index = FindIndexByName(productin.Categoria.Nombre);
            cmbBoxCategorias.SelectedIndex = index;
            txtNombreProducto.Text = productin.Nombre;
            checkHabilitado.Checked = productin.Habilitado;
        }

        public FormAddModif(ICategoriaBusiness catbusi, IProductoBusiness productoBusiness)
        {
            _categoríaBusiness = catbusi;
            _productoBusiness = productoBusiness;
            _new = true;//llamado por boton de nuevo
            this.Text = "     Añadir Elemento";
            InitializeComponent();
            cmbBoxCategorias.DataSource = _categoríaBusiness.GetAll();
            cmbBoxCategorias.DisplayMember = "Nombre";
            checkHabilitado.Checked = true;
            checkHabilitado.Enabled = false;//no se porque rayos pero al querer poner desabilitado no funciona entonces anulo nomas hasta saber como arreglar
        }

        private int FindIndexByName(string name)
        {
            var item = cmbBoxCategorias.Items.OfType<Categoria>()
                                      .Select((cate, index) => new { cate, index })
                                      .FirstOrDefault(x => x.cate.Nombre == name);

            return item != null ? item.index : -1; //pregunta si item es null y si es retorna -1
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            Producto produmf = _new ? new Producto() : _productorSeleccionado; //pregunta si es llamado por nuevo o modificar
            List<string> nms = _productoBusiness.GetAllNames();

            if (produmf != null)
            {
                nms.Remove(produmf.Nombre); //no afecta al nuevo producto ya que este no tiene valor en nombre
                produmf.Nombre = txtNombreProducto.Text;
                produmf.CategoriaId = ((Categoria)cmbBoxCategorias.SelectedItem).CategoriaId;
                produmf.Habilitado = checkHabilitado.Checked;
                DialogResult dialogResult = _new ?
                                                   RJMessageBox.Show("Agregar producto?", "Confirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) :
                                                   RJMessageBox.Show("Seguro que quiere realizar los cambios?", "Confirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    if (produmf.Nombre.Trim() != "") //checkea que el textbox no este vacio
                    {
                        if (nms.Any(s => s.Replace(" ", "").Equals(produmf.Nombre.Replace(" ", ""), StringComparison.OrdinalIgnoreCase)))//ignora los espacios en blanco
                        {
                            RJMessageBox.Show("Este producto ya existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                        else
                        {
                            if (_new)
                            {
                                _productoBusiness.AddProducto(produmf);
                                RJMessageBox.Show("Producto agregado correctamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                _productoBusiness.ModifyProduct(produmf, produmf.CategoriaId);//le mandas por modify y de todas maneras lo agrega si es nuevo por mas que usemos modify WTF, funciona asi que ni toco
                                RJMessageBox.Show("Accion realizada correctamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        RJMessageBox.Show("El nombre no pude estar vacio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                RJMessageBox.Show("Error ningun producto seleccionado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
