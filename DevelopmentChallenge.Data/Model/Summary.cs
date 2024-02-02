using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Model
{
    public class Summary
    {

        //public int Numero { get; set; }
        //public decimal Area { get; set; }
        //public string Perimetro { get; set; }

        public int numeroCuadrados = 0;
        public int numeroCirculos = 0;
        public int numeroTriangulos = 0;

        public decimal areaCuadrados = 0m;
        public decimal areaCirculos = 0m;
        public decimal areaTriangulos = 0m;

        public decimal perimetroCuadrados = 0m;
        public decimal perimetroCirculos = 0m;
        public decimal perimetroTriangulos = 0m;

        public Summary() { }

        public void Sumarice(FormaGeometrica formaGeometrica)
        {
            formaGeometrica.Sumarizar(this);
        }

        public void Sumarice(Cuadrado formaGeometrica)
        {
            numeroCuadrados++;
            areaCuadrados += formaGeometrica.CalcularArea();
            perimetroCuadrados += formaGeometrica.CalcularPerimetro();
        }

        public void Sumarice(Circulo formaGeometrica)
        {
            numeroCirculos++;
            areaCirculos += formaGeometrica.CalcularArea();
            perimetroCirculos += formaGeometrica.CalcularPerimetro();
        }

        public void Sumarice(TrianguloEquilatero formaGeometrica)
        {
            numeroTriangulos++;
            areaTriangulos += formaGeometrica.CalcularArea();
            perimetroTriangulos += formaGeometrica.CalcularPerimetro();

        }
    }
}
