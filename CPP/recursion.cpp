#include<iostream>
using namespace std;
int myfunction(int x,int y)
{
	if(y<=0)
	{
		return 1;
	}
	else
	{
		return x*(myfunction(x,y-1));
	}
}
int main()
{
	int result;
	result= myfunction(6,3);
	cout<<"result="<<result<<endl;
	return 0;
	
}
