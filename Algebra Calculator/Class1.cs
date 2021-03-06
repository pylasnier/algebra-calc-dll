﻿using System;
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

        private decimal constant;
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

        //All constructor overloads
        public Expression(decimal value)
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

        public Expression()
        {
            SetConstant(0);
        }

        //Implicit conversions for constants and symbols
        public static implicit operator Expression(char input)
        {
            return new Expression(input);
        }

        public static implicit operator Expression(decimal input)
        {
            return new Expression(input);
        }

        //Defining expressions from constants, symbols, or other expressions
        public void SetConstant(decimal input)
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

        public void SetExpression(Expression leftExpression, Expression rightExpression, MathOperator newMathOperator)
        {
            leftOperand = new Expression(leftExpression);
            rightOperand = new Expression(rightExpression);
            mathOperator = newMathOperator;
            mathOperand = MathOperand.Expression;

            constant = 0;
            symbol = '\0';
        }

        //All overloads for implicit conversions for operators
        public static Expression operator +(Expression leftExpression, Expression rightExpression)
        {
            return new Expression(leftExpression, rightExpression, MathOperator.Add);
        }

        public static Expression operator -(Expression leftExpression, Expression rightExpression)
        {
            return new Expression(leftExpression, rightExpression, MathOperator.Subtract);
        }

        public static Expression operator *(Expression leftExpression, Expression rightExpression)
        {
            return new Expression(leftExpression, rightExpression, MathOperator.Multiply);
        }

        public static Expression operator /(Expression leftExpression, Expression rightExpression)
        {
            return new Expression(leftExpression, rightExpression, MathOperator.Divide);
        }

        public static Expression operator ^(Expression leftExpression, Expression rightExpression)
        {
            return new Expression(leftExpression, rightExpression, MathOperator.Power);
        }
    }
}
