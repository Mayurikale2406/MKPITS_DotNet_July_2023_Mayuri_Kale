#include<stdio.h>
int main()
{
	int n;
	int sum=0;
	int marks[3];
	marks[0]=70;
	marks[1]=75;
	marks[2]=65;
	
	for(n=0;n<=3;n++)
	{
		printf("\n marks=%d",marks[n]);
		sum=sum+marks[n];
	}
	    printf("\n total marks %d",sum);
}
