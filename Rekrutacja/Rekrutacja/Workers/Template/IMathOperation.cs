using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekrutacja.Workers.Template
{
    public interface IMathOperation
    {
        double A { get; set; }

        double B { get; set; }

        double Execute();
        
    }
}
