using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIGURAS_GEOMETRICAS
{
    public abstract class Figura
    {
        public abstract double CalcularArea();
        public abstract double CalcularVolumen();
    }
    public class Triangulo : Figura
    {
        double baseTriangulo;
        double altura;

        public Triangulo(double baseTriangulo, double altura)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
        }

        public override double CalcularArea()
        {
            return (baseTriangulo * altura) / 2;
        }

        public override double CalcularVolumen()
        {
            return 0; // Los triángulos no tienen volumen
        }
    }
 //   internal class Triangulo
 //   {

 
 //   }
}
