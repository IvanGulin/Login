using Login.Properties;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login
{
    public partial class PerfilUsuario : Form
    {
        private string nombreUsuario;
        private ClaseSQL sql = new ClaseSQL();
        private List<string> datos;
        private string nombre, apellidos, correo, descripcion = "-";
        private Usuarios usuario;

        public PerfilUsuario(string nombreUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;

            SerializarUsuario();
            LlenarDatos();
            DeshabilitarEdicion();
        }

        private void SerializarUsuario()
        {
            datos = sql.DatosUsuario(nombreUsuario);
            byte cont = 0;

            foreach (var dato in datos)
            {
                if (!dato.Equals(""))
                {
                    switch (cont)
                    {
                        case 0: nombre = dato.ToString();
                            break;
                        case 1: apellidos = dato.ToString(); 
                            break;
                        case 2: descripcion = dato.ToString();
                            break;
                        case 3: correo = dato.ToString();
                            break;
                    }
                }
                cont++;
            }

            this.usuario = new Usuarios(nombre, apellidos, descripcion, Resources.fotoUsuario_removebg_preview);
        }

        private void LlenarDatos()
        {
            this.Text = "Perfil " + nombreUsuario;
            tbDescripcion.Text = descripcion;
            labelNombreUsuario.Text = nombreUsuario;
            tbNombre.Text = nombre;
            tbApellidos.Text = apellidos;
            tbCorreo.Text = correo;
        }

        private void DeshabilitarEdicion()
        {
            tbDescripcion.Enabled = false;
            tbNombre.Enabled = false;
            tbApellidos.Enabled = false;
            tbCorreo.Enabled = false;
            btnCerrar.Visible = false;
            btnCerrar.Enabled = false;
        }

        private void tbDescripcion_TextChanged(object sender, System.EventArgs e)
        {
            byte maxLineas = 4;
            var lineas = tbDescripcion.Lines;

            if (lineas.Length > 4)
            {
                tbDescripcion.Lines = lineas.Take(maxLineas).ToArray();
                tbDescripcion.SelectionStart = tbDescripcion.Text.Length; 
            }
        }

        private void labelEditarPerfil_Click(object sender, System.EventArgs e)
        {
            tbDescripcion.Enabled = true;
            tbNombre.Enabled = true;
            tbApellidos.Enabled = true;
            tbCorreo.Enabled = true;
            btnCerrar.Visible = true;
            btnCerrar.Enabled = true;
            btnTemperaturas.Enabled = false;
            btnTemperaturas.Visible = false;
        }

        private void btnCerrar_Click(object sender, System.EventArgs e)
        {
            DeshabilitarEdicion();
            btnTemperaturas.Enabled = true;
            btnTemperaturas.Visible = true;
            sql.AlmacenarDatos(tbNombre.Text, tbApellidos.Text, tbDescripcion.Text, tbCorreo.Text, nombreUsuario);
        }

        private void btnTemperaturas_Click(object sender, System.EventArgs e)
        {
            Aplicacion aplicacion = new Aplicacion();
            Hide();
            aplicacion.Show();
            aplicacion.FormClosed += (s, args) => Show();
        }
    }
}
