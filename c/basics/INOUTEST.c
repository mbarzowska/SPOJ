/* http://www.spoj.com/problems/INOUTEST/ */
#include <stdio.h>

int main(void) {
  long long howManyLines=0, a=0, b=0;
  scanf("%lld", &howManyLines);
  while(howManyLines>0) {
    scanf("%lld %lld", &a, &b);
    printf("%lld\n", a*b);
    howManyLines--;
  }
}
