namespace Login
{
    internal class Usuarios
    {
        private string nombreUsuario;
        private string password;
        private string correo;
        private string descripcion;
        private string apellidos;
        private string nombre;
        private byte imagen;

        public Usuarios(string nombreUsuario, string password, string correo)
        {
            this.nombreUsuario = nombreUsuario;
            this.password = password;
            this.correo = correo;
        }

        public Usuarios(string nombre, string apellidos, string descripcion, byte imagen)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.descripcion = descripcion;
            this.imagen = imagen;
        }

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public byte Imagen { get => imagen; set => imagen = value; }
    }
}
