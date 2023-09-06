#include<stdio.h>
int main()
{
	int num;
	int count=20;
	int sum=0;

    printf("\nenter a num");
	scanf("%d",&num);
	
	for(count=1;count<=20;count++)
	{
		if(count%2==1)
		{
			sum=sum+count;
			printf("\n%d",sum);
			
		}
	}
	
		
}

