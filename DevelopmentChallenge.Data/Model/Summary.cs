using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Model
{
    public class Summary
    {
        public int TotalNumber { get; set; }
        public decimal TotalArea { get; set; }
        public decimal TotalPerimetro { get; set; }


        SummaryCountCuadrado _summaryCountCuadrdo;
        SummaryCountCirculo _summaryCountCirculo;
        SummaryCountTrianguloEquilatero _summaryCountTrianguloEquilato;

        public Summary()
        {
            _summaryCountCuadrdo = new SummaryCountCuadrado();
            _summaryCountCirculo = new SummaryCountCirculo();
            _summaryCountTrianguloEquilato = new SummaryCountTrianguloEquilatero();
        }

        public void Sumarice(FormaGeometrica formaGeometrica)
        {
            formaGeometrica.Sumarizar(this);
        }

        public void Sumarice(Cuadrado formaGeometrica)
        {
            _summaryCountCuadrdo.Sumarizar(formaGeometrica);

        }

        public void Sumarice(Circulo formaGeometrica)
        {
            _summaryCountCirculo.Sumarizar(formaGeometrica);

        }

        public void Sumarice(TrianguloEquilatero formaGeometrica)
        {
            _summaryCountTrianguloEquilato.Sumarizar(formaGeometrica);
        }

        public List<SummaryCount> GetSummary()
        {
            List<SummaryCount> summary = new List<SummaryCount>();
            summary.Add(_summaryCountCuadrdo);
            summary.Add(_summaryCountCirculo);
            summary.Add(_summaryCountTrianguloEquilato);

            return summary;
        }
    }
}
