using System;
using System.Collections.Generic;
using System.Text;

namespace exemplosCSharp.fixacao
{
    public class CalcularFatorial
    {
        public static int fatorial (int numero)
        {
            int resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}
