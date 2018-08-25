using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCamara.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int exercicio = 0;
            Console.WriteLine("Digite qual exercicio deseja ver: ");
            exercicio = int.Parse(Console.ReadLine());
            switch (exercicio)
            {
                case 1:
                    Exercicio1();
                    break;
                case 2:
                    Exercicio2();
                    break;
                case 3:
                    Exercicio3();
                    break;
                case 4:
                    Exercicio4();
                    break;
                case 6:
                    Exercicio6();
                    break;
            }
        }

        #region Exercicios 1, 2, 3, 4, 6
        private static void Exercicio6()
        {
            double perimetroLocal, areaLocal, largura, comprimento, qtPisos, qtRodape;
            Console.WriteLine("Digite o comprimento do local:");
            comprimento = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a largura do local:");
            largura = double.Parse(Console.ReadLine());
            var retangulo = new Retangulo(comprimento, largura);
            areaLocal = retangulo.CalcularArea();
            perimetroLocal = retangulo.CalcularPerimetro();
            qtPisos = areaLocal / 0.16;
            qtRodape = perimetroLocal / 0.30;
            Console.WriteLine("Serão necessários " + qtPisos + " pisos de 0,16m²");
            Console.WriteLine("Serão necessários " + qtRodape + " rodapes de 0,30m²");
            Console.ReadKey();
        }

        private static void Exercicio4()
        {
            double latas = 1;
            Console.WriteLine("Digite quantos metros quadrados serao pintados");
            latas = Math.Ceiling(float.Parse(Console.ReadLine()) / 54);
            Console.WriteLine(latas + " lata(s). Preço total: R$" + latas * 80);
            Console.ReadKey();
        }

        private static void Exercicio3()
        {
            int horasTrabalhadas = 0;
            double salario = 0;
            Console.WriteLine("Digite as horas trabalhadas");
            horasTrabalhadas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do salario minimo");
            salario = double.Parse(Console.ReadLine());
            salario = horasTrabalhadas * (salario * 0.1);
            salario = salario - (salario * 0.03);
            Console.WriteLine("O salario a receber e de : " + salario);
            Console.ReadKey();
        }

        private static void Exercicio2()
        {
            int primeiroNumero = 0, segundoNumero = 0;
            string resposta = "";
            Console.WriteLine("Digite o valor inicial e final : ");
            resposta = Console.ReadLine();
            primeiroNumero = Convert.ToInt32(resposta.Split(' ')[0]);
            segundoNumero = Convert.ToInt32(resposta.Split(' ')[1]);
            if (primeiroNumero <= 0 || segundoNumero <= primeiroNumero)
            {
                Console.WriteLine("Números inválidos, tente novamente");
            }
            else
            {
                var resultado = gerarPrimosDoIntervalo(primeiroNumero, segundoNumero);
                foreach (var item in resultado)
                {
                    Console.Write(item.ToString() + " ");
                }
            }
            Console.ReadKey();
        }

        private static void Exercicio1()
        {
            int anosTrabalhados = 2005, salarioInicial = 1000;
            double aumento = 0.015;
            decimal salario = 0;
            while (anosTrabalhados != 2018)
            {
                salario = salarioInicial + salarioInicial * (decimal)aumento;
                aumento = aumento * 2;
                anosTrabalhados++;
            }
            Console.WriteLine("O salário atual é : " + salario);
            Console.ReadKey();
        }
        #endregion

        #region Metodo gerarPrimosDoIntervalo do exercicio 2
        private static List<int> gerarPrimosDoIntervalo(int inicial, int final)
        {
            var numerosPrimos = new List<int>();
            for (int i = inicial; i != final; i++)
            {
                int divisoesFeitas = 0;
                for (int dividendo = i - 1; dividendo > 0; dividendo--)
                {
                    if (i % dividendo == 0)
                    {
                        divisoesFeitas++;
                    }
                }
                if (divisoesFeitas == 1)
                {
                    numerosPrimos.Add(i);
                }
            }
            return numerosPrimos;
        }
        #endregion
    }
}
