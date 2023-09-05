#include<iostream>
using namespace std;
class shape
{
	public:
		int x;
		int y;

void getdata(int a,int b)
{
	x=a;
	y=b;
}
};
class rectrangle:public shape
{
	public:
		int carea()
		{
			int ra;
			ra= x*y;
			return ra;
		}
};
class trangle:public shape
{
	public:
		float carea()
		{
			float ta;
			ta=0.5f*x*y;
			return ta;
		}
};
int main()
{
	rectrangle r;
	trangle t;
	int length,breath,base,height;
	int ra;
	float ta;
	cout<<"enter length and breath"<<endl;
	cin>>length>>breath;
	r.getdata(length,breath);
	ra=r.carea();
	cout<<"area of rectrangle ="<<ra<<endl;
	cout<<"enter base and height"<<endl;
	cin>>base>>height;
	t.getdata(base,height);
	ta=t.carea();
	cout<<"area of trangle ="<<ta<<endl;
	return 0;
}
