#include<stdio.h>
int main()
{
	int count;
	
	for(count=1;count<=10;count++)
	{
		if(count%2==0)
		{
			continue;
		}
		printf("\nnum=%d",count);
	}
	    printf("\n bye");
}
