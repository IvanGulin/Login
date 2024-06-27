using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    public partial class MenuAdmin : Form
    {
        ClaseSQL sql = new ClaseSQL();
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
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

            if (!string.IsNullOrEmpty(usuario))
            {
                if (usuario != "administrador")
                {
                    sql.EliminarUsuario(usuario);
                }
                else
                {
                    MessageBox.Show("Usuario no válido.");
                }
            }
        }

        private void btn_MostrarTodosAdmin_Click(object sender, EventArgs e)
        {
            sql.MostrarAdmins();
        }

        private void panelVentana_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panelVentana_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void panelVentana_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FondoPanelOn(Panel panel)
        {
            panel.BackColor = Color.FromArgb(42, 40, 120);
        }
        private void FondoPanelOff(Panel panel)
        {
            panel.BackColor = Color.FromArgb(42, 40, 51);
        }

        private void panelCerrar_MouseEnter(object sender, EventArgs e)
        {
            FondoPanelOn(panelCerrar);
        }

        private void panelMinimizar_MouseEnter(object sender, EventArgs e)
        {
            FondoPanelOn(panelMinimizar);
        }

        private void panelMinimizar_MouseLeave(object sender, EventArgs e)
        {
            FondoPanelOff(panelMinimizar);
        }

        private void panelCerrar_MouseLeave(object sender, EventArgs e)
        {
            FondoPanelOff(panelCerrar);
        }
    }
}
