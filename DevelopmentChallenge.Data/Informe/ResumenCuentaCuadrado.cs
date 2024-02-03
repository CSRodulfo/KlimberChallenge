using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Model
{
    public class ResumenCuentaCuadrado : ResumenCuenta
    {
        public static ResumenCuentaCuadrado resumenCuentaCirculoFactory(Informe informe)
        {
            var rtn = new ResumenCuentaCuadrado();
            informe._summary.Add(rtn);
            return rtn;
        }
        public override string GetNombreFigura()
        {
            return this.Numero == 1 ? Resource.Square : Resource.Squares;
        }
    }
}
