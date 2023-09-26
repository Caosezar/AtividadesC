using System;
namespace Course 
{
    class Program 
    { 

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferência: {circ}");
            Console.WriteLine($"Volume: {volume}");
            Console.WriteLine($"Valor de Pi: {Calculadora.Pi}");
        }
    }
}