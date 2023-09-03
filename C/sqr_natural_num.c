#include<stdio.h>
int main()
{
	int num;
	int sum=0;
	int count;
	int sqr;
	
	printf("\nenter a num");
	scanf("%d",&num);
	
	for(count=1;count<=num;count++)
	
	sqr=count*count;
	printf("\n%dnatural a sqr num",sqr,count);
	
	for(count=1;count<=num;count++)
	
	sum=sum+count;
	count=count+1;
	printf("\n%dsum",sum);
	
	
}
