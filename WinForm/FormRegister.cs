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
	public partial class FormRegister : Form
	{
		private readonly IUsuarioBusiness _usuarioBusiness;
		public Usuario User;
		public FormRegister(IUsuarioBusiness usuarioBusiness)
		{
			_usuarioBusiness = usuarioBusiness;
			InitializeComponent();
			txtContraseña.UseSystemPasswordChar = true;
		}

		private void btnRegistrarse_Click(object sender, EventArgs e)
		{
			string username = txtNombreUsuario.Text;
			string pass = txtContraseña.Text;
			
			if(_usuarioBusiness.CreateUsuario(username, pass))
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else if (txtNombreUsuario.Text.Trim() == "")
			{
				MessageBox.Show("Usuario no puede estar vacio!");
			}
			else if (txtContraseña.Text.Trim() == "")
			{
				MessageBox.Show("Ingrese una contraseña!");
			}
			else
			{
				MessageBox.Show("Usuario y/o contraseña Existente!");
			}
		}
	}
}
