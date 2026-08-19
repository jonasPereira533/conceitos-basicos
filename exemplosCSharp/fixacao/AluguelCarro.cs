using System;
using System.Collections.Generic;
using System.Text;

namespace exemplosCSharp.fixacao
{
    internal class AluguelCarro
    {
        internal static double CalcularAluguel(int dias, double km)
        {
            double TotalDias = dias * 95.00;
            double TotalKm = km * 0.35;
            return TotalDias + TotalKm;
        }
    }

}
