#include<stdio.h>
int addition()
{
	int n1,n2;
	printf("enter a 2 no");
	scanf("%d%d",&n1,&n2);
	int result=n1+n2;
	return result;
}
int main()
{
	char ch='y';
	do
	{
		int result=addition();
		printf("\nresult=%d",result);
		printf("do you want to continue,press y");
		fflush(stdin);
		scanf("%c",ch);
		
	}
	while(ch=='y');
}
