using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCamara.ConsoleApp
{
    public class Retangulo
    {
        public double Comprimento { get; private set; }
        public double Largura { get; private set; }

        public Retangulo(double comprimento, double largura)
        {
            if (comprimento <= 0)
                throw new ComprimentoMenorIgualZeroException();

            if (largura <= 0)
                throw new LarguraMenorIgualZeroException();

            Comprimento = comprimento;
            Largura = largura;
        }

        public void AlterarLados(double novoComprimento, double novaLargura)
        {
            Comprimento = novoComprimento;
            Largura = novaLargura;
        }

        public double CalcularArea() => Comprimento * Largura;

        public double CalcularPerimetro() => (Comprimento + Largura) * 2;
    }
}
