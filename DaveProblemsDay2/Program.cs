using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaveProblemsDay2
{
    class Program
    {
        static void Main(string[] args)
        {

            

            triangleProblem triangle = new triangleProblem();
            triangle.triangle();


            triangleProblem backwards = new triangleProblem();
            backwards.BackwardsTriangle();

            triangleProblem upsideDownTriangle = new triangleProblem();
            upsideDownTriangle.UpsideDownTriangle();

            UserInputChecker inputChecker = new UserInputChecker();
            inputChecker.getUserInput();

            FibbonacciNumbers newSequence = new FibbonacciNumbers();
            newSequence.NumberSequence(1);  /*Not completed*/

            

        }
    }
}
