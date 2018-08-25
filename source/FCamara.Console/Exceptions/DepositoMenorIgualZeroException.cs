using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCamara.ConsoleApp
{
    public class DepositoMenorIgualZeroException : Exception
    {
        public DepositoMenorIgualZeroException() : base("Valor de depósito não pode ser menor ou igual a zero.")
        {

        }
    }
}
