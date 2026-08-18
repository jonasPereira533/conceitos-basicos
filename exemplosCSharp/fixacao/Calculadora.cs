using System;
using System.Collections.Generic;
using System.Text;

namespace exemplosCSharp.fixacao
{
    internal class Calculadora
    {
        internal static int Somar(int salario, int aumento)
        {
            int salarioFinal = salario + (salario * aumento / 100);
            return salarioFinal;
        }
    }
}
