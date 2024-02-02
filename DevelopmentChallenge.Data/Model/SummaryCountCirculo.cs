using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Model
{
    public class SummaryCountCirculo: SummaryCount
    {
        internal void Sumarizar(Circulo formaGeometrica)
        {
            Numero++;
            this.Area += formaGeometrica.CalcularArea();
            this.Perimetro += formaGeometrica.CalcularPerimetro();
        }

        public override int Tipo()
        {
            return 3;
        }
    }
}
