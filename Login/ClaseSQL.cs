using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Login
{
    internal class ClaseSQL
    {
        private string connectionString = "Data Source=usuarios.db;Version=3;";

        public bool ValidarUsuario(string nombreUsuario, string contraseña)
        {
            string query = "SELECT COUNT(*) FROM Login WHERE NombreUsuario = @NombreUsuario AND Contraseña = @Contraseña";

            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                command.Parameters.AddWithValue("@Contraseña", contraseña);

                try
                {
                    connection.Open();
                    int result = Convert.ToInt32(command.ExecuteScalar());
                    return result > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                    return false;
                }
            }
        }
        public bool AddUsuario(string nombreUsuario, string contraseña, string correo)
        {
            string query = "SELECT COUNT(*) FROM Login WHERE NombreUsuario = @NombreUsuario";

            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                try
                {
                    connection.Open();
                    int result = Convert.ToInt32(command.ExecuteScalar());

                    if (result == 0)
                    {
                        string queryLogin = "INSERT INTO Login (NombreUsuario, Contraseña) VALUES (@NombreUsuario, @Contraseña)";
                        string queryDatos = "INSERT INTO DatosUsuarios (NombreUsuario, Correo) VALUES (@NombreUsuario, @Correo)";

                        using (var addUsuario = new SQLiteCommand(queryLogin, connection))
                        using (var addDatos = new SQLiteCommand(queryDatos, connection))
                        {
                            addUsuario.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                            addUsuario.Parameters.AddWithValue("@Contraseña", contraseña);
                            addDatos.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);  // Añadir parámetro
                            addDatos.Parameters.AddWithValue("@Correo", correo);

                            addUsuario.ExecuteNonQuery();
                            addDatos.ExecuteNonQuery();

                            return true;
                        }
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                    return false;
                }
            }
        }

        public List<string> MostrarTodosLosUsuarios()
        {
            List<string> nombresDeUsuario = new List<string>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "SELECT NombreUsuario FROM Login";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    connection.Open();

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nombresDeUsuario.Add(reader["NombreUsuario"].ToString());
                        }
                    }
                }
            }

            return nombresDeUsuario;
        }

        public void EliminarUsuario(String usuario)
        {
            string query = "DELETE FROM Login WHERE NombreUsuario = @Usuario";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Usuario",usuario);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery(); // Ejecutar el comando de eliminación

                    if (result > 0)
                    {
                        MessageBox.Show("Usuario eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el usuario.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public DataTable LlenarDataGridView()
        {
            string query = "SELECT NombreUsuario, Correo FROM DatosUsuarios";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
            {
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar el DataGridView: " + ex.Message);
                    return null;
                }
            }
        }
    }
}
