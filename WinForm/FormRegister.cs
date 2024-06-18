using Krypton.Toolkit;
using Proyecto.Core.Business.Interfaces;
using Proyecto.Core.Entities;
using WinForm.CustomMessageBox;

namespace WinForm
{
    public partial class FormRegister : KryptonForm
    {
        private readonly IUsuarioBusiness _usuarioBusiness;
        public Usuario User = null!;
        public FormRegister(IUsuarioBusiness usuarioBusiness)
        {
            _usuarioBusiness = usuarioBusiness;
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            string username = txtNombreUsuario.Text;
            string pass = txtContraseña.Text;

            if (txtNombreUsuario.Text.Trim() != "" && txtContraseña.Text != "Ingrese una contraseña" && txtContraseña.Text.Trim() != "" && _usuarioBusiness.CreateUsuario(username, pass))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else if (txtNombreUsuario.Text.Trim() == "")
            {
                RJMessageBox.Show("Usuario no puede estar vacio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtContraseña.Text.Trim() == "" || txtContraseña.Text == "Ingrese una contraseña")
            {
                RJMessageBox.Show("Ingrese una contraseña!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                RJMessageBox.Show("Usuario existente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txtContraseña.Text != "".Trim())
            {
                this.AcceptButton = btnRegistrarse;
                Point screenCoordinates = btnRegistrarse.PointToScreen(Point.Empty);

                Cursor.Position = new Point(screenCoordinates.X + btnRegistrarse.Width / 2, screenCoordinates.Y + btnRegistrarse.Height / 2);
                if (e.KeyChar == (char)Keys.Space)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                if (txtContraseña.Text == "".Trim())
                {
                    txtContraseña.Focus();
                    txtContraseña.Clear();
                }
                else
                {
                    btnRegistrarse_Click(this, new EventArgs());
                }
            }
        }
    }
}
