#include<stdio.h>
int main()
{
	int num;
	int count;
	int cube;
	
	printf("enter a num");
	scanf("%d",&num);
	
	for(count=1;count<=num;count++)
{	
	cube=count*count*count;
	
	printf("\n %d cube is %d",count,cube);
}
}
