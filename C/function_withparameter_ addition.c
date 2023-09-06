#include<stdio.h>
void addition(int n1,int n2)
{
    int result=n1+n2;	
	printf(" addition of two num=%d",result);
	
}
int main()
{
	int num1,num2;
	printf("\n enter a 2 no");
	scanf("%d%d",&num1,&num2);
	addition(num1,num2);
	printf("\n bye");
}
