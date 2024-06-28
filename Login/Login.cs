using System;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        private ClaseSQL sql = new ClaseSQL();
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        private string trans;
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
            trans = "Salida";
            timerTrans.Start();

            if (entradaUsuario.Text.Equals("administrador") )
            {
                MenuAdmin menu = new MenuAdmin();
                Hide();
                menu.Show();
                Login login = new Login();
                menu.FormClosed += (s, args) => login.Show();
            }
            else
            {
                MenuPrincipal menuPrincipal = new MenuPrincipal(entradaUsuario.Text);
                Hide();
                menuPrincipal.Show();
                Login login = new Login();
                menuPrincipal.FormClosed += (s, args) => login.Show();
                
            }
        }

        private void entradaContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && entradaUsuario.Text.Length > 4 && entradaContraseña.Text.Length > 4)
            {
                ComprobarLogin();
            }
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
            trans = "Cerrar";
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

        private void Login_Load(object sender, EventArgs e)
        {
            this.trans = "Entrada";
            this.Top = this.Top + 15;
            timerTrans.Start();
        }

        private void timerTrans_Tick(object sender, EventArgs e)
        {
            if (trans == "Salida")
            {
                if(this.Opacity == 0)
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
                    this.Top = this.Top - 5;
                }
            }
            else if (trans == "Cerrar")
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
        }
    }
}
