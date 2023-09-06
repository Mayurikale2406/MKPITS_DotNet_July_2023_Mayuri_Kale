#include<stdio.h>
int main()
{
	int ch;
	printf("enter a month\n");
	scanf("%c",&ch);
	
	switch(ch)
	{
		case 'j':
			printf( "\n31 days");
			break;
			
		case 'f':
		    printf("\n29 days");
		    break;
		
		case 'm':
			printf("\n 30 days");
			break;
			
		case 'a':
			printf("\n 31 days");
			break;
			
		case 'n':
			printf("\n 30 days ");
			break;
			
		case 'd':
			printf("\n 30 days");
			break;
	}
	
	
}
