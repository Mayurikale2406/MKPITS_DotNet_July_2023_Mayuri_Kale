#include<stdio.h>
int main()
{
	int num;
	int counter=2;
	int rem=0;
	printf("\nenter a num");
	scanf("%d",&num);
	while(counter<num)
	{
		rem=num%counter;
		if(rem==0);	
		{
			printf("\n not a prime num");
			break;
	    }
		counter=counter+1;
	}
	if(num==counter)
{

    printf("it is a prime number");
}
    }

