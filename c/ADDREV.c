/* http://www.spoj.com/problems/ADDREV/ */
#include <stdio.h>

int reverse (int value) {
  int result = 0;
  while (value > 0) {
	result = result * 10;
	result = result + (value % 10);
	value = value / 10;
  }
  return result;
}
			
int main(void) {
  int lines;
  scanf("%d", &lines);
  while(lines--) {
	int n1, n2;
	scanf("%d %d", &n1, &n2);
	printf("%d\n", reverse(reverse(n1) + reverse(n2)));
  }
  return 0;
}
