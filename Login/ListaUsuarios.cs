using System.Data;
using System.Windows.Forms;

namespace Login
{
    public partial class ListaUsuarios : Form
    {
        private ClaseSQL sql;
        public ListaUsuarios()
        {
            InitializeComponent();
            sql = new ClaseSQL();

            DataTable database = sql.LlenarDataGridView();
            dataGridViewUsuarios.DataSource = database;
        }
    }
}