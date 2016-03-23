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

            // UserInputChecker inputChecker = new UserInputChecker();
            //inputChecker.getUserInput();

            triangleProblem triangle = new triangleProblem();
            triangle.triangle();


            triangleProblem backwards = new triangleProblem();
            backwards.BackwardsTriangle();
            
            triangleProblem upsideDownTriangle = new triangleProblem();
            upsideDownTriangle.UpsideDownTriangle();

            

        }
    }
}
