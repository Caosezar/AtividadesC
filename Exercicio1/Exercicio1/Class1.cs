using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
namespace Curso
{
    public class Retangulo

    {
        public double Largura;
        public double Altura;
        public double area()
        {
            double areaCalc = Altura * Largura;
            return areaCalc; 
    }
        public double perimetro()
        {
            double perimetroCalc = 2*(Altura + Largura);
            return perimetroCalc;
        }
        public double diagonal()
        {
            double diagonalCalc = Math.Sqrt(Largura*Altura + Altura*Altura);
            return diagonalCalc;
        }
    }
}
