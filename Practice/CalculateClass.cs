using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
      
    }
}
