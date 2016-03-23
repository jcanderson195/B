using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaveProblemsDay2
{
    class UserInputChecker
    {

       public List<string> enteredWords = new List<string>();
        string word;

        public UserInputChecker()
        {
            enteredWords.Add(" ");
        }

        public void getUserInput()
        {

            while (true)
            {
                Console.WriteLine("Please enter a word: ");
                word = Console.ReadLine();


                for (int newWord = 0; newWord < enteredWords.Count; newWord++)
                {
                    if (enteredWords[newWord] == word)
                    {
                        Console.WriteLine("Bark! You entered that word already!");
                        Environment.Exit(0);
                    }

                }
                    
                        Console.WriteLine("Thank you for your word");
                        
                enteredWords.Add(word);
                

            }

        }
    }
}



