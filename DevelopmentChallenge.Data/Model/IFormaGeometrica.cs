using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Model
{
    public interface IFormaGeometrica
    {      
        decimal CalcularArea();

        decimal CalcularPerimetro();

        //public virtual decimal CalcularArea()
        //{
        //    switch (Tipo)
        //    {
        //        case Cuadrado: return _lado * _lado;
        //        case Circulo: return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        //        case TrianguloEquilatero: return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        //        default:
        //            throw new ArgumentOutOfRangeException(@"Forma desconocida");
        //    }
        //}

        //public virtual decimal CalcularPerimetro()
        //{
        //    switch (Tipo)
        //    {
        //        case Cuadrado: return _lado * 4;
        //        case Circulo: return (decimal)Math.PI * _lado;
        //        case TrianguloEquilatero: return _lado * 3;
        //        default:
        //            throw new ArgumentOutOfRangeException(@"Forma desconocida");
        //    }
        //}

    }
}
