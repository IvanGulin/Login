using System;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    public partial class MenuPrincipal : Form
    {
        private string nombreUsuario;
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        public MenuPrincipal(string nombreUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            labelPerfil.Visible = false;
            labelWeather.Visible = false;
            labelCerrarSesion.Visible = false;

            IniciarPerfil();
        }

        private void ShowFormInPanel(Form form)
        {
            // Limpiar el panel de cualquier formulario existente
            panelForm.Controls.Clear();

            // Configurar el formulario para que no sea de nivel superior
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Añadir el formulario al panel y mostrarlo
            panelForm.Controls.Add(form);
            form.Show();
        }

        private void IniciarPerfil()
        {
            PerfilUsuario perfil = new PerfilUsuario(nombreUsuario);
            ShowFormInPanel(perfil);
            labelVentana.Text = "PERFIL";
        }

        private void pb_Perfil_Click(object sender, EventArgs e)
        {
            IniciarPerfil();
        }

        private void pb_Weather_Click(object sender, EventArgs e)
        {
            labelVentana.Text = "EL TIEMPO";
            Aplicacion weather = new Aplicacion();
            ShowFormInPanel(weather);
        }

        private void pb_Logout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private new void MouseEnter(PictureBox pb)
        {
            pb.BackColor = Color.FromArgb(42, 40, 70);
            pb.Size = new Size(60, 60);
        }

        private new void MouseLeave(PictureBox pb)
        {
            pb.BackColor = Color.FromArgb(42, 40, 51);
            pb.Size = new Size(50, 50);
        }

        private void pb_Perfil_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(pb_Perfil);
            labelPerfil.Visible = true;
        }

        private void pb_Perfil_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(pb_Perfil);
            labelPerfil.Visible = false;
        }

        private void pb_Weather_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(pb_Weather);
            labelWeather.Visible = true;
        }

        private void pb_Weather_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(pb_Weather);
            labelWeather.Visible = false;
        }

        private void pb_Logout_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(pb_Logout);
            labelCerrarSesion.Visible = true;
        }

        private void pb_Logout_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(pb_Logout);
            labelCerrarSesion.Visible = false;
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
