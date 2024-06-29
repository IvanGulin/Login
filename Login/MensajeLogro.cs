using System.Windows.Forms;

namespace Login
{
    public partial class MensajeLogro : Form
    {
        public MensajeLogro(string logro)
        {
            InitializeComponent();
            labelTextoLogro.Text = logro;
        }
    }
}
