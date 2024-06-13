using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIGURAS_GEOMETRICAS
{
    public class Cubo : Figura
    {
        double lado;

        public Cubo(double lado)
        {
            this.lado = lado;
        }

        public override double CalcularArea()
        {
            return 6 * (lado * lado);
        }

        public override double CalcularVolumen()
        {
            return lado * lado * lado;
        }
    }


  //  internal class Cubo
   // {
    //}
}
