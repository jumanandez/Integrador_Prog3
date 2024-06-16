using Proyecto.Core.Business.Interfaces;
using System.Text;
using System.Security.Cryptography;
using Proyecto.Core.Entities;
using Proyecto.Core.Data;
using Proyecto.Core.Business;
using Krypton.Toolkit;
using System.Drawing;

namespace WinForm
{
    public partial class FormLogin : KryptonForm
    {
        private readonly IUsuarioBusiness _usuarioBusiness;
        private readonly ICategoriaBusiness _categoriaBusiness;
        private readonly IProductoBusiness _productoBusiness;
        public Usuario _loggedUser;
        public FormLogin(ICategoriaBusiness catbusi, IProductoBusiness produbusi, IUsuarioBusiness usuarioBusiness)
        {
            _usuarioBusiness = usuarioBusiness;
            _categoriaBusiness = catbusi;
            _productoBusiness = produbusi;
            InitializeComponent();
            button1.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool pass;
            if (_usuarioBusiness.CompareUserToDB(textBox1.Text))//obtener salt ya
            {
                var hashnew = CryptoHelper.HashPassword(textBox2.Text, _usuarioBusiness.GetUsuarioSalt(textBox1.Text));

                pass = hashnew.SequenceEqual(_usuarioBusiness.GetUsuarioHash(textBox1.Text));

                if (pass)
                {
                    IngresarAlaAplicacion();
                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Usuario no puede estar vacio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textBox2.Text.Trim() == "" || textBox1.Text == "Ingrese una contraseña")
            {
                MessageBox.Show("Ingrese una contraseña!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña Incorrecto!",
                                "Pruebe otro Usuario y/o Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void linkCambioContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCambioContrasena formCambioContraseña = new FormCambioContrasena(_usuarioBusiness);
            Hide();

            if (formCambioContraseña.ShowDialog() == DialogResult.OK)
            {
                _loggedUser = _usuarioBusiness.ObtainUsuario(textBox1.Text);
                MessageBox.Show("Contraseña Cambiada Con Exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Show();
            }
            else
            {
                bool exit = false;
                while (!exit)
                {
                    DialogResult operao = MessageBox.Show("Cancelar operacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (operao == DialogResult.Yes)
                    {
                        exit = true;
                    }
                    else
                    {
                        formCambioContraseña.ShowDialog();
                    }
                }
                Show();
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FormRegister registrarse = new FormRegister(_usuarioBusiness);
            Hide();

            if (registrarse.ShowDialog() == DialogResult.OK)
            {
                _loggedUser = _usuarioBusiness.ObtainUsuario(textBox1.Text);
                MessageBox.Show("Registrado Correctamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show();
            }
            else
            {
                bool exit = false;
                while (!exit)
                {
                    DialogResult operao = MessageBox.Show("Cancelar operacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (operao == DialogResult.Yes)
                    {
                        exit = true;
                    }
                    else
                    {
                        registrarse.ShowDialog();
                    }
                }
                Show();
            }
        }
        private void IngresarAlaAplicacion()
        {
            _loggedUser = _usuarioBusiness.ObtainUsuario(textBox1.Text);
            Hide();
            FormProducto productosesion = new FormProducto(_categoriaBusiness, _productoBusiness, _usuarioBusiness, _loggedUser);
            if (productosesion.ShowDialog() == DialogResult.OK)
            {
                Show();
            }
            else
            {
                bool exit = false;
                while (!exit)
                {
                    DialogResult operao = MessageBox.Show("Salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (operao == DialogResult.Yes)
                    {
                        exit = true;
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        productosesion.ShowDialog();
                    }
                }
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.StateCommon.Content.Color1 = Color.White;
            button1.Enabled = true;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.UseSystemPasswordChar = true;
            textBox2.StateCommon.Content.Color1 = Color.White;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            FormRegister registrarse = new FormRegister(_usuarioBusiness);
            Hide();

            if (registrarse.ShowDialog() == DialogResult.OK)
            {
                _loggedUser = _usuarioBusiness.ObtainUsuario(textBox1.Text);
                MessageBox.Show("Registrado Correctamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show();
            }
            else
            {
                bool exit = false;
                while (!exit)
                {
                    DialogResult operao = MessageBox.Show("Cancelar operacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (operao == DialogResult.Yes)
                    {
                        exit = true;
                    }
                    else
                    {
                        registrarse.ShowDialog();
                    }
                }
                Show();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)//Ignora  espacios en textbox
        {
            if (e.KeyChar == (char)Keys.Enter && (textBox2.Text != "Ingrese una contraseña" || textBox2.Text == "".Trim()))
            {
                this.AcceptButton = button1;//aceptar enter como click
                Point screenCoordinates = button1.PointToScreen(Point.Empty);//manda al puntero al centro del boton

                Cursor.Position = new Point(screenCoordinates.X + button1.Width / 2, screenCoordinates.Y + button1.Height / 2);
            }
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)//implementado a medias, codigo para presionar enter y logear
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                if (textBox2.Text == "Ingrese una contraseña" || textBox2.Text == "".Trim())
                {
                    textBox2.UseSystemPasswordChar = true;
                    textBox2.StateCommon.Content.Color1 = Color.White;
                    textBox2.Focus();
                    textBox2.Clear();
                }
                else
                {
                    button1_Click(this, new EventArgs());
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
