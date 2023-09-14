#include<stdio.h>
int main()
{
	int num;
	int res=0;
	int a;
	int sum=0;
	
	printf("enter any num");
	scanf("%d",&num);
	
	for(res=num;num!=0;num=num/10)
	{
		a=num%10;
		sum=sum+(a*a*a);
		
	}
	if(sum==res)
	printf("%d is a armstrong num",res);
	else
	printf("%d is not a armstrong num",res);
}
