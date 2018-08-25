using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCamara.ConsoleApp
{
    public class ComprimentoMenorIgualZeroException : Exception
    {
        public ComprimentoMenorIgualZeroException() : base("Comprimento não pode ser menor ou igual a zero.")
        {

        }
    }
}
