using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Model
{
    public class Cuadrado : FormaGeometrica, ICalculator
    {
        public Cuadrado(decimal ancho)
            : base(ancho)
        {
        }

        public decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public decimal CalcularPerimetro()
        {
            return _lado * 4;
        }

        public override void Sumarizar(Summary summary)
        {
            summary.Sumarice(this);
        }
    }
}
