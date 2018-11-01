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
            Expression myOtherExpression;

            List<char> myList;

            myExpression = new Expression();
            myExpression.SetSymbol('x');
            myExpression.SetConstant(2018);
            myExpression.SetExpression(new Expression('x'), 2, MathOperator.Power);

            myOtherExpression = new Expression(myExpression, new Expression(3, new Expression('a'), MathOperator.Multiply), MathOperator.Add);
            myOtherExpression.Operate(314, MathOperator.Subtract);

            myList = myOtherExpression.Symbols;
        }
    }
}
