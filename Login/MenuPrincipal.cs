using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    public partial class MenuPrincipal : Form
    {
        private string nombreUsuario;
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        private ClaseSQL sql = new ClaseSQL();
        private List<string> logros = new List<string>();
        private List<int> listaLogroID = new List<int>();
        private ComprobarLogros comprobarLogros = new ComprobarLogros();
        private Timer timerPanel;
        private MensajeLogro mensajeLogro;
        private PerfilUsuario perfil;
        private bool cambioPerfil, cambioImagenPerfil;
        private bool comprobadoPerfil, comprobadoImagen;

        public MenuPrincipal(string nombreUsuario)
        {
            InitializeComponent();

            // Inicialización del Timer
            timerPanel = new Timer();
            timerPanel.Interval = 3000;
            timerPanel.Tick += TimerPanel_Tick;

            this.nombreUsuario = nombreUsuario;

            labelPerfil.Visible = false;
            labelWeather.Visible = false;
            labelLogros.Visible = false;
            labelCerrarSesion.Visible = false;
            panelLogros.Visible = false;
            labelAdmin.Visible = false;
            pb_MenuAdmin.Visible = false;
            pb_MenuAdmin.Enabled = false;

            //sql.BorrarTodosLogrosUsuario(nombreUsuario);

            IniciarPerfil();
        }

        private void TimerPanel_Tick(object sender, EventArgs e)
        {
            panelLogros.Visible = false;
            timerPanel.Stop();
        }

        private void MostrarPanel(string logro)
        {
            timerPanel.Stop();

            mensajeLogro = new MensajeLogro("Logro Completado: " + logro);
            panelLogros.Visible = true;
            mensajeLogro.BringToFront();

            ShowFormInPanel(mensajeLogro, panelLogros);
            
            timerPanel.Start();  
        }

        private void ShowFormInPanel(Form form, Panel panel)
        {
            // Limpiar el panel de cualquier formulario existente
            panel.Controls.Clear();

            // Configurar el formulario para que no sea de nivel superior
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
           
            // Añadir el formulario al panel y mostrarlo
            panel.Controls.Add(form);
            form.Show();
        }

        private void IniciarPerfil()
        {
            if (sql.EsAdmin(nombreUsuario))
            {
                pb_MenuAdmin.Visible = true;
                pb_MenuAdmin.Enabled = true;
            }
            perfil = new PerfilUsuario(nombreUsuario, listaLogroID);      
            perfil.PasarLogro += new PerfilUsuario.pasarLogros(ejecutar);
            ShowFormInPanel(perfil, panelForm);
            labelVentana.Text = "PERFIL";

            if (comprobarLogros.EsPrimeraVez(1, listaLogroID, nombreUsuario))
            {
                sql.AddLogroUsuario(nombreUsuario, 1);
                MostrarPanel("Primer Login.");
            }
        }

        private void ejecutar (int logro)
        {
            cambioPerfil = true;
            ComprobarLogrosPerfil(logro);
        }

        private void ComprobarLogrosPerfil(int logro)
        {
            if (logro == 1 && !comprobadoPerfil)
            {
                MostrarPanel("Modifica tus datos personales.");
                comprobadoPerfil = true;
            }

            if (logro == 2 && !comprobadoImagen)
            {
                MostrarPanel("Cambiar la imagen de perfil.");
            }
        }

        private void pb_Perfil_Click(object sender, EventArgs e)
        {
            IniciarPerfil();
        }

        private void ListaLogros()
        {
            logros = sql.GetListaLogros(nombreUsuario);
        }

        private void pb_Weather_Click(object sender, EventArgs e)
        {
            labelVentana.Text = "EL TIEMPO";
            Aplicacion weather = new Aplicacion();
            ShowFormInPanel(weather, panelForm);

            if (comprobarLogros.EsPrimeraVez(4, listaLogroID, nombreUsuario))
            {
                sql.AddLogroUsuario(nombreUsuario, 4);
                MostrarPanel("Utiliza la app del Tiempo.");
            }
        }

        private void pb_Logros_Click(object sender, EventArgs e)
        {
            labelVentana.Text = "LOGROS";
            Logros logro = new Logros(nombreUsuario);
            ShowFormInPanel(logro, panelForm);
        }

        private void pb_MenuAdmin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menú administrador.");
            MenuAdmin menu = new MenuAdmin();
            Hide();
            menu.Show();
            menu.FormClosed += (s, args) => Show();
        }

        private void pb_Logout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private new void MouseEnter(PictureBox pb)
        {
            pb.Size = new Size(60, 60);
        }

        private new void MouseLeave(PictureBox pb)
        {   
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

        private void pb_Logros_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(pb_Logros);
            labelLogros.Visible = true;
        }

        private void pb_Logros_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(pb_Logros);
            labelLogros.Visible = false;
        }

        private void pb_Admin_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(pb_MenuAdmin);
            labelAdmin.Visible = true;
        }

        private void pb_Admin_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(pb_MenuAdmin);
            labelAdmin.Visible = false;
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
            Application.Exit();
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