using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Model;
using NUnit.Framework;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [SetUp]
        public void SetUp()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("es-AR");
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("es-AR");
        }

        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometricaProcess.Imprimir(new List<FormaGeometrica>()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = FormaGeometricaProcess.Imprimir(cuadrados);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestUnCuadrado()
        {
            var cuadrados = new Cuadrado(5);

            Assert.AreEqual( 25, cuadrados.CalcularArea());
            Assert.AreEqual( 20, cuadrados.CalcularPerimetro());
        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var cuadrados = new List<FormaGeometrica> { new Trapecio(5, 5) };

            var resumen = FormaGeometricaProcess.Imprimir(cuadrados);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }


        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado (5),
                new Circulo (3),
                new TrianguloEquilatero (4),
                new Cuadrado (2),
                new TrianguloEquilatero (9),
                new Circulo (2.75m),
                new TrianguloEquilatero (4.2m)
            };

            var resumen = FormaGeometricaProcess.Imprimir(formas);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposYTrapecio()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado (5),
                new Circulo (3),
                new TrianguloEquilatero (4),
                new Cuadrado (2),
                new TrianguloEquilatero (9),
                new Circulo (2.75m),
                new TrianguloEquilatero (4.2m),
                new Trapecio(5,5),
                new Trapecio(5,5)
            };

            var resumen = FormaGeometricaProcess.Imprimir(formas);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>2 Trapecios | Area 50 | Perimetro 40 <br/>TOTAL:<br/>9 formas Perimetro 137,66 Area 141,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = FormaGeometricaProcess.Imprimir(cuadrados);

            Assert.AreEqual("<h1>Reporte de Formas</h1>3 Cuadrados | Area 35 | Perimetro 36 <br/>TOTAL:<br/>3 formas Perimetro 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTrapecios()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Trapecio(5,5),
                new Trapecio(2,2),
                new Trapecio(1,1)
            };

            var resumen = FormaGeometricaProcess.Imprimir(cuadrados);

            Assert.AreEqual("<h1>Reporte de Formas</h1>3 Trapecios | Area 30 | Perimetro 32 <br/>TOTAL:<br/>3 formas Perimetro 32 Area 30", resumen);
        }
    }
}
