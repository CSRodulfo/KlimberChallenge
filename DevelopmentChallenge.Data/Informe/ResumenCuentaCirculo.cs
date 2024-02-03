using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Model
{
    public class ResumenCuentaCirculo : ResumenCuenta
    {
        public static ResumenCuentaCirculo resumenCuentaCirculoFactory(Informe informe)
        {
            var rtn = new ResumenCuentaCirculo();
            informe._summary.Add(rtn);
            return rtn;
        }

        public override string GetNombreFigura()
        {
            return this.Numero == 1 ? Resource.Circle : Resource.Circles;
        }
    }
}
