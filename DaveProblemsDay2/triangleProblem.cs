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

        List<List<string>> triangleBoardUpsideDown = new List<List<string>>();
        List<string> inside2 = new List<string>();

        List<List<string>> triangleBoardBackwards = new List<List<string>>();
        List<string> inside3 = new List<string>();

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
                }
            
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

            

        


        public void UpsideDownTriangle()
        {
            {
                triangleBoardUpsideDown.Add(inside2);


                int listSize = 4;

                for (int index = 0; index < listSize; index++)
                {
                    triangleBoardUpsideDown.Add(new List<string>());

                    for (int innerIndex = listSize - 1; innerIndex > index - 1; innerIndex--)
                    {

                        triangleBoardUpsideDown[index].Add("*");
                    }
                }


                foreach (List<string> innerList in triangleBoardUpsideDown)
                {
                    foreach (string star in innerList)
                    {

                        Console.Write(star);
                    }
                    Console.WriteLine();
                }
            }
        }
        
        


        public void BackwardsTriangle()
        {
            triangleBoardBackwards.Add(inside3);


            int listSize = 4;

            for (int index = 0; index < listSize; index++)
            {
                triangleBoardBackwards.Add(new List<string>());

                for (int innerIndex = listSize - 1; innerIndex > index - 1; innerIndex--)
                {

                    triangleBoardBackwards[index].Add(" ");
                }

                for (int innerIndex = 0; innerIndex < index + 1; innerIndex++)
                {
                    triangleBoardBackwards[index].Add("*");
                }
            }
                    foreach (List<string> innerList in triangleBoardBackwards)
                    {
                        foreach (string star in innerList)
                        {

                            Console.Write(star);
                        }
                Console.WriteLine();
                    }
                }

            }
        }


    

