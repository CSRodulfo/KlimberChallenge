/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada
 * (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using DevelopmentChallenge.Data.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace DevelopmentChallenge.Data.Classes
{
    public class FormaGeometricaProcess
    {
        #region Formas

        public const int Cuadrado = 1;
        public const int TrianguloEquilatero = 2;
        public const int Circulo = 3;
        public const int Trapecio = 4;

        #endregion

        #region Idiomas

        public const int Castellano = 1;
        public const int Ingles = 2;

        #endregion


        public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        {

            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");


            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(Resource.EmptyList);
            }
            else
            {
                sb.Append(Resource.ShapesReport);

                Summary summary = new Summary();

                for (var i = 0; i < formas.Count; i++)
                {
                    summary.Sumarice(formas[i]);
                }

                foreach (var item in summary.GetSummary())
                {
                    sb.Append(ObtenerLinea(item, item.Tipo(), idioma));
                }

                // FOOTER
                sb.Append(Resource.Total);
                sb.Append(summary.GetSummaryTotalNumero() + Resource.Shapes);
                sb.Append(Resource.Perimeter + summary.GetSummaryTotalPerimetro().ToString("#.##") + " ");
                sb.Append(Resource.Area + summary.GetSummaryTotalArea().ToString("#.##"));
            }

            return sb.ToString();
        }

        private static string ObtenerLinea(SummaryCount summary, int tipo, int idioma)
        {
            if (summary.Numero > 0)
            {
                return $"{summary.Numero} {TraducirForma(summary, tipo, idioma)} | {Resource.Area}{summary.Area:#.##} | {Resource.Perimeter}{summary.Perimetro:#.##} <br/>";
            }

            return string.Empty;
        }


        private static string TraducirForma(SummaryCount summary, int tipo, int idioma)
        {
            return summary.GetNombreFigura();
        }
    }
}
