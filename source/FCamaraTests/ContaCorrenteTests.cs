using System;
using FCamara.ConsoleApp;
using NUnit.Framework;

namespace FCamaraTests
{
    [TestFixture]
    public class ContaCorrenteTests
    {
        [Test]
        public void Depositar_ValorMaiorQueZero_AtualizarSaldo()
        {
            decimal saldo = 10m;
            var contaCorrente = new ContaCorrente("123", "Felipe", saldo);

            contaCorrente.Depositar(20);

            Assert.That(contaCorrente.Saldo, Is.EqualTo(30));
        }

        [Test]
        public void Depositar_ValorMenorQueZero_ThrowDepositoMenorIgualZeroException()
        {
            var contaCorrente = new ContaCorrente("123", "Felipe");

            Assert.Throws<DepositoMenorIgualZeroException>(() => contaCorrente.Depositar(-1));
        }

        [Test]
        public void Sacar_ValorMaiorQueSaldo_ThrowSaqueMaiorQueSaldoException()
        {
            var contaCorrente = new ContaCorrente("123", "Felipe", 1000);

            Assert.Throws<SaqueMaiorQueSaldoException>(() => contaCorrente.Sacar(1001));
        }

        [Test]
        public void Sacar_ValorMenorIgualZero_ThrowMenorIgualZeroException()
        {
            var contaCorrente = new ContaCorrente("123", "Felipe", 1000);

            Assert.Throws<SaqueMenorIgualZeroException>(() => contaCorrente.Sacar(0));
        }

        [Test]
        public void Sacar_ValorMenorQueSaldo_AtualizarSaldo()
        {
            var contaCorrente = new ContaCorrente("123", "Felipe", 1000);

            contaCorrente.Sacar(1000);

            Assert.That(contaCorrente.Saldo, Is.EqualTo(0));
        }
    }
}
