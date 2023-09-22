using Curso;
using System;
using System.Formats.Asn1;

namespace programa 
{ 
    class Programa
    {
        static void Main(string[] args)
        {
            Retangulo RetanguloEntrada = new Retangulo();
            Console.Write("Digite a Altura do Retangulo: ");
            RetanguloEntrada.Altura = double.Parse(Console.ReadLine());
            Console.Write("Digite a Largura/Base do Retangulo: ");
            RetanguloEntrada.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual operação deseja realizar?");
            Console.WriteLine("1-Area do Retângulo");
            Console.WriteLine("2-Perimetro do Retângulo");
            Console.WriteLine("3-Diagonal do Retângulo");
            string resposta = Console.ReadLine();

            if (resposta == "1")
            {
                Console.WriteLine($"A Área do Retângulo é igual à: {RetanguloEntrada.area().ToString()}");
            }
            else if (resposta == "2")
            {
                Console.WriteLine($"A Área do Retângulo é igual à: {RetanguloEntrada.perimetro().ToString()}");
            }
            else 
            {
                Console.WriteLine($"A Área do Retângulo é igual à: {RetanguloEntrada.diagonal().ToString()}");
            }

        }
    }
}
