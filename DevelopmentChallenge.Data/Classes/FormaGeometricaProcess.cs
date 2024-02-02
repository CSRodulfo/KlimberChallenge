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

        public static string Imprimir(List<FormaGeometrica> formas)
        {
            var sb = new StringBuilder();

            if (formas.Any())

            {
                sb.Append(Resource.ShapesReport);
                Informe summary = new Informe();

                foreach (var forma in formas)
                {
                    summary.Sumarice(forma);
                }

                summary.ObtenerLineas(sb);

                // FOOTER
                sb.Append(Resource.Total);
                sb.Append(summary.GetSummaryTotalNumero() + Resource.Shapes);
                sb.Append(Resource.Perimeter + summary.GetSummaryTotalPerimetro().ToString("#.##") + " ");
                sb.Append(Resource.Area + summary.GetSummaryTotalArea().ToString("#.##"));
            }
            else
            {
                sb.Append(Resource.EmptyList);
            }

            return sb.ToString();
        }

        private static string ObtenerLinea(ResumenCuenta summary)
        {
            if (summary.ValidateNumero())
            {
                return $"{summary.Numero} {summary.GetNombreFigura()} | {Resource.Area}{summary.Area:#.##} | {Resource.Perimeter}{summary.Perimetro:#.##} <br/>";
            }

            return string.Empty;
        }
    }
}
