#include<stdio.h>
int main()
{
	int num;
	int count;
	int result=0;
	
	printf("\nenter a num");
	scanf("%d",&num);
	
	for(count=1;count<=10;count++)
	{
	result=num*count;
	printf("\n%d*%d=%d",num,count,num*count);
    }
}
