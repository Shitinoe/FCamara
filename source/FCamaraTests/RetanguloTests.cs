using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using FCamara.ConsoleApp;

namespace FCamaraTests
{
    [TestFixture]
    public class RetanguloTests
    {
        [Test]
        public void Retangulo_ComprimentoIgualZero_ThrowComprimentoMenorIgualZeroException()
        {
            Assert.Throws<ComprimentoMenorIgualZeroException>(() => new Retangulo(0, 10));
        }

        [Test]
        public void Retangulo_ComprimentoMenorQueZero_ThrowComprimentoMenorIgualZeroException()
        {
            Assert.Throws<ComprimentoMenorIgualZeroException>(() => new Retangulo(-1, 10));
        }

        public void Retangulo_LarguraIgualZero_ThrowComprimentoIgualZeroException()
        {
            Assert.Throws<LarguraMenorIgualZeroException>(() => new Retangulo(10, 0));
        }

        [Test]
        public void Retangulo_LarguraMenorQueZero_ThrowComprimentoMenorZeroException()
        {
            Assert.Throws<LarguraMenorIgualZeroException>(() => new Retangulo(10, 0));
        }


        [Test]
        public void CalcularArea_QuandoChamado_RetornarValorArea()
        {
            var retangulo = new Retangulo(10,10);

            var resultado = retangulo.CalcularArea();

            Assert.That(resultado, Is.EqualTo(100));
        }

        [Test]
        public void CalcularPerimetro_QuandoChamado_RetornarValorPerimetro()
        {
            var retangulo = new Retangulo(10, 10);

            var resultado = retangulo.CalcularPerimetro();

            Assert.That(resultado, Is.EqualTo(40));
        }
    }
}
