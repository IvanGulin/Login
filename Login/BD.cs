using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Login
{
    internal class BD
    {
        private string connectionString;

        public BD(string ruta)
        {
            connectionString = $"Data Source={ruta};Version=3;";
            IniciarBD();
        }

        private void IniciarBD()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string createLoginTable = @"
                CREATE TABLE IF NOT EXISTS Login (
                    NombreUsuario TEXT PRIMARY KEY,
                    Contraseña TEXT NOT NULL
                )";

                string createDatosUsuariosTable = @"
                CREATE TABLE IF NOT EXISTS DatosUsuarios (
                    NombreUsuario TEXT PRIMARY KEY,
                    Nombre TEXT NULL,
                    Apellidos TEXT NULL,
                    Correo TEXT NOT NULL,
                    FOREIGN KEY (NombreUsuario) REFERENCES Login (NombreUsuario)
                )";

                using (var command = new SQLiteCommand(createLoginTable, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (var command = new SQLiteCommand(createDatosUsuariosTable, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
