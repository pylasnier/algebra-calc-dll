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

    public class Expression
    {
        private MathOperator mathOperator;
        private MathOperand mathOperand;

        private Expression leftOperand;
        private Expression rightOperand;

        private int constant;
        private char symbol;

        public Expression(int value)
        {
            SetConstant(value);
        }
        public Expression(char value)
        {
            SetSymbol(value);
        }

        public Expression()
        {
            SetConstant(0);
        }

        public double Solve()
        {
            return 0.0f;
        }

        public double Value
        {
            get
            {
                return Solve();
            }
        }

        public void SetConstant(int input)
        {
            mathOperand = MathOperand.Constant;
            constant = input;
        }

        public void SetSymbol(char input)
        {
            mathOperand = MathOperand.Symbol;
            symbol = input;
        }

        public void SetExpression(Expression leftExpression, Expression rightExpression, MathOperator newMathOperator)
        {
            leftOperand = leftExpression;
            rightOperand = rightExpression;
            mathOperator = newMathOperator;
            mathOperand = MathOperand.Expression;
        }

        public void SetExpression(int leftConstant, Expression rightExpression, MathOperator newMathOperator)
        {
            Expression newLeftOperand = new Expression(leftConstant);
            SetExpression(newLeftOperand, rightExpression, newMathOperator);
        }

        public void SetExpression(char leftSymbol, Expression rightExpression, MathOperator newMathOperator)
        {
            Expression newLeftOperand = new Expression(leftSymbol);
            Expression newRightOperand = new Expression(rightConstant);
            SetExpression(newLeftOperand, newRightOperand, newMathOperator);
        }

        public void SetExpression(Expression leftExpression, int rightConstant, MathOperator newMathOperator)
        {
            Expression newLeftOperand = new Expression(leftConstant);
            Expression newRightOperand = new Expression(rightConstant);
            SetExpression(newLeftOperand, newRightOperand, newMathOperator);
        }

        public void SetExpression(Expression leftExpression, char rightSymbol, MathOperator newMathOperator)
        {
            Expression newLeftOperand = new Expression(leftConstant);
            Expression newRightOperand = new Expression(rightConstant);
            SetExpression(newLeftOperand, newRightOperand, newMathOperator);
        }

        public void SetExpression(int leftConstant, int rightConstant, MathOperator newMathOperator)
        {
            Expression newLeftOperand = new Expression(leftConstant);
            Expression newRightOperand = new Expression(rightConstant);
            SetExpression(newLeftOperand, newRightOperand, newMathOperator);
        }

        public void SetExpression(char leftSymbol, char rightSymbol, MathOperator newMathOperator)
        {
            Expression newLeftOperand = new Expression(leftSymbol);
            Expression newRightOperand = new Expression(rightSymbol);
            SetExpression(newLeftOperand, newRightOperand, newMathOperator);
        }

        public void SetExpression(int leftConstant, char rightSymbol, MathOperator newMathOperator)
        {
            Expression newLeftOperand = new Expression(leftConstant);
            Expression newRightOperand = new Expression(rightSymbol);
            SetExpression(newLeftOperand, newRightOperand, newMathOperator);
        }

        public void SetExpression(char leftSymbol, int rightConstant, MathOperator newMathOperator)
        {
            Expression newLeftOperand = new Expression(leftSymbol);
            Expression newRightOperand = new Expression(rightConstant);
            SetExpression(newLeftOperand, newRightOperand, newMathOperator);
        }
    }
}
