using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIGURAS_GEOMETRICAS
{
    public class Cuadrado : Figura
    {
        double lado;

        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public override double CalcularArea()
        {
            return lado * lado;
        }

        public override double CalcularVolumen()
        {
            return 0; // Los cuadrados no tienen volumen
        }
    }
   // internal class Cuadrado
   // {
    //}
}
