using System;
using System.Collections.Generic;
using System.Linq;

namespace linqdemo
{
    internal class Program
    {

        static void Main()
        {
            int[] scores = new int[] { 1, 2, 3, 4, 5, };
            IEnumerable<int> scoresQuerry = from score in scores    
                                            where score > 0
                                            select score;
            foreach (int i in scoresQuerry)
            {
                Console.WriteLine(i + " ");
                Console.ReadLine();
            }
        }
    }
}
