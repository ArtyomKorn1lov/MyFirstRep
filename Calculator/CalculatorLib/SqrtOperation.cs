using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class SqrtOperation : IOperation
    {
        public string OperatorCode => "√";
        public int Apply(int operand1, int operand2)
        {
            return (int) Math.Pow(operand2, (double) 1 / operand1);
        }
    }
}
