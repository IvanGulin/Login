using System;
using System.Windows.Forms;

namespace Login
{
    public partial class EliminaUsuario : Form
    {
        string respuesta;
        public string Respuesta { get => respuesta; set => respuesta = value; }

        public EliminaUsuario()
        {
            InitializeComponent();
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            Respuesta = textBox1.Text;
            if (!string.IsNullOrEmpty(Respuesta))
            {
                DialogResult result = MessageBox.Show($"¿Deseas eliminar el usuario: {Respuesta}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Close();
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("El usuario no fue eliminado.");
                    Respuesta = "";
                }
            }
            else
            {
                MessageBox.Show("Usuario no válido.");
            }
            Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
