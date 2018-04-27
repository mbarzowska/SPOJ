// http://www.spoj.com/problems/STRHH/ 
using System;

namespace STRHH {
    class STRHH {
        public static void Main(string[] args) {
            int lines = Convert.ToInt32(Console.ReadLine());
            string[] words = new string[lines];
            for (int i = 0; i < lines; i++) {
                words[i] = Console.ReadLine();
                for (int j = 0; j < words[i].Length/2; j++) {
                    if (j%2 == 0) {
                        Console.Write(words[i][j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}