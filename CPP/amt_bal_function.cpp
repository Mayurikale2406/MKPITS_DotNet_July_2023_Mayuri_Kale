#include<iostream>
using namespace std;
class Bank_account
{
	public:
		int account_num;
		int bal=1000;
		int amt;
int deposite()
{
	bal=bal+amt;
	return bal;
}
int withdrow()
{
	bal=bal-amt;
	return bal;
}
};
int main()
{
	int result;
	Bank_account b1;
	cout<<"enter account_num";
	cin>>b1.account_num;
	cout<<"enter balance";
	cin>>b1.bal;
	cout<<"enter amount";
	cin>>b1.amt;
	result=b1.deposite();
	cout<<"deposite"<<result<<endl;
	result=b1.withdrow();
	cout<<"withdrow"<<result<<endl;
	 
}
		

