#include<string.h>
struct book
{
	int bookid;
	char title[50];
	char author[50];
};
int main()
{
	struct book b1;
	strcpy(b1.title,"haircare");
	strcpy(b1.author,"mayuri");
	b1.bookid=2406;
	printf("\n title=%s",b1.title);
	printf("\n author=%s",b1.author);
	printf("\n bookid=%d",b1.bookid);
}

