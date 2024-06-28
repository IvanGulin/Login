using System;
using System.Collections.Generic;

namespace Login
{
    internal class ComprobarLogros
    {
        private ClaseSQL sql = new ClaseSQL();
        public bool EsPrimeraVez(int i, List<int> listaLogroID, string nombreUsuario)
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
