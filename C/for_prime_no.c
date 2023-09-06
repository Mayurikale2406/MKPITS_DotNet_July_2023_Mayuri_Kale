#include<stdio.h>
int main()
{
	int num;
	int count=2;
	int rem=0;
	
	for(num=3;num<=20;num++)
	{
		count=2;
		while(count<num)
    {
        rem=num%count;
		if(rem==0)
	{
		break;
    }
        count++;
    }
    if(num==count)
	{
		printf("\n%d is a prinme num",num);
	}
}
}
