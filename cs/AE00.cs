// http://www.spoj.com/problems/AE00/
using System;

namespace AE00 {
    class AE00 {
        static void Main(string[] args) {
            var n = Convert.ToInt32(Console.ReadLine());
            var answer = 0;
            for (var i = 1; i <= n; i++) {
                for (var j = i; j <= n; j++) {
                    if (i * j > n)
                        break;
                    answer++;
                }
            }
            Console.WriteLine(answer);
        }
    }
}