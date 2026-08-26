using System;
using System.Collections.Generic;
using System.Text;

namespace exemplosCSharp.fixacao
{

        public class CalcularDesconto
    {
        public static decimal Desconto ( decimal valor, decimal percentual )
        {
            decimal valorFinal = valor - (valor * (percentual / 100));
            return valorFinal;
        }
    }
}
