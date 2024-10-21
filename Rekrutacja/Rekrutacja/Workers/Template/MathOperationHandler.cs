using System;
using System.Collections.Generic;
using System.Linq;

namespace Rekrutacja.Workers.Template
{
    public class MathOperationHandler
    {
        private static readonly Dictionary<string,IMathOperation> operations = new Dictionary<string, IMathOperation>()
        {
            { MathOperationSign.Addition, new MathOperationAddition() },
            { MathOperationSign.Multiplication, new MathOperationMultiplication() },
            { MathOperationSign.Subtraction, new MathOperationSubtraction() },
            { MathOperationSign.Division, new MathOperationDivision() }
        };

        public static bool CheckIfOperationExists(string sign) {
            return operations.ContainsKey(sign);
        }

        public static IMathOperation GetMathOperation(string sign)
        {
            if (!CheckIfOperationExists(sign))
            {
                throw new ArgumentException($"Operacja '{sign}' nie jest obsługiwana!");
            }

            return operations[sign];
        }
    }
}
