#include<stdio.h>
void prime(int num,int count)
{
	int result=num%count;
	printf("\n enter a prime num\n");
}
int main()
{
	int n;
	int count=2;
	int rem=0;
	
	printf("enter a num\n");
	scanf("%d",&n);
	
	while(count<n);
	{
	  rem=n%count;
	    if(rem==0);
   			{
    			printf("\n not a prime no");
			}
	    		count=count+1;
       	 if(n==count)
   		    {
        		printf("it is prime no");
    		}
    }
}
