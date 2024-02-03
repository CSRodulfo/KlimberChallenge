using System.Collections.Generic;
using System.Text;

namespace DevelopmentChallenge.Data.Model
{
    public interface ISumarizarFormaGeometrica
    {
        void Sumarice(Circulo formaGeometrica);
        void Sumarice(Cuadrado formaGeometrica);
        void Sumarice(FormaGeometrica formaGeometrica);
        void Sumarice(TrianguloEquilatero formaGeometrica);
        void Sumarice(Trapecio formaGeometrica);

    }
}