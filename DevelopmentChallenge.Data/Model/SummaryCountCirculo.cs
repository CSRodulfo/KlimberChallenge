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

        public override string GetNombreFigura()
        {
            if (Numero == 0) return string.Empty;

            return this.Numero == 1 ? Resource.Circle : Resource.Circles;
        }
    }
}
