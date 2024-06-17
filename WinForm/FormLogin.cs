using Proyecto.Core.Business.Interfaces;
using Proyecto.Core.Entities;
using Proyecto.Core.Business;
using Krypton.Toolkit;
using WinForm.CustomMessageBox;

namespace WinForm
{
    public partial class FormLogin : KryptonForm
    {
        private readonly IUsuarioBusiness _usuarioBusiness;
        private readonly ICategoriaBusiness _categoriaBusiness;
        private readonly IProductoBusiness _productoBusiness;
        public Usuario _loggedUser = null!;
        public FormLogin(ICategoriaBusiness catbusi, IProductoBusiness produbusi, IUsuarioBusiness usuarioBusiness)
        {
            _usuarioBusiness = usuarioBusiness;
            _categoriaBusiness = catbusi;
            _productoBusiness = produbusi;
            InitializeComponent();
            btnlogin.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool pass;
            var user = _usuarioBusiness.ObtainUsuario(txtboxuser.Text);
            if (user != null)
            {
                var hashnew = CryptoHelper.HashPassword(txtboxpassw.Text, user.Salt);

                pass = hashnew.SequenceEqual(user.HashPassword);

                if (pass)
                {
                    _loggedUser = user;
                    IngresarAlaAplicacion();
                }
                else
                {
                    RJMessageBox.Show("Contraseña Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (txtboxuser.Text.Trim() == "")
            {
                RJMessageBox.Show("Usuario no puede estar vacio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtboxpassw.Text.Trim() == "" || txtboxuser.Text == "Ingrese una contraseña")
            {
                RJMessageBox.Show("Ingrese una contraseña!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                RJMessageBox.Show("Usuario y/o Contraseña Incorrecto!",
                                "Pruebe otro Usuario y/o Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void linkCambioContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCambioContrasena formCambioContraseña = new FormCambioContrasena(_usuarioBusiness);
            Hide();

            if (formCambioContraseña.ShowDialog() == DialogResult.OK)
            {
                RJMessageBox.Show("Contraseña Cambiada Con Exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Show();
            }
            else
            {
                bool exit = false;
                while (!exit)
                {
                    DialogResult operao = RJMessageBox.Show("Cancelar operacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                _loggedUser = _usuarioBusiness.ObtainUsuario(txtboxuser.Text);
                RJMessageBox.Show("Registrado Correctamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show();
            }
            else
            {
                bool exit = false;
                while (!exit)
                {
                    DialogResult operao = RJMessageBox.Show("Cancelar operacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            Hide();
            FormProducto productosesion = new FormProducto(_categoriaBusiness, _productoBusiness, _usuarioBusiness, _loggedUser);
            if (productosesion.ShowDialog() == DialogResult.OK)
            {
                Show();
                txtboxuser.Focus();
                txtboxpassw.Clear();
            }
            else
            {
                bool exit = false;
                while (!exit)
                {
                    DialogResult operao = RJMessageBox.Show("Salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            txtboxuser.Clear();
            txtboxuser.StateCommon.Content.Color1 = Color.White;
            btnlogin.Enabled = true;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            txtboxpassw.Clear();
            txtboxpassw.UseSystemPasswordChar = true;
            txtboxpassw.StateCommon.Content.Color1 = Color.White;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            FormRegister registrarse = new FormRegister(_usuarioBusiness);
            Hide();

            if (registrarse.ShowDialog() == DialogResult.OK)
            {
                _loggedUser = _usuarioBusiness.ObtainUsuario(txtboxuser.Text);
                RJMessageBox.Show("Registrado Correctamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show();
            }
            else
            {
                bool exit = false;
                while (!exit)
                {
                    DialogResult operao = RJMessageBox.Show("Cancelar operacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            if (e.KeyChar == (char)Keys.Enter && (txtboxpassw.Text != "Ingrese una contraseña" || txtboxpassw.Text == "".Trim()))
            {
                this.AcceptButton = btnlogin;//aceptar enter como click
                Point screenCoordinates = btnlogin.PointToScreen(Point.Empty);//manda al puntero al centro del boton

                Cursor.Position = new Point(screenCoordinates.X + btnlogin.Width / 2, screenCoordinates.Y + btnlogin.Height / 2);
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

                if (txtboxpassw.Text == "Ingrese una contraseña" || txtboxpassw.Text == "".Trim())
                {
                    txtboxpassw.UseSystemPasswordChar = true;
                    txtboxpassw.StateCommon.Content.Color1 = Color.White;
                    txtboxpassw.Focus();
                    txtboxpassw.Clear();
                }
                else
                {
                    button1_Click(this, new EventArgs());
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnlogin.Enabled = true;
        }
    }
}
