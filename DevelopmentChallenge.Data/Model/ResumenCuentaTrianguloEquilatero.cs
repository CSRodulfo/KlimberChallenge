﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Model
{
    public class ResumenCuentaTrianguloEquilatero : ResumenCuenta
    {
        public override string GetNombreFigura()
        {
            return this.Numero == 1 ? Resource.Triangle : Resource.Triangles;
        }
    }
}