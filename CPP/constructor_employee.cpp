#include<iostream>
using namespace std;
class employee
{
	public:
		int empno;
		string empname;
		employee(int eno,string en)
{
	empno=eno;
	empname=en;
}
void display()
{
	cout<<"empno"<<empno<<endl;
	cout<<"empname"<<empname<<endl;
}
};
int main()
{
	int eno;
	string en;
	employee emp1(11,"mayuri");
	emp1.display();
}
