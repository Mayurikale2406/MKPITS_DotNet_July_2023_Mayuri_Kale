#include<stdio.h>
int main()
{
	int count=1,num;
	
	printf("enter a num");
	scanf("%d",&num);
	table:
	 
	    printf("\n%d*%d=%d",num,count,num*count);
	    count++;
	 
		if(count<=10)
	 { 
	    goto table;
	 }
}
