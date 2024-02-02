using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Model
{
    public abstract class FormaGeometrica 
    {
        protected decimal _lado;
        public FormaGeometrica(decimal lado)
        {
            _lado = lado;
        }

        public abstract void Sumarizar(Informe summary);
     }
}
