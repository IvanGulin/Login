namespace Login
{
    internal class Usuarios
    {
        private string nombreUsuario;
        private string password;
        private string correo;

        public Usuarios(string nombreUsuario, string password, string correo)
        {
            this.nombreUsuario = nombreUsuario;
            this.password = password;
            this.correo = correo;
        }

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string Correo { get => correo; set => correo = value; }
    }
}
