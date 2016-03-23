using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaveProblemsDay2
{
    class UserInputChecker
    {

        List<string> enteredWords = new List<string>();
        string word;

        public UserInputChecker()
        {

        }

        public void getUserInput()
        {

            while (true)
            {
                Console.WriteLine("Please enter a word: ");
                word = Console.ReadLine();

                if (enteredWords.Contains(word))
                {
                    Console.WriteLine("Bark! You entered that word already!");
                    break;
                }
                else
                {

                    Console.WriteLine("Thank you for your word");
                    enteredWords.Add(word);

                }


            }


        }
    }
}



