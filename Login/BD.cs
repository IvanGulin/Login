using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Login
{
    internal class BD
    {
        private string connectionString;

        public BD(string ruta)
        {
            connectionString = $"Data Source={ruta};Version=3;";
            IniciarBD();
            //AddLogros();
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
                    Descripcion TEXT NULL,
                    Correo TEXT NOT NULL,
                    Imagen INTEGER NULL,
                    FOREIGN KEY (NombreUsuario) REFERENCES Login (NombreUsuario)
                )";

                string createAdminTable = @"
                CREATE TABLE IF NOT EXISTS Admin (
                    NombreUsuario TEXT PRIMARY KEY,
                    FOREIGN KEY (NombreUsuario) REFERENCES Login (NombreUsuario)
                )";

                string createLogrosInfoTable = @"
                CREATE TABLE IF NOT EXISTS LogrosInfo(
                    LogroID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nombre TEXT NOT NULL
                )";

                string createLogrosUsuarioTable = @"
                CREATE TABLE IF NOT EXISTS LogrosUsuario(
                    UsuarioLogroID INTEGER PRIMARY KEY AUTOINCREMENT,
                    NombreUsuario TEXT,
                    LogroID INTEGER NOT NULL,
                    FOREIGN KEY (NombreUsuario) REFERENCES Login (NombreUsuario),
                    FOREIGN KEY (LogroID) REFERENCES LogrosInfo (LogroID)
                )";

                using (var command = new SQLiteCommand(createLoginTable, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (var command = new SQLiteCommand(createDatosUsuariosTable, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (var command = new SQLiteCommand(createAdminTable, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (var command = new SQLiteCommand(createLogrosInfoTable, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (var command = new SQLiteCommand(createLogrosUsuarioTable, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        /*
        private void AddLogros()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string createLoginTable = @"INSERT INTO LogrosInfo (Nombre) VALUES
                    ('Primer Login.'),
                    ('Cambiar la imagen de perfil.'),
                    ('Modifica tus datos personales.'),
                    ('Utiliza la app del Tiempo.');";

                    using (var command = new SQLiteCommand(createLoginTable, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Datos insertados.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        */
    }
}
