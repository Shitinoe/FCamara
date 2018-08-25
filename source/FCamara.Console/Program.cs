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
            int alterarExercicio = 0;
            switch (alterarExercicio)
            {
                case 0:
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
                    break;
                case 1:
                    int primeiroNumero = 0, segundoNumero = 0;
                    string resposta = "";
                    Console.WriteLine("Digite o valor inicial e final : ");
                    resposta = Console.ReadLine();
                    primeiroNumero = Convert.ToInt32(resposta.Split(' ')[0]);
                    segundoNumero = Convert.ToInt32(resposta.Split(' ')[1]);
                    var resultado = gerarPrimosDoIntervalo(primeiroNumero, segundoNumero);
                    foreach (var item in resultado)
                    {
                        Console.Write(item.ToString() + " ");
                    }
                    Console.ReadKey();
                    break;
                case 2:
                    int horasTrabalhadas = 0;
                    decimal salario = 0;
                    Console.WriteLine("Digite as horas trabalhadas");
                    horasTrabalhadas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor do salario minimo");
                    salario = decimal.Parse(Console.ReadLine());
                    salario = horasTrabalhadas * (salario * (decimal)0.1);
                    salario = salario - (salario * (decimal)0.03);
                    Console.WriteLine("O salario a receber e de : " + salario);
                    Console.ReadKey();
                    break;
                case 3:
                    CalcularPrecoLatas();
                    break;

            }
            /////////////////
            ///////EX1//////
            ////////////////
            //int anosTrabalhados = 2005, salarioInicial = 1000;
            //double aumento = 0.015;
            //decimal salario = 0;
            //while (anosTrabalhados != 2018)
            //{
            //    salario = salarioInicial + salarioInicial * (decimal)aumento;
            //    aumento = aumento * 2;
            //    anosTrabalhados++;
            //}
            //Console.WriteLine("O salário atual é : " + salario);
            //Console.ReadKey();

            /////////////////
            ///////EX2//////
            ////////////////
            //int primeiroNumero = 0, segundoNumero = 0;
            //string resposta = "";
            //Console.WriteLine("Digite o valor inicial e final : ");
            //resposta = Console.ReadLine();
            //primeiroNumero = Convert.ToInt32(resposta.Split(' ')[0]);
            //segundoNumero = Convert.ToInt32(resposta.Split(' ')[1]);
            //var resultado = gerarPrimosDoIntervalo(primeiroNumero, segundoNumero);
            //foreach (var item in resultado)
            //{
            //    Console.Write(item.ToString() + " ");
            //}
            //Console.ReadKey();

            /////////////////
            ///////EX3//////
            ////////////////
            //int horasTrabalhadas = 0;
            //double salario = 0;
            //Console.WriteLine("Digite as horas trabalhadas");
            //horasTrabalhadas = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor do salario minimo");
            //salario = double.Parse(Console.ReadLine());
            //salario = horasTrabalhadas * (salario * 0.1);
            //salario = salario - (salario * 0.03);
            //Console.WriteLine("O salario a receber e de : " + salario);
            //Console.ReadKey();

            /////////////////
            ///////EX4//////
            ////////////////
            //CalcularPrecoLatas();

            /////////////////
            ///////EX6//////
            ////////////////

        }

        private static void CalcularPrecoLatas()
        {
            double latas = 1;
            Console.WriteLine("Digite quantos metros quadrados serao pintados");
            latas = Math.Ceiling(float.Parse(Console.ReadLine()) / 54);
            Console.WriteLine("Serao necessarias " + latas + " latas. O preco total sera R$" + latas * 80);
            Console.ReadKey();
        }

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
    }
}
