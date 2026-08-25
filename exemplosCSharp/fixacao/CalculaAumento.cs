using System;
using System.Collections.Generic;
using System.Text;

namespace exemplosCSharp.fixacao
{
    public class CalculaAumento
    {
        public decimal AumentarSalario (decimal salario, float percentual)
        {
            return salario * (decimal)percentual / 100; 
        }
    }
}
