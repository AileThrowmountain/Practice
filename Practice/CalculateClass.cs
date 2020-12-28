using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Practice
{
    public class CalculateClass
    {
        public int Sum { get; set; }

        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }


        public int CalculateSum()
        {
            Sum = FirstNumber + SecondNumber;
            return Sum;
        }

        public decimal CalculateDiviation(decimal number, decimal anotherNumber)
        {
            decimal sum = 0;
            sum = number / anotherNumber;
            Math.Round(sum, 2);
            return sum;
        }

        public decimal CalculateMultiplication(decimal number, decimal anotherNumber)
        {
            decimal sum = 0;
            sum = number * anotherNumber;
            Math.Round(sum, 2);
            return sum;
        }

        public decimal CalculateAddition(decimal number, decimal anotherNumber)
        {
            decimal sum = 0;
            sum = number + anotherNumber;
            Math.Round(sum, 2);
            return sum;
        }
        public decimal CalculateAbstraction(decimal number, decimal anotherNumber)
        {
            decimal sum = 0;
            sum = number - anotherNumber;
            Math.Round(sum, 2);
            return sum;
        }

    }
}
