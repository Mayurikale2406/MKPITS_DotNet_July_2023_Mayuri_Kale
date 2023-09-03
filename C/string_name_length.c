#include<stdio.h>
#include<string.h>
int main()
{
	int count=0;
	char name[10];
	char*ptr;
	printf("\n enter a name\n");
	gets(name);
	ptr=name;
	
	while(*ptr!='\0')
    {
	  count++;
      ptr++;
    }
    printf("\n enter a length of string=%d\n",count);
	
}
