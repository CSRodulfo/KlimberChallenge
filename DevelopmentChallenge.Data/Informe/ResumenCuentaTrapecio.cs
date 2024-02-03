using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Model
{
    public class ResumenCuentaTrapecio : ResumenCuenta
    {
        public static ResumenCuentaTrapecio resumenCuentaCirculoFactory(Informe informe)
        {
            var rtn = new ResumenCuentaTrapecio();
            informe._summary.Add(rtn);
            return rtn;
        }
        public override string GetNombreFigura()
        {
            return this.Numero == 1 ? Resource.Trapeze : Resource.Trapezes;
        }
    }
}
