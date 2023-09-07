#include<iostream>
using namespace std;
class student
{
	public:
		string name;
		int studentclass;
		int RollNumber;
		int marks;
void getData()
{
    cout<<"student details"<<endl;
	cout<<"name :"<<endl;
	cin>>name;
	cout<<"class :"<<endl;
	cin>>studentclass;
	cout<<"RollNumber :"<<endl;
	cin>>RollNumber;
	cout<<"marks(0-100) : "<<endl;
	cin>>marks;
}
void displayGrade()
{

	if(marks >= 90)
{
	cout<< "grade: A";
}
	else if (marks >= 80)
{
	cout<< "grade: B";
}
	else if (marks >= 70)
{
	cout<< "grade: C";
}
    else if(marks >= 60)
{
	cout<< "grade: D";
}
    else
{
    cout<<"grade: E";
}
}
void DisplayInformation()
{
    cout<<"name : "<<name<<endl;
    cout<<"studentclass : "<<studentclass<<endl;
    cout<<"RollNumber : "<<RollNumber<<endl;
    cout<<"marks : "<<marks<<endl;
}	
};
int main()
{
	student stud;
	
	stud.getData();
	stud.DisplayInformation();
	stud.displayGrade();
	return 0;
	
}

    

