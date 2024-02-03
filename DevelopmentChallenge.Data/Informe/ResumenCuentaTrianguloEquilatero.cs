using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Model
{
    public class ResumenCuentaTrianguloEquilatero : ResumenCuenta
    {
        public static ResumenCuentaTrianguloEquilatero resumenCuentaCirculoFactory(Informe informe)
        {
            var rtn = new ResumenCuentaTrianguloEquilatero();
            informe._summary.Add(rtn);
            return rtn;
        }
        public override string GetNombreFigura()
        {
            return this.Numero == 1 ? Resource.Triangle : Resource.Triangles;
        }
    }
}
