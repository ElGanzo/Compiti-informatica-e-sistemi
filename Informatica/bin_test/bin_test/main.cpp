#include <stdio.h>
#include <stdlib.h>
#include <conio.h>


#include "bin.h"

//   main
void main (void)
{
	CBin x(20);
	CBin y("1001100");
	CBin z;

	printf("Valore binario di x: %s\n\n", x.Get());
	printf("Valore binario di y: %s\n\n", y.Get());

	z = x+ y;
	printf("Valore binario di z: %s\n\n", y.Get());

	system("pause");
}