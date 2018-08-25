using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCamara.ConsoleApp
{
    public class LarguraMenorIgualZeroException : Exception
    {
        public LarguraMenorIgualZeroException() : base("Largura não pode ser menor ou igual a zero.")
        {

        }
    }
}
