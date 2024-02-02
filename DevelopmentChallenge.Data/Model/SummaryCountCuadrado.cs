using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Model
{
    public class SummaryCountCuadrado : SummaryCount
    {
        internal void Sumarizar(Cuadrado formaGeometrica)
        {
            Numero++;
            this.Area += formaGeometrica.CalcularArea();
            this.Perimetro += formaGeometrica.CalcularPerimetro();
        }

        public override int Tipo()
        {
            return 1;
        }

        public override string GetNombreFigura()
        {
            if (Numero == 0) return string.Empty;

            return this.Numero == 1 ? Resource.Square : Resource.Squares;
        }
    }
}
