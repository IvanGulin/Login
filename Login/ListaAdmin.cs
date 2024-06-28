using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
