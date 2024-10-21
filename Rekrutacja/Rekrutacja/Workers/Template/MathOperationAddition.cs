using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekrutacja.Workers.Template
{
    public class MathOperationAddition : IMathOperation
    {
        public double A {  get; set; }

        public double B { get; set; }

        public double Execute() {
            return A + B;
        }

    }
}
