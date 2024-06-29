using System;
using System.Windows.Forms;

namespace Login
{
    public partial class VerLogrosUsuarioInput : Form
    {
        private string nombreUsuario;
        public VerLogrosUsuarioInput()
        {
            InitializeComponent();
        }

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            nombreUsuario = textBoxUsuario.Text;
            Close();
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
