using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    public partial class Logros : Form
    {
        private ClaseSQL sql = new ClaseSQL();
        private List<string> logros = new List<string>();
        private string nombreUsuario;
        public Logros(string nombreUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            labelLogro1.Text = "Logro 'Primer Login.'";
            labelLogro2.Text = "Logro 'Cambiar la imagen de perfil.'";
            labelLogro3.Text = "Logro 'Modifica tus datos personales.'";
            labelLogro4.Text = "Logro 'Utiliza la app del Tiempo.'";
            CargarLogros();
            RecorrerLogros();
        }

        private void CargarLogros()
        {
            logros = sql.GetListaLogros(nombreUsuario);
        }

        private void RecorrerLogros()
        {
            foreach (var logro in logros)
            {
                switch (logro.ToString())
                {
                    case "Primer Login.":
                        panelLogro1.BackColor = Color.FromArgb(128, 128, 255);
                        labelLogro1.Text += " Completado.";
                        labelLogro1.Enabled = true;
                        break;
                    case "Cambiar la imagen de perfil.":
                        panelLogro2.BackColor = Color.FromArgb(128, 128, 255);
                        labelLogro2.Text += " Completado.";
                        labelLogro2.Enabled = true;
                        break;
                    case "Modifica tus datos personales.":
                        panelLogro3.BackColor = Color.FromArgb(128, 128, 255);
                        labelLogro3.Text += " Completado.";
                        labelLogro3.Enabled = true;
                        break;
                    case "Utiliza la app del Tiempo.":
                        panelLogro4.BackColor = Color.FromArgb(128, 128, 255);
                        labelLogro4.Text += " Completado.";
                        labelLogro4.Enabled = true;
                        break;
                }
            }
        }
    }
}
