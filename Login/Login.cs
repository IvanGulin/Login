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
                ComprobarAdmin();
                entradaUsuario.Text = "";
                entradaContraseña.Text = "";
            }
            else
            {
                entradaUsuario.Text = "";
                entradaContraseña.Text = "";
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void ComprobarAdmin()
        {
            if (entradaUsuario.Text.Equals("administrador") || sql.EsAdmin(entradaUsuario.Text))
            {
                MessageBox.Show("Menú administrador.");
                MenuAdmin menu = new MenuAdmin();
                Hide();
                menu.Show();
                menu.FormClosed += (s, args) => Show();
            }
            else
            {
                MessageBox.Show("Acceso concedido.");
                PerfilUsuario perfil = new PerfilUsuario(entradaUsuario.Text);
                Hide();
                perfil.Show();
                perfil.FormClosed += (s, args) => Show();
            }
        }

        private void entradaContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && entradaUsuario.Text.Length > 4 && entradaContraseña.Text.Length > 4)
            {
                ComprobarLogin();
            }
        }
    }
}
