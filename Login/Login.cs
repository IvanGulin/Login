using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        private Dictionary<string, string> usuarios;
        public Login()
        {
            InitializeComponent();

            usuarios = new Dictionary<string, string>();
            CargarAdmin();
        }

        private void CargarAdmin()
        {
            usuarios.Add("admin", "admin");
        }

        private bool ComprobarUsuario()
        {
            foreach (var usuario in usuarios)
            {
                if (entradaUsuario.Text.Equals(usuario.Key) && entradaContraseña.Text.Equals(usuario.Value))
                {
                    return true;
                }
            }
            return false;
        }

        private void botonEntrar_Click(object sender, EventArgs e)
        {
            if (entradaUsuario.Text.Length > 4 && entradaContraseña.Text.Length > 4)
            {
                ComprobarLogin();
            }
            else
            {
                MessageBox.Show("*El usuario y contraseña deben tener mas de 4 carácteres.*");
            }
        }

        private void ComprobarLogin()
        {
            if (ComprobarUsuario())
            {
                entradaUsuario.Text = "";
                entradaContraseña.Text = "";
                MessageBox.Show("Accediendo correctamente.");
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
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("*El usuario y contraseña deben tener mas de 4 carácteres.*");
            }
        }

        private void botonRegistrarse_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro(ref usuarios);
            registro.ShowDialog();
        }
    }
}
