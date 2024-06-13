using Krypton.Toolkit;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WinForm
{
    public partial class FormRegister : KryptonForm
    {
        private readonly IUsuarioBusiness _usuarioBusiness;
        public Usuario User;
        public FormRegister(IUsuarioBusiness usuarioBusiness)
        {
            _usuarioBusiness = usuarioBusiness;
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            string username = txtNombreUsuario.Text;
            string pass = txtContraseña.Text;

            if (txtNombreUsuario.Text.Trim() != "" && txtContraseña.Text.Trim() != "" && _usuarioBusiness.CreateUsuario(username, pass))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            if (txtNombreUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Usuario no puede estar vacio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtContraseña.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese una contraseña!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Usuario existente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            txtNombreUsuario.Clear();
            txtNombreUsuario.StateCommon.Content.Color1 = Color.White;
            btnRegistrarse.Enabled = true;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            txtContraseña.Clear();
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseña.StateCommon.Content.Color1 = Color.White;
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
    }
}
