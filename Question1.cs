using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Collections
{
    internal class Question1
    {
        public static void Reading()
        {
            int n = 4;
            List<int[]> chapters = new List<int[]>() {
            new int[] {1, 4}, new int[] {5, 7}, new int[] {9, 16}, new int[] {17, 26}
        };
            int k = 7;

            int remainingChapters = 0;
            foreach (int[] chapter in chapters)
            {
                int chapterStart = chapter[0];
                int chapterEnd = chapter[1];
                if (chapterStart <= k && k <= chapterEnd)
                {
                    remainingChapters = n - chapters.IndexOf(chapter);
                    break;
                }
            }
            Console.WriteLine(remainingChapters);
        }

    }   
}
