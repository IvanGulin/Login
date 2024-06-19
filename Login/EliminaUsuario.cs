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
            Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
