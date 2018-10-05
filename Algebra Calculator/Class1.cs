using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra
{
    public enum MathOperator
    {
        Multiply = 0,
        Divide = 1,
        Add = 2,
        Subtract = 3,
        Power = 4
    };

    public enum MathOperand
    {
        Expression = 0,
        Constant = 1,
        Symbol = 2
    };

    public class Solution
    {
        private Expression expression;

        public Solution(dynamic value)
        {
            expression = new Expression(value);
        }

        public dynamic Value
        {
            get
            {
                return 0.0f;
            }
            set
            {
                if (typeof(string) == value.GetType())
                {
                    parse(value);
                }
                else
                {
                    expression.Value = value;
                }
            }
        }

        private void parse(string input)
        {
            expression = parse(input, 0, input.Length - 1);
        }

        private Expression parse(string input, int start, int end)
        {
            Expression solution;

            return solution;
        }
    }

    public class Expression
    {
        private MathOperator mathOperator;
        private MathOperand mathOperand;

        private Expression leftOperand;
        private Expression rightOperand;

        private int constant;
        private char symbol;

        public Expression(dynamic value)
        {
            if (typeof(char) == value.GetType() || typeof(int) == value.GetType())
            {
                set(value);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public double Solve()
        {
            return 0.0f;
        }

        public dynamic Value
        {
            get
            {
                return Solve();
            }
            set
            {
                if (typeof(char) == value.GetType() || typeof(int) == value.GetType())
                {
                    set(value);
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        private void set(int input)
        {
            mathOperand = MathOperand.Constant;
            constant = input;
        }

        private void set(char input)
        {
            mathOperand = MathOperand.Symbol;
            symbol = input;
        }
    }
}
