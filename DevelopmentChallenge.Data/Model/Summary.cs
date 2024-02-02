using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Model
{
    public class Summary
    {
        SummaryCountCuadrado _summaryCountCuadrdo;
        SummaryCountCirculo _summaryCountCirculo;
        SummaryCountTrianguloEquilatero _summaryCountTrianguloEquilato;
        List<SummaryCount> _summary  ;

        public Summary()
        {
            _summary = new List<SummaryCount>();
            _summaryCountCuadrdo = new SummaryCountCuadrado();
            _summaryCountCirculo = new SummaryCountCirculo();
            _summaryCountTrianguloEquilato = new SummaryCountTrianguloEquilatero();
            _summary.Add(_summaryCountCuadrdo);
            _summary.Add(_summaryCountCirculo);
            _summary.Add(_summaryCountTrianguloEquilato);
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
            return _summary;
        }
        public decimal GetSummaryTotalArea()
        {
            return _summary.Sum(x => x.Area);
        }
        public decimal GetSummaryTotalNumero()
        {
            return _summary.Sum(x => x.Numero);
        }
        public decimal GetSummaryTotalPerimetro() 
        {
            return _summary.Sum(x => x.Perimetro);
        }
    }
}
