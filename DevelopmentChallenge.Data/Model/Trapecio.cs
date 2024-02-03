using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Model
{
    public class Trapecio : FormaGeometrica, ICalculator
    {
        protected decimal _altura;

        public Trapecio(decimal lado, decimal altura) 
            : base(lado)
        {
            _altura = altura;
        }

        public decimal CalcularArea()
        {
            // 0.5 * (baseMayor + baseMenor) * altura;
            return ((_lado + _lado)/2) * _altura;
        }

        public decimal CalcularPerimetro()
        {
            return _lado + _lado + (2 * _altura);
        }

        public override void Sumarizar(ISumarizarFormaGeometrica summary)
        {
            summary.Sumarice(this);
        }
    }
}
