﻿using Login.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    public partial class MenuPrincipal : Form
    {
        private string nombreUsuario, trans, transLogros;
        private int velocidadPanel = 15;
        private int posicionMax = 462;
        private int posicionMin;
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        private ClaseSQL sql = new ClaseSQL();
        private List<string> logros = new List<string>();
        private List<int> listaLogroID = new List<int>();
        private ComprobarLogros comprobarLogros = new ComprobarLogros();
        private Timer timerPanel;
        private MensajeLogro mensajeLogro;
        private PerfilUsuario perfil;
        private bool comprobadoPerfil, comprobadoImagen;
        private MenuAdmin menuAdmin;
        private Aplicacion weather;
        private Logros logro;
        private byte persona;

        private Timer timerEsconder;

        public MenuPrincipal(string nombreUsuario)
        {
            InitializeComponent();

            // Inicialización del Timer
            timerPanel = new Timer();
            timerPanel.Interval = 3000;
            timerPanel.Tick += TimerPanel_Tick;

            timerLogros = new Timer();
            timerLogros.Interval = 30;
            timerLogros.Tick += timerLogros_Tick;

            timerTrans = new Timer();
            timerTrans.Interval = 30;
            timerTrans.Tick += timerTrans_Tick;

            timerEsconder = new Timer();
            timerEsconder.Interval = 3000;
            timerEsconder.Tick += TimerEsconder_Tick;

            posicionMin = panelForm.Right - 500;

            this.nombreUsuario = nombreUsuario;

            labelPerfil.Visible = false;
            labelWeather.Visible = false;
            labelLogros.Visible = false;
            labelCerrarSesion.Visible = false;
            panelLogros.Visible = false;
            labelAdmin.Visible = false;
            pb_MenuAdmin.Visible = false;
            pb_MenuAdmin.Enabled = false;
            pb_Activo1.Visible = false;
            pb_Activo2.Visible = false;
            pb_Activo3.Visible = false;
            pb_Activo4.Visible = false;
            pb_Activo1.Enabled = false;
            pb_Activo2.Enabled = false;
            pb_Activo3.Enabled = false;
            pb_Activo4.Enabled = false;
            pb_Activo5.Visible = false;
            pb_Persona.Visible = false; 
            pb_Persona.Enabled = false;
            labelPersona.Visible = false;

            ComprobarPersona();

            //sql.BorrarTodosLogrosUsuario(nombreUsuario);
            perfil = new PerfilUsuario(nombreUsuario);
            IniciarPerfil();
            IniciarTiempo();
            UpdatePerfil();
        }

        private void ComprobarPersona()
        {
            if (nombreUsuario.ToLower().Contains("carla"))
            {
                pb_Persona.Image = Resources.probeta;
                labelPersona.Text = "La Química";
                pb_Persona.Visible = true;
                pb_Persona.Enabled = true;
                persona = 1;

            }
            else if (nombreUsuario.ToLower().Contains("iyan"))
            {
                pb_Persona.Image = Resources.bombero;
                labelPersona.Text = "El Bombero";
                pb_Persona.Visible = true;
                pb_Persona.Enabled = true;
                persona = 2;
            }
            else if (nombreUsuario.ToLower().Contains("fer"))
            {
                pb_Persona.Image = Resources.tonto;
                labelPersona.Text = "El Tonto";
                pb_Persona.Visible = true;
                pb_Persona.Enabled = true;
                persona = 3;
            }
        }

        private void MostrarMensaje()
        {
            if (persona == 1)
            {
                MessageBox.Show("Hola carla UwU");
            }
            else if (persona == 2)
            {
                MessageBox.Show("Hola iyán bomberín");
            }
            else if (persona == 3)
            {
                ParaFer paraFer = new ParaFer();
                paraFer.ShowDialog();
            }
        }

        private void TimerPanel_Tick(object sender, EventArgs e)
        {
            timerPanel.Stop();
            MostrarPanel("Logro Ejemplo");
        }

        private void TimerEsconder_Tick(object sender, EventArgs e)
        {
            timerEsconder.Stop();
            transLogros = "Salida";
            timerLogros.Start();
        }

        private void MostrarPanel(string logro)
        {
            panelLogros.Visible = true;
            panelLogros.Left = panelForm.Right + 50;
            transLogros = "Entrada";
            mensajeLogro = new MensajeLogro("Logro Completado: " + logro);
            mensajeLogro.BringToFront();

            ShowFormInPanel(mensajeLogro, panelLogros);

            timerLogros.Start();
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
            perfil = new PerfilUsuario(nombreUsuario);
            perfil.PasarLogro += new PerfilUsuario.pasarLogros(ejecutar);

            if (sql.EsAdmin(nombreUsuario))
            {
                pb_MenuAdmin.Visible = true;
                pb_MenuAdmin.Enabled = true;
            }

            if (comprobarLogros.EsPrimeraVez(1, nombreUsuario))
            {
                sql.AddLogroUsuario(nombreUsuario, 1);
                MostrarPanel("Primer Login.");
            }
        }

        private void UpdatePerfil()
        {
            ShowFormInPanel(perfil, panelForm);
            labelVentana.Text = "PERFIL";
        }

        private void ejecutar(int logro)
        {
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
                comprobadoImagen = true;
            }
        }

        private void pb_Perfil_Click(object sender, EventArgs e)
        {
            UpdatePerfil();
        }

        private void ListaLogros()
        {
            logros = sql.GetListaLogros(nombreUsuario);
        }

        private void pb_Weather_Click(object sender, EventArgs e)
        {
            UpdateTiempo();

            if (comprobarLogros.EsPrimeraVez(4, nombreUsuario))
            {
                sql.AddLogroUsuario(nombreUsuario, 4);
                MostrarPanel("Utiliza la app del Tiempo.");
            }
        }

        private void IniciarTiempo()
        {
            weather = new Aplicacion();
        }

        private void UpdateTiempo()
        {
            labelVentana.Text = "EL TIEMPO";
            ShowFormInPanel(weather, panelForm);
        }

        private void pb_Logros_Click(object sender, EventArgs e)
        {
            labelVentana.Text = "LOGROS";
            logro = new Logros(nombreUsuario);
            ShowFormInPanel(logro, panelForm);
        }

        private void pb_MenuAdmin_Click(object sender, EventArgs e)
        {
            trans = "SalidaSinCerrar";
            timerTrans.Start();

            // Verificar si ya existe una instancia de MenuAdmin
            if (menuAdmin == null || menuAdmin.IsDisposed)
            {
                // Si no existe o está descartada, crear una nueva instancia
                menuAdmin = new MenuAdmin();

                // Suscribir al evento FormClosed para manejar el retorno al MenuPrincipal
                menuAdmin.FormClosed += (s, args) =>
                {
                    // Mostrar el MenuPrincipal al cerrarse el MenuAdmin
                    this.Show();
                    menuAdmin.Dispose(); // Liberar recursos de MenuAdmin
                    menuAdmin = null;
                    trans = "Entrada";
                    timerTrans.Start();
                };

                this.Hide();
                menuAdmin.Show();
            }
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
            pb_Activo1.Visible = true;
        }

        private void pb_Perfil_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(pb_Perfil);
            labelPerfil.Visible = false;
            pb_Activo1.Visible = false;
        }

        private void pb_Weather_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(pb_Weather);
            labelWeather.Visible = true;
            pb_Activo2.Visible = true;
        }

        private void pb_Weather_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(pb_Weather);
            labelWeather.Visible = false;
            pb_Activo2.Visible = false;
        }

        private void pb_Logros_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(pb_Logros);
            labelLogros.Visible = true;
            pb_Activo3.Visible = true;
        }

        private void pb_Logros_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(pb_Logros);
            labelLogros.Visible = false;
            pb_Activo3.Visible = false;
        }

        private void pb_Admin_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(pb_MenuAdmin);
            labelAdmin.Visible = true;
            pb_Activo4.Visible = true;
        }

        private void pb_Admin_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(pb_MenuAdmin);
            labelAdmin.Visible = false;
            pb_Activo4.Visible = false;
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
            trans = "Salida";
            timerTrans.Start();
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

        private void pb_Persona_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter(pb_Persona);
            labelPersona.Visible = true;
            pb_Activo5.Visible = true;
        }

        private void pb_Persona_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(pb_Persona);
            labelPersona.Visible = false;
            pb_Activo5.Visible = false;
        }

        private void pb_Persona_Click(object sender, EventArgs e)
        {
            MostrarMensaje();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.trans = "Entrada";
            timerTrans.Start();
        }

        private void timerTrans_Tick(object sender, EventArgs e)
        {
            if (trans == "Salida")
            {
                if (this.Opacity == 0)
                {
                    timerTrans.Stop();
                    Application.Exit();
                }
                else
                {
                    this.Opacity = this.Opacity - .1;
                }
            }
            else if (trans == "SalidaSinCerrar")
            {
                if (this.Opacity == 0)
                {
                    timerTrans.Stop();
                }
                else
                {
                    this.Opacity = this.Opacity - .1;
                }
            }
            else if (trans == "Entrada")
            {
                if (this.Opacity == 1)
                {
                    timerTrans.Stop();
                }
                else
                {
                    this.Opacity = this.Opacity + .15;
                }
            }
        }

        private void timerLogros_Tick(object sender, EventArgs e)
        {
            Animacion();
        }

        private void Animacion()
        {
            if (transLogros == "Salida")
            {
                if (panelLogros.Left < panelForm.Right)
                {
                    panelLogros.Left += velocidadPanel;

                    if (panelLogros.Left >= panelForm.Right)
                    {
                        panelLogros.Left = panelForm.Right;
                        timerLogros.Stop();
                        panelLogros.Visible = false;
                    }
                }
                else
                {
                    timerLogros.Stop();
                }
            }
            else if (transLogros == "Entrada")
            {
                if (panelLogros.Left > posicionMax)
                {
                    panelLogros.Left -= velocidadPanel;

                    if (panelLogros.Left <= posicionMax)
                    {
                        panelLogros.Left = posicionMax;
                        timerLogros.Stop();
                        timerEsconder.Start();
                    }
                }
                else
                {
                    timerLogros.Stop();
                    timerEsconder.Start();
                }
            }
        }
    }
}