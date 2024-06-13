using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIGURAS_GEOMETRICAS
{
    public class Esfera : Figura
    {
        double radio;

        public Esfera(double radio)
        {
            this.radio = radio;
        }

        public override double CalcularArea()
        {
            return 4 * Math.PI * (radio * radio);
        }

        public override double CalcularVolumen()
        {
            return (4 / 3) * Math.PI * (radio * radio * radio);
        }
    }
    // internal class Esfera
    //{
    // }
}
