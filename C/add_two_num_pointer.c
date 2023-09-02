#include<stdio.h>
int main()
{
	int num1,num2;
	int result=0;
	int *a,*b;
	char*ptr;
	printf("\n enter a 2 num\n");
	scanf("%d%d",&num1,&num2);
	a=&num1;
	b=&num2;
	result=*a+*b;
    printf("\n addition of two num=%d\n",result);
    ptr++;
	
}
