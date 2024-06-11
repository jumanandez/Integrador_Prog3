using Proyecto.Core.Business.Interfaces;
using System.Text;
using System.Security.Cryptography;
using Proyecto.Core.Entities;

namespace WinForm
{
    public partial class FormLogin : Form
    {
        private readonly IUsuarioBusiness _usuarioBusiness;
        public Usuario _User;
        public FormLogin(IUsuarioBusiness usuarioBusiness)
        {
            _usuarioBusiness = usuarioBusiness;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool pass;
            if (_usuarioBusiness.CompareUserToDB(textBox1.Text))
            {
                pass = _usuarioBusiness.VerifyPassword(textBox1.Text, textBox2.Text);
                if (pass)
                {
                    this._User = _usuarioBusiness.ObtainUsuario(textBox1.Text);
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Bienvenenido");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta");
                }
            }
            else if(textBox1.Text.Trim() == "") 
            {
                MessageBox.Show("Usuario no puede estar vacio!");
            }
            else if(textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese una contraseña!");
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña Incorrecto!");
            }
        }
    }
}
