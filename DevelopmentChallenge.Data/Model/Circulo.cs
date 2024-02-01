using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Model
{
    public class Circulo : FormaGeometrica, ICalculator
    {
        public Circulo(decimal lado) : base(lado)
        {
        }

        public decimal CalcularArea()
        {
             return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _lado;
        }
    }
}
