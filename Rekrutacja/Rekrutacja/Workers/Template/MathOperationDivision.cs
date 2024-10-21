using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekrutacja.Workers.Template
{
    public class MathOperationDivision : IMathOperation
    {
        public double A { get; set; }

        public double B { get; set; }

        public double Execute() {
            if (B == 0)
            {
                throw new DivideByZeroException("Nie można dzielić przez 0!");
            }

            return A / B;
        }

    }
}
