// http://www.spoj.com/problems/SMPDIV/ 
using System;

namespace SMPDIV {
    class SMPDIV {
        public static void Main(string[] args) {
            int lines = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < lines; i++) {
                string[] input = Console.ReadLine().Split();
                int n = Convert.ToInt32(input[0]);
                int x = Convert.ToInt32(input[1]);
                int y = Convert.ToInt32(input[2]);
                for (int j = 0; j < n; j++) {
                    if ((j%x == 0) && (j%y != 0)) {
                    	 Console.Write(j + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}