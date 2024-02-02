using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Model
{
    public class SummaryCountTrianguloEquilatero : SummaryCount
    {
        internal void Sumarizar(TrianguloEquilatero formaGeometrica)
        {
            Numero++;
            this.Area += formaGeometrica.CalcularArea();
            this.Perimetro += formaGeometrica.CalcularPerimetro();
        }

        public override int Tipo()
        {
            return 2;
        }

        public override string GetNombreFigura()
        {
            if (Numero == 0) return string.Empty;

            return this.Numero == 1 ? Resource.Triangle : Resource.Triangles;
        }
    }
}
