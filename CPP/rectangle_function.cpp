#include<iostream>
using namespace std;
class Rectangle
{
	public:
		int length;
		int width;
float calclulatearea()
{
	float a=length*width;
	return a;
}
float calclulateparameter()
{
	float para=2*length+width;
	return para;
}
};
int main()
{
	float result;
	Rectangle r1;
	cout<<"enter length";
	cin>>r1.length;
	cout<<"enter width";
	cin>>r1.width;
	result=r1.calclulatearea();
	cout<<"area="<<result<<endl;
	result=r1.calclulateparameter();
	cout<<"para="<<result;
}
