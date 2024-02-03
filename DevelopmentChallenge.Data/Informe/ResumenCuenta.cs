using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Model
{
    public abstract class ResumenCuenta
    {
        public int Numero { get; set; }
        public decimal Area { get; set; }
        public decimal Perimetro { get; set; }

        public void Sumarizar(ICalculator formaGeometrica)
        {
            Numero++;
            this.Area += formaGeometrica.CalcularArea();
            this.Perimetro += formaGeometrica.CalcularPerimetro();
        }

        public bool ValidateNumero() { return Numero > 0; }

        public abstract string GetNombreFigura();



    }
}
