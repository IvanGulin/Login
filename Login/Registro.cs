using System;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    public partial class Registro : Form
    {
        private ClaseSQL sql = new ClaseSQL();
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        private string trans;
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
                    if (CheckAdmin.Checked)
                    {
                        if (sql.AddAdmin(entradaUsuario.Text))
                        {
                            MessageBox.Show("Usuario Administrador registrado.");
                        }
                    }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            trans = "Cerrar";
            timerTrans.Start();
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

        private void timerTrans_Tick(object sender, EventArgs e)
        {
            if (trans == "Salida")
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
                    this.Top = this.Top - 5;
                }
            }
            else if (trans == "Cerrar")
            {
                if (this.Opacity == 0)
                {
                    timerTrans.Stop();
                    Close();
                }
                else
                {
                    this.Opacity = this.Opacity - .1;
                }
            }
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            this.trans = "Entrada";
            timerTrans.Start();
        }
    }
}
