using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Login
{
    internal class ClaseSQL
    {
        private String cadenaConexion = "Server=DESKTOP-P9URU7F;Database=Usuarios;Integrated Security=true;TrustServerCertificate=True;";

        public bool ValidarUsuario(string nombreUsuario, string contraseña)
        {
            string query = "SELECT COUNT(*) FROM Login WHERE NombreUsuario = @NombreUsuario AND Contraseña = @Contraseña";

            using (SqlConnection sql = new SqlConnection(cadenaConexion))
            using (SqlCommand command = new SqlCommand(query, sql))
            {
                command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                command.Parameters.AddWithValue("@Contraseña", contraseña);

                try
                {
                    sql.Open();
                    int result = (int)command.ExecuteScalar();
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

            using (SqlConnection sql = new SqlConnection(cadenaConexion))
            {
                SqlCommand command = new SqlCommand(query, sql);
                command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                try
                {
                    sql.Open();
                    int result = (int)command.ExecuteScalar();

                    if (result == 0)
                    {
                        // Utilizar una transacción para asegurar que ambas inserciones se realicen correctamente
                        using (SqlTransaction transaction = sql.BeginTransaction())
                        {
                            try
                            {
                                string queryLogin = "INSERT INTO Login (NombreUsuario, Contraseña) VALUES (@NombreUsuario, @Contraseña)";
                                string queryDatos = "INSERT INTO DatosUsuarios (NombreUsuario, Correo) VALUES (@NombreUsuario, @Correo)";

                                using (SqlCommand addUsuario = new SqlCommand(queryLogin, sql, transaction))
                                using (SqlCommand addDatos = new SqlCommand(queryDatos, sql, transaction))
                                {
                                    addUsuario.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                                    addUsuario.Parameters.AddWithValue("@Contraseña", contraseña);

                                    addDatos.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                                    addDatos.Parameters.AddWithValue("@Correo", correo);

                                    addUsuario.ExecuteNonQuery();
                                    addDatos.ExecuteNonQuery();

                                    // Confirmar la transacción si ambos comandos se ejecutaron correctamente
                                    transaction.Commit();
                                }

                                return true;
                            }
                            catch
                            {
                                // Revertir la transacción en caso de error
                                transaction.Rollback();
                                throw;
                            }
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
    }
}
