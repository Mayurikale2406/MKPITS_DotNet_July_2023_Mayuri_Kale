#include<stdio.h>
int main()
{
	int counter=1;
	int sum=0;
	while(counter<=10)
{
	sum=sum+counter;
	counter=counter+1;
}
    printf("\n sum=%d",sum);
}
