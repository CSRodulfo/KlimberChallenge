using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Model;
using NUnit.Framework;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTestsItalian
    {
        [SetUp]
        public void SetUp()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("it-IT");
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("it-IT");
        }

        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>",
                FormaGeometricaProcess.Imprimir(new List<FormaGeometrica>()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var Piazze = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = FormaGeometricaProcess.Imprimir(Piazze);

            Assert.AreEqual("<h1>Rapporto moduli</h1>1 Piazza | La zona 25 | Perimetro 20 <br/>TOTALE:<br/>1 forme Perimetro 20 La zona 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var Piazze = new List<FormaGeometrica> { new Trapecio(5, 5) };

            var resumen = FormaGeometricaProcess.Imprimir(Piazze);

            Assert.AreEqual("<h1>Rapporto moduli</h1>1 Trapezio | La zona 25 | Perimetro 20 <br/>TOTALE:<br/>1 forme Perimetro 20 La zona 25", resumen);
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
                "<h1>Rapporto moduli</h1>2 Piazze | La zona 29 | Perimetro 28 <br/>2 Cerchio | La zona 13,01 | Perimetro 18,06 <br/>3 triangoli | La zona 49,64 | Perimetro 51,6 <br/>TOTALE:<br/>7 forme Perimetro 97,66 La zona 91,65",
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
                "<h1>Rapporto moduli</h1>2 Piazze | La zona 29 | Perimetro 28 <br/>2 Cerchio | La zona 13,01 | Perimetro 18,06 <br/>3 triangoli | La zona 49,64 | Perimetro 51,6 <br/>2 Trapezio | La zona 50 | Perimetro 40 <br/>TOTALE:<br/>9 forme Perimetro 137,66 La zona 141,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasPiazze()
        {
            var Piazze = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = FormaGeometricaProcess.Imprimir(Piazze);

            Assert.AreEqual("<h1>Rapporto moduli</h1>3 Piazze | La zona 35 | Perimetro 36 <br/>TOTALE:<br/>3 forme Perimetro 36 La zona 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTrapecio()
        {
            var Piazze = new List<FormaGeometrica>
            {
                new Trapecio(5,5),
                new Trapecio(2,2),
                new Trapecio(1,1)
            };

            var resumen = FormaGeometricaProcess.Imprimir(Piazze);

            Assert.AreEqual("<h1>Rapporto moduli</h1>3 Trapezio | La zona 30 | Perimetro 32 <br/>TOTALE:<br/>3 forme Perimetro 32 La zona 30", resumen);
        }
    }
}
