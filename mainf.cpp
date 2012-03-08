#include <iostream>
#include <string.h>
#include "DefinitionOfCWordInfo.h"
int main() 
{   CCtrlID str;
    str.type="gg";
	str.ID=6;
	str.original="sjlf";
	CWordInfo a(4,2,0,"вот","и","пришла","весна","а","ничего","так","не","поменялось","it's", "an",
		"intresting",6,"to","believe","in","god","cause","who","knows","what","this","can","be",
		"maybe", "the","childhood","of","me",24,"mine",& str);
int n;
char* s;
n=a.getID();
std::cout<<n;
int i;
std::cin>>i;
 return 0;
}

