#include<stdio.h>
void sayhello()
{
	printf("hellow");
}
int main()
{
	printf("\ncalling function\n");
	sayhello();
	printf("\nback in main function\n");
	sayhello();
	printf("\nbye");
}
