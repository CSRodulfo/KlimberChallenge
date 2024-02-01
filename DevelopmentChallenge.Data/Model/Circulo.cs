using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Model
{
    public class Circulo : FormaGeometrica, IFormaGeometrica
    {
        public Circulo(decimal lado) : base(lado)
        {
        }

        public decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _lado;
        }
    }
}
