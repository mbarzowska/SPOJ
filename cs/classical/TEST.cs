// http://www.spoj.com/problems/TEST/
using System;

namespace TEST {
    class TEST {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            while (n != 42) {
                Console.WriteLine(n);
                n = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
