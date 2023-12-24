using System;
using System.Globalization;

namespace Lab1OopApplication.Source
{
    public class MathOperations
    {
        public static double Sum(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static double Subtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static double Extent(double firstNumber, double secondNumber) 
        {
            return Math.Pow(firstNumber, secondNumber);
        }

        public static string Compare(double firstNumber, double secondNumber)
        {
            int comparisonResult = firstNumber.CompareTo(secondNumber);

            if (comparisonResult < 0)
                return "первое число меньше чем второе";
            else if (comparisonResult > 0)
                return "первое число больше чем второе";
            else
                return "числа равны";
        }
    }
}
