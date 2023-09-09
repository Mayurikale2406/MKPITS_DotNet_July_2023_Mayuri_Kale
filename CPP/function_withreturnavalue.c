#include<iostream>
using namespace std;
int myfunct(int x,int y)
{
 if(y<=0)
 return x,y*(myfunct (x,y-1));	
}
 int main()
{
	myfunct(5,3);
	  
    return 0;
}
