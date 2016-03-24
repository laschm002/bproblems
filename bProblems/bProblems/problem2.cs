using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bProblems
{
    public class triangleProblem
    //In this problem, you MUST use a 2 dimensional list, and you MUST use nested loops
    //Write a class that has a constructor which takes in a number and creates a 2 
    //dimensional list with length and height matching that number.
    {
        List<List<string>> shapeBoard = new List<List<string>>();

        List<string> insideList = new List<string>();

        public triangleProblem()
        {

        }

        public void triangle()
        {

            shapeBoard.Add(insideList);

            int listSize = 4;

            for (int index = 0; index < listSize; index++)
            {
                shapeBoard.Add(new List<string>());

                for (int innerIndex = 0; innerIndex < index + 1; innerIndex++)
                {
                    shapeBoard[index].Add("*");
                }
            }

            foreach (List<string> innerList in shapeBoard)
            {
                Console.WriteLine();
                foreach (string shape in innerList)
                {
                    Console.Write(shape);
                }
            }

        }
        public void backwardsTriangle()
        {

            int listSize = 4;

            for (int index = 0; index < listSize; index++)
            {
                shapeBoard.Add(new List<string>());

                for (int innerIndex = listSize - 1; innerIndex > index - 1; innerIndex--)
                {
                    shapeBoard[index].Add(" ");
                }
                for (int innerIndex = 0; innerIndex < index + 1; innerIndex++)
                {
                    shapeBoard[index].Add("*");
                }

            }
            foreach (List<string> innerList in shapeBoard)
            {
                Console.WriteLine();
                foreach (string shape in innerList)
                {
                    Console.Write(shape);
                }
            }
        }


        public void otherTriangle()
        {

            shapeBoard.Add(insideList);
            
            int listSize = 4;

            for (int index = 1; index < listSize; index++)
            {
                shapeBoard.Add(new List<string>());

                for (int innerIndex = 1; innerIndex < index; innerIndex++)
                {
                    shapeBoard[index].Add("*");
                }
                
            }

            foreach (List<string> innerList in shapeBoard)
            {
                Console.WriteLine();
                foreach (string shape in innerList)
                {
                    Console.Write(shape);
                }
            }

        }
    }
}
