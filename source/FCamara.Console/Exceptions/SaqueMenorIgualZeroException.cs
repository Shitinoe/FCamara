using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCamara.ConsoleApp
{
    public class SaqueMenorIgualZeroException : Exception
    {
        public SaqueMenorIgualZeroException() : base("Valor de saque não pode ser menor ou igual a zero.")
        {

        }
    }
}
