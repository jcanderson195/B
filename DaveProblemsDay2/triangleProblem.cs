using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaveProblemsDay2
{
    class triangleProblem
    {
        List<List<string>> triangleBoard = new List<List<string>>();
        List<string> inside = new List<string>();
        public triangleProblem()
        {

        }

        public void triangle()
        {

            triangleBoard.Add(inside);


            int listSize = 4;

            for (int index = 0; index < listSize; index++)
            {
                triangleBoard.Add(new List<string>());




                for (int innerIndex = 0; innerIndex < 1; innerIndex++)
                {

                    triangleBoard[innerIndex].Add("*");

                    foreach (List<string> innerList in triangleBoard)
                    {

                        Console.WriteLine();
                        foreach (string square in innerList)
                        {

                            Console.Write(square);


                        }
                    }
                }

            }

        }


        public void BackwardsTriangle()
        {
            triangleBoard.Add(inside);


            int listSize = 4;

            for (int index = 4; index < listSize; index--)
            {
                triangleBoard.Add(new List<string>());




                for (int innerIndex = 0; innerIndex < 1; innerIndex--)
                {

                    triangleBoard[innerIndex].Add("*");

                    foreach (List<string> innerList in triangleBoard)
                    {

                        Console.WriteLine();
                        foreach (string square in innerList)
                        {

                            Console.Write(square);


                        }
                    }
                }

            }
        }


        public void UpsideDownTriangle()
        {
            triangleBoard.Add(inside);


            int listSize = 4;

            for (int index = 0; index < listSize; index++)
            {
                triangleBoard.Add(new List<string>());




                for (int innerIndex = 0; innerIndex < 1; innerIndex++)
                {

                    triangleBoard[innerIndex].Add("*");

                    foreach (List<string> innerList in triangleBoard)
                    {

                        Console.WriteLine();
                        foreach (string square in innerList)
                        {

                            Console.Write(square);


                        }
                    }
                }

            }
        }


    }
}
