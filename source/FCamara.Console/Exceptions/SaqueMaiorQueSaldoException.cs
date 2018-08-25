using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCamara.ConsoleApp
{
    public class SaqueMaiorQueSaldoException : Exception
    {
        public SaqueMaiorQueSaldoException() : base("Valor de saque não pode ser maior que o saldo.")
        {

        }
    }
}
