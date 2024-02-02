using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Model
{
    public class Informe
    {
        ResumenCuentaCuadrado _summaryCountCuadrdo;
        ResumenCuentaCirculo _summaryCountCirculo;
        ResumenCuentaTrianguloEquilatero _summaryCountTrianguloEquilato;
        List<ResumenCuenta> _summary;

        public Informe()
        {
            _summary = new List<ResumenCuenta>();
            _summaryCountCuadrdo = new ResumenCuentaCuadrado();
            _summaryCountCirculo = new ResumenCuentaCirculo();
            _summaryCountTrianguloEquilato = new ResumenCuentaTrianguloEquilatero();
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

        public List<ResumenCuenta> GetSummary()
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

        public void ObtenerLineas(StringBuilder sb)
        {
            foreach (var summary in _summary)
            {
                if (summary.ValidateNumero())
                {
                    sb.Append($"{summary.Numero} {summary.GetNombreFigura()} | {Resource.Area}{summary.Area:#.##} | {Resource.Perimeter}{summary.Perimetro:#.##} <br/>");
                }
            }
        }
    }
}
