using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra
{
    public enum MathOperator
    {
        None = 0,
        Add = 1,
        Subtract = 2,
        Multiply = 3,
        Divide = 4,
        Power = 5
    };

    //Expression objects will always represent either operations (expressions), constants e.g. integer values, or symbols that will represent values
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

        public List<char> Symbols
        {
            get
            {
                List<char> symbols = new List<char>();

                if (MathOperand.Symbol == mathOperand)
                {
                    symbols.Add(symbol);
                }
                else if (MathOperand.Expression == mathOperand)
                {
                    foreach (char aSymbol in leftOperand.Symbols)
                    {
                        symbols.Add(aSymbol);
                    }
                    foreach (char aSymbol in rightOperand.Symbols)
                    {
                        symbols.Add(aSymbol);
                    }
                }

                return symbols;
            }
        }

        public Expression(int value)
        {
            SetConstant(value);
        }

        public Expression(char value)
        {
            SetSymbol(value);
        }

        public Expression(Expression value)
        {
            SetExpression(value);
        }

        public Expression(Expression leftExpression, Expression rightExpression, MathOperator newMathOperator)
        {
            SetExpression(leftExpression, rightExpression, newMathOperator);
        }

        public Expression(int leftExpression, Expression rightExpression, MathOperator newMathOperator)
        {
            SetExpression(leftExpression, rightExpression, newMathOperator);
        }

        public Expression(char leftExpression, Expression rightExpression, MathOperator newMathOperator)
        {
            SetExpression(leftExpression, rightExpression, newMathOperator);
        }

        public Expression(Expression leftExpression, int rightExpression, MathOperator newMathOperator)
        {
            SetExpression(leftExpression, rightExpression, newMathOperator);
        }

        public Expression(Expression leftExpression, char rightExpression, MathOperator newMathOperator)
        {
            SetExpression(leftExpression, rightExpression, newMathOperator);
        }

        public Expression(int leftExpression, int rightExpression, MathOperator newMathOperator)
        {
            SetExpression(leftExpression, rightExpression, newMathOperator);
        }

        public Expression(char leftExpression, char rightExpression, MathOperator newMathOperator)
        {
            SetExpression(leftExpression, rightExpression, newMathOperator);
        }

        public Expression(int leftExpression, char rightExpression, MathOperator newMathOperator)
        {
            SetExpression(leftExpression, rightExpression, newMathOperator);
        }

        public Expression(char leftExpression, int rightExpression, MathOperator newMathOperator)
        {
            SetExpression(leftExpression, rightExpression, newMathOperator);
        }

        public Expression()
        {
            SetConstant(0);
        }
        public void SetConstant(int input)
        {
            mathOperand = MathOperand.Constant;
            constant = input;

            symbol = '\0';
            leftOperand = null;
            rightOperand = null;
        }

        public void SetSymbol(char input)
        {
            mathOperand = MathOperand.Symbol;
            symbol = input;

            constant = 0;
            leftOperand = null;
            rightOperand = null;
        }

        //All overloads for defining expressions
        public void SetExpression(Expression input)
        {
            switch (input.mathOperand)
            {
                case MathOperand.Constant:
                    SetConstant(input.constant);
                    break;

                case MathOperand.Symbol:
                    SetSymbol(input.symbol);
                    break;

                case MathOperand.Expression:
                    SetExpression(input.leftOperand, input.rightOperand, input.mathOperator);
                    break;
            }
        }

        private void setExpressionGeneric(dynamic leftExpression, dynamic rightExpression, MathOperator newMathOperator)
        {
            leftOperand = new Expression(leftExpression);
            rightOperand = new Expression(rightExpression);
            mathOperator = newMathOperator;
            mathOperand = MathOperand.Expression;

            constant = 0;
            symbol = '\0';
        }

        public void SetExpression(Expression leftExpression, Expression rightExpression, MathOperator newMathOperator)
        {
            setExpressionGeneric(leftExpression, rightExpression, newMathOperator);
        }

        public void SetExpression(int leftExpression, Expression rightExpression, MathOperator newMathOperator)
        {
            setExpressionGeneric(leftExpression, rightExpression, newMathOperator);
        }

        public void SetExpression(char leftExpression, Expression rightExpression, MathOperator newMathOperator)
        {
            setExpressionGeneric(leftExpression, rightExpression, newMathOperator);
        }

        public void SetExpression(Expression leftExpression, int rightExpression, MathOperator newMathOperator)
        {
            setExpressionGeneric(leftExpression, rightExpression, newMathOperator);
        }

        public void SetExpression(Expression leftExpression, char rightExpression, MathOperator newMathOperator)
        {
            setExpressionGeneric(leftExpression, rightExpression, newMathOperator);
        }

        public void SetExpression(int leftExpression, int rightExpression, MathOperator newMathOperator)
        {
            setExpressionGeneric(leftExpression, rightExpression, newMathOperator);
        }

        public void SetExpression(char leftExpression, char rightExpression, MathOperator newMathOperator)
        {
            setExpressionGeneric(leftExpression, rightExpression, newMathOperator);
        }

        public void SetExpression(int leftExpression, char rightExpression, MathOperator newMathOperator)
        {
            setExpressionGeneric(leftExpression, rightExpression, newMathOperator);
        }

        public void SetExpression(char leftExpression, int rightExpression, MathOperator newMathOperator)
        {
            setExpressionGeneric(leftExpression, rightExpression, newMathOperator);
        }

        //All overloads for operate methods, variants of SetExpression methods
        public void Operate(Expression rightExpression, MathOperator newMathOperator)
        {
           SetExpression(this, rightExpression, newMathOperator);
        }
        public void Operate(int rightExpression, MathOperator newMathOperator)
        {
            SetExpression(this, rightExpression, newMathOperator);
        }
        public void Operate(char rightExpression, MathOperator newMathOperator)
        {
            SetExpression(this, rightExpression, newMathOperator);
        }
    }
}
