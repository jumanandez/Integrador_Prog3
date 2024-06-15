using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using Proyecto.Core.Business;
using Proyecto.Core.Business.Interfaces;
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
using Krypton.Toolkit;

namespace WinForm
{
    public partial class Form2 : KryptonForm
    {
        private readonly ICategoriaBusiness _categoríaBusiness;
        private readonly IProductoBusiness _productoBusiness;
        private readonly Producto _productorSeleccionado;
        private bool _new; //booleando que cambia de valor dependiendo del constructor llamado
        public Form2(Producto productin, ICategoriaBusiness catbusi, IProductoBusiness productoBusiness)
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

        public Form2(ICategoriaBusiness catbusi, IProductoBusiness productoBusiness)
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
                                                   MessageBox.Show("Agregar producto?", "Confirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) :
                                                   MessageBox.Show("Seguro que quiere realizar los cambios?", "Confirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    if (produmf.Nombre.Trim() != "") //checkea que el textbox no este vacio
                    {
                        if (nms.Any(s => s.Replace(" ", "").Equals(produmf.Nombre.Replace(" ", ""), StringComparison.OrdinalIgnoreCase)))//ignora los espacios en blanco
                        {
                            MessageBox.Show("Este producto ya existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (_new)
                            {
                                _productoBusiness.AddProducto(produmf);
                                MessageBox.Show("Producto agregado correctamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                _productoBusiness.ModifyProduct(produmf);//le mandas por modify y de todas maneras lo agrega si es nuevo por mas que usemos modify WTF, funciona asi que ni toco
                                MessageBox.Show("Accion realizada correctamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El nombre no pude estar vacio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Error ningun producto seleccionado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
