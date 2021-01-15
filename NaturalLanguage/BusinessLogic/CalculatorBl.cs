using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaturalLanguage.BusinessLogic
{
    public class CalculatorBl : ICalculatorBl
    {
        //This method makes a simple calculation, which combines everything
        public float Calculate(string exp)
        {
            try
            {
                var expression = exp.Split(' ');

                var total = (float)ConvertNumber(expression[0]);
                for (int i = 1; i < expression.Length - 1; i++)
                {
                    //operator
                    var op = expression[i];

                    //check if it is operator
                    if (!IsOperator(op))
                        continue;

                    //second number
                    var num2 = ConvertNumber(expression[i + 1].ToString());

                    total = ConvertOperators(op, total, num2);
                }

                return total;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        //this method converts natural language numbers to numeric numbers
        private int ConvertNumber(string number)
        {
            return (number.ToLower()) switch
            {
                "zero" => 0,
                "one" => 1,
                "two" => 2,
                "three" => 3,
                "four" => 4,
                "five" => 5,
                "six" => 6,
                "seven" => 7,
                "eight" => 8,
                "nine" => 9,
                "ten" => 10,
                _ => 0,
            };
        }

        //This method converts operators and calls the methods to do the calculation based on the operator
        private float ConvertOperators(string op, float num1, int num2)
        {
            return (op.ToLower()) switch
            {
                "plus" => Addition(num1, num2),
                "add" => Addition(num1, num2),
                "subtract" => Subtraction(num1, num2),
                "minus" => Subtraction(num1, num2),
                "less" => Subtraction(num1, num2),
                _ => 0,
            };
        }
        //This method checks if the item is indeed an operator
        private bool IsOperator(string op)
        {
            return (op.ToLower()) switch
            {
                "plus" => true,
                "add" => true,
                "subtract" => true,
                "minus" => true,
                "less" => true,
                _ => false,
            };

        }
        //This method calculates a sum of the two numbers
        private float Addition(float num1, int num2)
        {
            return num1 + num2;
        }
        //this method calculates the difference if the two numbers
        private float Subtraction(float num1, int num2)
        {

            return num1 - num2;
        }
    }
}
