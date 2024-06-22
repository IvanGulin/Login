﻿using System;
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

        public void EliminarUsuario(string usuario)
        {
            string queryLogin = "DELETE FROM Login WHERE NombreUsuario = @Usuario";
            string queryDatosUsuarios = "DELETE FROM DatosUsuarios WHERE NombreUsuario = @Usuario";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SQLiteCommand commandLogin = new SQLiteCommand(queryLogin, connection))
                        {
                            commandLogin.Parameters.AddWithValue("@Usuario", usuario);
                            int resultLogin = commandLogin.ExecuteNonQuery();

                            // Eliminar de la tabla DatosUsuarios solo si se eliminó algo en Login
                            if (resultLogin > 0)
                            {
                                using (SQLiteCommand commandDatosUsuarios = new SQLiteCommand(queryDatosUsuarios, connection))
                                {
                                    commandDatosUsuarios.Parameters.AddWithValue("@Usuario", usuario);
                                    commandDatosUsuarios.ExecuteNonQuery();
                                }

                                transaction.Commit();
                                MessageBox.Show("Usuario eliminado correctamente.");
                            }
                            else
                            {
                                transaction.Rollback();
                                MessageBox.Show("No se encontró el usuario.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
                    }
                }
            }
        }

        public DataTable LlenarDataGridView()
        {
            string query = "SELECT NombreUsuario FROM Login"; // !TODO arreglar query y borrado

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
