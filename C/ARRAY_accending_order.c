#include<stdio.h>
int main()
{
	int i,j,p,q,n;
	int array[100];
		printf("\n enter a value");
		scanf("%d",&n);
	    printf("enter the num");
	for(i=0;i<n;i++)
	   scanf("%d",&array[i]);
	   for(i=0;i<n;i++)
    
	{
		for(j=i+1;j<n;j++)
		{
			if(array[i]>array[j])
			{
				p=array[i];
				array[i]=array[j];
				array[j]=p;
			}
		}
	}
				printf("\n the array in assending order");
				for(i=0;i<n;i++)
					printf("\n %d",array[i]);
}

