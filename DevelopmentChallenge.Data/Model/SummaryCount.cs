using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Model
{
    public abstract class SummaryCount
    {

        public int Numero { get; set; }
        public decimal Area { get; set; }
        public decimal Perimetro { get; set; }

        public abstract int Tipo();

    }
}
