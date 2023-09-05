#include<iostream>
using namespace std;
class employee
{
    public:
	    int empno;//instance variable
	    string empname;
employee(int empno,string empname)
{
	this->empno=empno;
	this->empname=empname;
}
int display()
{
	cout<<empno<<empname<<endl;
}
};
	int main()
	{
		employee emp(2406,"\nmayuri");
		emp.display();
		return 0;
    }
