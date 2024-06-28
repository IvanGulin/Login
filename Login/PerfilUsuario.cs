using Login.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Login
{
    public partial class PerfilUsuario : Form
    {
        private string nombreUsuario;
        private ClaseSQL sql = new ClaseSQL();
        private List<string> datos;
        private string nombre, apellidos, correo, descripcion = "-";
        private byte imagen;
        private Usuarios usuario;
        private System.Windows.Forms.ImageList listaImagenes = new ImageList();
        private ElegirImagen elegirImagen = new ElegirImagen();
        private List<int> listaLogrosID;
        private ComprobarLogros cl = new ComprobarLogros();
        private bool cambioImagen, cambioDatos = false;

        public delegate void pasarLogros(int logro);
        public event pasarLogros PasarLogro;

        public PerfilUsuario(string nombreUsuario, List<int> listaLogrosID)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            this.listaLogrosID = listaLogrosID;
            listaImagenes = elegirImagen.GetListImage();

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
                    case 4: 
                        if (dato.Equals("")) imagen = 0;
                        else imagen = Convert.ToByte(dato);
                        break;
                }
                cont++;
            }
            this.usuario = new Usuarios(nombre, apellidos, descripcion, imagen);
        }

        private void LlenarDatos()
        {
            this.Text = "Perfil " + nombreUsuario;
            tbDescripcion.Text = descripcion;
            labelNombreUsuario.Text = nombreUsuario;
            tbNombre.Text = nombre;
            tbApellidos.Text = apellidos;
            tbCorreo.Text = correo;

            if (imagen == 0)
            {
                FotoUsuario.Image = Resources.fotoUsuario_removebg_preview;
            }
            else
            {
                CambiarImagen();
            }
        }

        private void DeshabilitarEdicion()
        {
            tbDescripcion.Enabled = false;
            tbNombre.Enabled = false;
            tbApellidos.Enabled = false;
            tbCorreo.Enabled = false;
            btnCerrar.Visible = false;
            btnCerrar.Enabled = false;
            pbEditar.Enabled = false;
            pbEditar.Visible = false;
            labelEditarPerfil.Cursor = Cursors.Hand;
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

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            elegirImagen.ShowDialog();
            imagen = elegirImagen.ImagenSeleccionada;

            if (cl.EsPrimeraVez(2, listaLogrosID, nombreUsuario))
            {
                sql.AddLogroUsuario(nombreUsuario, 2);
                cambioImagen = true;
                PasarLogro(2);
            }

            sql.AlmacenarImagen(imagen, nombreUsuario);
            CambiarImagen();
        }

        private void CambiarImagen()
        {
            if (imagen >= 0 && imagen < listaImagenes.Images.Count)
            {
                FotoUsuario.Image = listaImagenes.Images[imagen];
            }
            else
            {
                MessageBox.Show("El índice de la imagen es inválido.");
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
            pbEditar.Enabled = true;
            pbEditar.Visible = true;
            labelEditarPerfil.Cursor = Cursors.Default;
        }

        private void btnCerrar_Click(object sender, System.EventArgs e)
        {
            DeshabilitarEdicion();
            sql.AlmacenarDatos(tbNombre.Text, tbApellidos.Text, tbDescripcion.Text, tbCorreo.Text, nombreUsuario, imagen);

            if (cl.EsPrimeraVez(3, listaLogrosID, nombreUsuario))
            {
                sql.AddLogroUsuario(nombreUsuario, 3);
                cambioDatos = true;
            }

            PasarLogro(1);
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
