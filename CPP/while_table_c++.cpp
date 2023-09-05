#include<iostream>
using namespace std;
int main()
{
	int num;
	int count=0;
	cout<<"enter a num";
	cin>>num;
	while(count<10)
{	
    count++;
	cout<<num<<"*"<<count<<"="<<num*count<<endl;
}
	return 0;

}
