﻿using Microsoft.Extensions.Logging;
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

namespace WinForm
{
    public partial class Form2 : Form
    {
        private readonly ILogger _logger;
        private readonly ICatergoriaBusiness _categoríaBusiness;
        private readonly IProductoBusiness _productoBusiness;
        private readonly Producto _productorSeleccionado;
        public Form2(Producto productin, ICatergoriaBusiness catbusi, IProductoBusiness productoBusiness)
        {
            _productorSeleccionado = productin;
            _categoríaBusiness = catbusi;
            _productoBusiness = productoBusiness;
            InitializeComponent();
            cmbBoxCategorias.DataSource = _categoríaBusiness.GetAll();
            cmbBoxCategorias.DisplayMember = "Nombre";
            int index = FindIndexByName(productin.Categoria.Nombre);
            cmbBoxCategorias.SelectedIndex = index;
            txtNombreProducto.Text = productin.Nombre;
        }

        public Form2(ICatergoriaBusiness catbusi, IProductoBusiness productoBusiness)
        {
            _categoríaBusiness = catbusi;
            _productoBusiness = productoBusiness;
            InitializeComponent();
            cmbBoxCategorias.DataSource = _categoríaBusiness.GetAll();
            cmbBoxCategorias.DisplayMember = "Nombre";
        }

        private int FindIndexByName(string name)
        {
            var item = cmbBoxCategorias.Items.OfType<Categoria>()
                                      .Select((cate, index) => new { cate, index })
                                      .FirstOrDefault(x => x.cate.Nombre == name);

            return item != null ? item.index : -1;
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            Producto produmf = _productorSeleccionado;
            List<string> nms = _productoBusiness.GetAllNames();
            nms.Remove(produmf.Nombre);

            if (produmf != null)
            {
                produmf.Nombre = txtNombreProducto.Text;
                produmf.CategoriaId = ((Categoria)cmbBoxCategorias.SelectedItem).CategoriaId;
                DialogResult dialogResult = MessageBox.Show("Seguro que quiere realizar los cambios?", "Confirme", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (nms.Contains(produmf.Nombre))
                    {
                        MessageBox.Show("Este producto ya existe!");
                    }
                    else
                    {
                        _productoBusiness.ModifyProduct(produmf);
                        MessageBox.Show("Accion realizada correctamente!");
                    }
                }
                this.Close();
            }
        }
    }
}