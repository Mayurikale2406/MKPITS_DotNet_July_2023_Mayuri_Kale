#include<stdio.h>
int sub(int n1,int n2)
{
	int result=n1-n2;
	return result;
}
int main()
{
	char ch='y';
	do
	{
		int num1,num2,result;
		printf("\nenter 2 no");
		scanf("%d%d",&num1,&num2);
		result=sub(num1,num2);
		printf("\nresult=%d",result);
		printf("\ndo you want to continue,press y\n");
		fflush(stdin);
		scanf("%c",&ch);
	}
	while(ch=='y');
}
