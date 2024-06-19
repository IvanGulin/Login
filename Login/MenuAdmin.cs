using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Login
{
    public partial class MenuAdmin : Form
    {
        ClaseSQL sql = new ClaseSQL();
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Registro registrar = new Registro();
            Hide();
            registrar.Show();
            registrar.FormClosed += (s, args) => Show();
        }

        private void btn_MostrarTodosUsuarios_Click(object sender, EventArgs e)
        {
            ListaUsuarios listaUsuarios = new ListaUsuarios();
            listaUsuarios.ShowDialog();
        }

        private void EliminarUsuario_Click(object sender, EventArgs e)
        {
            EliminaUsuario eliminar = new EliminaUsuario();
            eliminar.ShowDialog();

            String usuario = eliminar.Respuesta;
            sql.EliminarUsuario(usuario);
        }
    }
}
