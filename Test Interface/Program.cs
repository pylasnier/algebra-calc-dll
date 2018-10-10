using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Algebra;

namespace Test_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression myExpression;

            myExpression = new Expression();
            myExpression.SetSymbol('x');
            myExpression.SetConstant(2018);
            myExpression.SetExpression(new Expression('x'), 2, MathOperator.Power);
        }
    }
}
