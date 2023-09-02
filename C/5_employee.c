#include<stdio.h>
struct employee
{
	char name[30];
	char designation[20];
	char dept[20];
	int e;
	int salary;
};
int main()
{
	struct employee a;
	int counter;
	for(counter=0;counter<5;counter++)
{
	
	printf("\n enter a employee details :   ");
	printf("\n                                     \n");
	printf("\n enter a name :");
	scanf("%s",a.name);
	printf("\n enter designation :");
	scanf("%s",a.designation);
	printf("\n enter department :");
	scanf("%s",a.dept);
	printf("\n enter employee id :");
	scanf("%d",&a.e);\
	printf("\n enter a salary : ");
	scanf("%d",&a.salary);
	printf("...........................................\n");
	printf("  \n employee details  \n");
	printf("\n                                          \n");
	printf("\n name : %s \n",a.name);
	printf("\n designation : %s \n" ,a.designation);
	printf("\n department : %s \n",a.dept);
	printf("\n employee id : %d",a.e);
	printf("\n salary : %d",a.salary);
	printf("\n ........................................\n");
	printf("\n");
}
}
