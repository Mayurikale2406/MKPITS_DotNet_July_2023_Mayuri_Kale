#include<iostream>
using namespace std;
class circle
{
	public:
		int radius;
float calclulatearea()
	{
		float a=3.14f*radius*radius;
		return a;
	}
float calculateCirc()
{
	float cir=2*3.14*radius;
	return cir;
}
};
int main()
{
	float result;
	circle c1;
	cout<<"enter radius";
	cin>>c1.radius;
	result=c1.calclulatearea();
	cout<<"area"<<result<<endl;
	result=c1.calculateCirc();
	cout<<"circumf="<<result;
}

