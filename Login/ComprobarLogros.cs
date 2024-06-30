using System.Collections.Generic;

namespace Login
{
    internal class ComprobarLogros
    {
        private ClaseSQL sql = new ClaseSQL();
        private List<int> listaLogroID;
        public bool EsPrimeraVez(int i, string nombreUsuario)
        {
            listaLogroID = sql.VerTodosLogrosUsuario(nombreUsuario);

            if (listaLogroID.Contains(i))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
