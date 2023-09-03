#include<stdio.h>
void deposit(int amt,int bal);
void withdrow(int amt,int bal);
int main()
{
	int amt,bal=1000;
	printf("enter a amount");
	scanf("%d",&amt);
	deposit(amt,bal);
	withdrow(amt,bal);
}
void deposit(int amt,int bal)
{
	bal=bal+amt;
	printf("\namount deposit bal is=%d",bal);
}
void withdrow(int amt,int bal)
{
	bal=bal-amt;
	printf("\namount withdrawl balance=%d",bal);
}
