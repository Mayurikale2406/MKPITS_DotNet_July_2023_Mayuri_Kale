#include<stdio.h>
int square(int num)
{   
    if(num%2==0)printf("even"); 
	else printf("odd");   
}
int main()
{
	int num;
	printf("\n enter a num");
	scanf("%d",&num);
	printf("%d",square(num));
	
	
}
