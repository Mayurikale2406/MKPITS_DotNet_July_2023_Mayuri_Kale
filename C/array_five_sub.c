#include<stdio.h>
int main()
{
	int n;
	int sum=0;
	int marks[5];
	
	for(n=0;n<5;n++)
	{
		printf("\n enter a marks :");
		scanf("%d",&marks[n]);
	}
	for(n=0;n<5;n++)
	{
		printf("\n marks=%d",marks[n]);
		sum=sum+marks[n];
	}
	    printf("\n total marks=%d",sum);
}
