/* http://www.spoj.com/problems/AE00/ */
#include<stdio.h>
#include<math.h>

int main() {
  int n, i, j, answer = 0;
  scanf("%d", &n);
  
  /* counting rectangles */
  for(i = 1; i <= sqrt(n); i++)
    for(j = i+1; i*j <= n; j++)
      answer++;
 
  /* adding possible amount of squares */
  answer += sqrt(n);

  printf("%d", answer);
  return 0;
}
