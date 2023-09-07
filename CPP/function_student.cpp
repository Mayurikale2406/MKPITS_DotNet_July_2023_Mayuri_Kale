#include<iostream>
using namespace std;
class student
{
	public:
		string name;
		int classs;
		int rollno;
		int sum;
		int marks1;
		int marks2;
		int marks3;

int calculategrade()
{
    int sum=sum+marks1+marks2+marks3;
    return 0;
}

int displaydata()

{
	cout<<"name"<<name<<endl;
	cout<<"class"<<classs<<endl;
	cout<<"roll no"<<rollno<<endl;
	cout<<"marks1/t"<<"/tmarks2"<<"/tmarks3"<<marks1<<marks2<<marks3<<endl;
}
};
int main()
{
	int result;
	student stud1;
	cout<<"enter a name"<<endl;
	cin>>stud1.name;
	cout<<"enter a rollno"<<endl;
	cin>>stud1.rollno;
	cout<<"enter marks1"<<"mark2"<<"mark3"<<endl;
	cin>>stud1.marks1,stud1.marks2,stud1.marks3;
	result=stud1.calculategrade();
	
}
