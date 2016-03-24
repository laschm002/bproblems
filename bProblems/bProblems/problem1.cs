using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bProblems
{
    class wordChecker
    {

        public List<string> wordList = new List<string>();

        public string resultWord;

        public wordChecker ()
        {
            wordList.Add("  ");
        }

        public void getWord ()
        {
           
            Console.WriteLine("Please enter a Word!");
            resultWord = Console.ReadLine();
            
            wordList.Add(resultWord);
        }

          public bool Checker ()
          {
            while (true)
            {
                for (int word = 0; word < wordList.Count; word++)

                    if (wordList[word].Contains(resultWord))
                    {

                        Console.WriteLine("Bark!");
                        getWord();

                    }
                    else
                    {
                        Console.WriteLine("Good,continue");

                        wordList.Add(resultWord);
                        getWord();

                    }
            }
           }       

   }
          
}


