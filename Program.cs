// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.ConstrainedExecution;
using Exercicio_heranca;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu meio de transporte: \n Carro - 1 \n Ônibus: - 2 ");
            int opcao = int.Parse(Console.ReadLine());

            double gasolina = 0;
            double consumo = 0;
            double tarifa = 0;
            int passagem = 0;

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Entre como o valor da gasolina: ");
                    gasolina = double.Parse(Console.ReadLine());
                    Console.WriteLine("Entre como o valor da gasolina: ");
                    consumo = double.Parse(Console.ReadLine());
                    break;

                case 2:
                    Console.WriteLine("Entre como o valor da tarifa do ônibus: ");
                    tarifa = double.Parse(Console.ReadLine());
                    Console.WriteLine("Entre como o valor da tarifa do ônibus: ");
                    passagem = int.Parse(Console.ReadLine());
                    break;
            }
            Carro carro = new Carro(gasolina, consumo);
            Onibus onibus = new Onibus(tarifa, passagem);
            
            
        }
    }
}
