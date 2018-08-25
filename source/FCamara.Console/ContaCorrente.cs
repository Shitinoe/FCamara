using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCamara.ConsoleApp
{
    public class ContaCorrente
    {
        public string NumeroConta { get; private set; }
        public string NomeCorrentista { get; private set; }
        public decimal Saldo { get; private set; }

        public ContaCorrente(string numeroConta, string nomeCorrentista, decimal saldo = 0)
        {
            NumeroConta = numeroConta;
            NomeCorrentista = nomeCorrentista;
            Saldo = saldo;
        }

        public void AlterarNome(string novoNome)
        {
            NomeCorrentista = novoNome;
        }

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
                throw new DepositoMenorIgualZeroException();

            Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            if (valor > Saldo)
                throw new SaqueMaiorQueSaldoException();
            if (valor <= 0)
                throw new SaqueMenorIgualZeroException();

            Saldo -= valor;
        }
    }
}
