using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaveProblemsDay2
{
    class FibbonacciNumbers
    {
        List<int> newNumbers = new List<int>();

        public FibbonacciNumbers()
        {

        }

        public void NumberSequence(int n)
        {
            int firstNumber = 0;
            int secondNumber = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber = temp + secondNumber;
                
                
            }
        }
    }
}

            

    



