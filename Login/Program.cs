using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Login
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process[] process = Process.GetProcessesByName("Login");

            if (process.Length == 1)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Ruta a la base de datos SQLite
                string ruta = "usuarios.db";

                // Crear instancia de DatabaseHelper
                BD baseDatos = new BD(ruta);

                Application.Run(new Login());
            }
            else
            {
                MessageBox.Show("La aplicación ya está abierta.");
            }
            
        }
    }
}
