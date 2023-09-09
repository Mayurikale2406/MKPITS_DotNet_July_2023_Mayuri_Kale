#include<stdio.h>
int main()
{
	int a=2;
    int	b=3;
	int c=5;
	a++;
	b++;
	++c;
	int result;
	result=a++ + b++ + ++c;
	printf("%d", result);
	return 0;
	
	
	
}

