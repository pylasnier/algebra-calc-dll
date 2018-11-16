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

            // myExpression = new Expression();
            myExpression = 'x';
            myExpression = 2018;
            myExpression = new Expression('x') + 2;
            myExpression = 2 + new Expression('x');
            myExpression = (Expression)'x' + 2;

            myOtherExpression = new Expression(myExpression, new Expression(3, new Expression('a'), MathOperator.Multiply), MathOperator.Add);
            myOtherExpression += 314;

            myList = myOtherExpression.Symbols;
        }
    }
}
