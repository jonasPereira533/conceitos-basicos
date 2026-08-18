using System;
using System.Collections.Generic;
using System.Text;

namespace exemplosCSharp.fixacao
{
    internal class CalcularDesconto
    {
        internal static double Desconto ( double valor, double percentual )
        {
            double valorFinal = valor - (valor * (percentual / 100));
            return valorFinal;
        }


    }
}
