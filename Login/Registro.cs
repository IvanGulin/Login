using System;
using System.Windows.Forms;

namespace Login
{
    public partial class Registro : Form
    {
        private ClaseSQL sql = new ClaseSQL();
        public Registro()
        {
            InitializeComponent();
        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        private void Registrar()
        {
            if (ComprobarDatos())
            {
                MessageBox.Show("Usuario registrado correctamente.");
                Close();
            }
        }

        private bool ComprobarDatos()
        {
            if (entradaUsuario.Text.Length > 6 && entradaContraseña.Text.Length > 6
                && entradaCorreo.Text.Length > 10 && entradaContraseña.Text.Equals(entradaContraseña2.Text))
            {
                if (sql.AddUsuario(entradaUsuario.Text, entradaContraseña.Text, entradaCorreo.Text))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Ese usuario ya esta registrado.");
                    return false;
                }
            }
            MessageBox.Show("Usuario / contraseña / correo no válidos.\n" +
                "Usuario y contraseña deben tener mas de 6 carácteres.\n" +
                "El correo debe tener más de 10 carácteres.");
            entradaContraseña.Text = "";
            entradaContraseña2.Text = "";
            return false;
        }

        private void entradaContraseña2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && entradaUsuario.Text.Length > 1 && entradaContraseña.Text.Length > 1
                && entradaContraseña2.Text.Length > 1 && entradaCorreo.Text.Length > 1)
            {
                Registrar();
            }
        }

        private void botonLogin_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
