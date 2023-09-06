#include<stdio.h>
int main()
{
	int num;
	int counter=2;
	int rem=0;
	
	printf("\n enter a number\n");
	scanf("%d",&num);
	
	do
	{   
	    rem=num%counter;
		if(rem==0)
		{
			printf("\n not a prime num");
			break;
		}
		counter=counter+1;
	}
	while(counter<num);
        if (num==counter)	
	    {
		    printf("\n it is a prime num");
	    }

}


