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

        //public void RightInputInTextbox(string number)
        //{
        //    bool isNumber;
        //    if (isNumber = number.Select(c => char.IsDigit(c)).Sum(x => x ? 0 : 1) == 0)
        //    {
        //        CalculateSum();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Skriv in heltal!");
        //    }
        //}

    }
}
