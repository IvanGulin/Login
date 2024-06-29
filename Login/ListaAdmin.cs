using System.Data;
using System.Windows.Forms;

namespace Login
{
    public partial class ListaAdmin : Form
    {
        private ClaseSQL sql;
        public ListaAdmin()
        {
            InitializeComponent();
            sql = new ClaseSQL();
            DataTable database = sql.LlenarDataGridViewAdmin();
            dataGridViewUsuarios.DataSource = database;
        }
    }
}
