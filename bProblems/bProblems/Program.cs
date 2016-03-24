using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            fibonacci test1 = new fibonacci();
            test1.getFibonacciNum();


            triangleProblem test = new triangleProblem();
            test.triangle();
            test.backwardsTriangle();
            test.otherTriangle();

                wordChecker word = new wordChecker();
                word.getWord();
                word.Checker();
        }

        
    }
}
