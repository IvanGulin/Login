using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Login
{
    public partial class Registro : Form
    {
        private Dictionary<string, string> usuarios;
        public Registro(ref Dictionary<string, string> usuarios)
        {
            InitializeComponent();
            this.usuarios = usuarios;
        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        private void Registrar()
        {
            if (ComprobarDatos())
            {
                usuarios.Add(entradaUsuario.Text, entradaContraseña.Text);
                Usuarios usuario = new Usuarios(entradaUsuario.Text, entradaContraseña.Text, entradaCorreo.Text);
                MessageBox.Show("Usuario registrado correctamente.");
                Close();
            }
        }

        private bool ComprobarDatos()
        {
            if (!usuarios.ContainsKey(entradaUsuario.Text))
            {
                if (entradaUsuario.Text.Length > 6 && entradaContraseña.Text.Length > 6 
                    && entradaCorreo.Text.Length > 10 && entradaContraseña.Text.Equals(entradaContraseña2.Text))
                {
                    return true;
                }
                MessageBox.Show("Usuario / contraseña / correo no válidos.");
                entradaContraseña.Text = "";
                entradaContraseña2.Text = "";
                return false;
            }
            else
            {
                MessageBox.Show("Ese usuario ya esta registrado.");
                return false;
            }
        }

        private void entradaContraseña2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && entradaUsuario.Text.Length > 1 && entradaContraseña.Text.Length > 1
                && entradaContraseña2.Text.Length > 1 && entradaCorreo.Text.Length > 1)
            {
                Registrar();
            }
        }
    }
}
