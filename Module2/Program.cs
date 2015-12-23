using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharpModule2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int xDim = 8, yDim = 8, initialIndex = 0;
            string[] simbols = { "X", "O" };

            for (int iterY = 0; iterY < yDim; iterY++)
            {
                for (int iterX = 0; iterX < xDim; iterX++)
                {
                    if (iterX == 0)
                        initialIndex = iterY % 2;

                    Console.Write(simbols[initialIndex]);
                    initialIndex = 1 - initialIndex;
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}