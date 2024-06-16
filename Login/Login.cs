using System;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        private ClaseSQL sql = new ClaseSQL();
        public Login()
        {
            InitializeComponent();
        }

        private bool ComprobarUsuario()
        {
            return sql.ValidarUsuario(entradaUsuario.Text, entradaContraseña.Text);
        }

        private void botonEntrar_Click(object sender, EventArgs e)
        {
            if (entradaUsuario.Text.Length > 4 && entradaContraseña.Text.Length > 4)
            {
                ComprobarLogin();
            }
            else
            {
                MessageBox.Show("*El usuario y contraseña deben tener más de 4 carácteres.*");
            }
        }

        private void ComprobarLogin()
        {
            if (ComprobarUsuario())
            {
                entradaUsuario.Text = "";
                entradaContraseña.Text = "";
                MessageBox.Show("Acceso concedido.");
                Aplicacion app = new Aplicacion();
                app.ShowDialog();
            }
            else
            {
                entradaUsuario.Text = "";
                entradaContraseña.Text = "";
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void entradaContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && entradaUsuario.Text.Length > 4 && entradaContraseña.Text.Length > 4)
            {
                ComprobarLogin();
            }
        }

        private void botonRegistrarse_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.ShowDialog();
        }
    }
}
