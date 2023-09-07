#include <iostream>
#include <string>
using namespace std;
class Student {
  private:
  string name;
  string studentClass;
  int rollNumber;
  double marks;
  std::string calculateGrade() {
    if (marks >= 90) {
      return "A+";
    } else if (marks >= 80) {
      return "A";
    } else if (marks >= 70) {
      return "B";
    } else if (marks >= 60) {
      return "C";
    } else {
      return "D";
    }
  }

  void displayInformation() {
    cout << "\n\nName: " << name <<endl;
    cout << "Class: " << studentClass <<endl;
    cout << "Roll Number: " << rollNumber <<endl;
    cout << "Marks: " << marks << endl;
    cout << "Grade: " << calculateGrade() <<endl;
  }
};

int main() {
  string studentName;
  string sClass;
  int rollNum;
  double studentMarks;
  cout << "Student details: ";
  cout << "\nName: ";
  cin>>studentName;

  cout << "Class: ";
  cin>> sClass;

  cout << "Roll number: ";
  cin >> rollNum;

  cout << "Marks (0-100): ";
  cin >> studentMarks;


  return 0;
}
