#include "bin.h"
#include <memory.h>
#include <string.h>

CBin::CBin(int n)
{
	memset(cifra, 0, MAX);
	Converti(n);
}

CBin::CBin(char* sn)
{
	memset(cifra, 0, MAX);
	this->ne = strlen( sn );

	for( int i=0; i<ne; i++ )
		cifra[i] = sn[ne-i-1] -'0';
}

CBin::~CBin()
{
}

void CBin::Converti(int n)
{
	// cerco il numero di bit della conversione
	int k = 1;
	ne = 0;
	/*
	while( k < n )
	{
		k = k*2;
		ne++;
	}
*/
	// conversione in binario
	//k = ne-1;
	while( n > 0 )
	{
		cifra[k] = n % 2;
		n = n/2;
		k--;		
	}
}

char* CBin::Get(void)
{
	byte k = ne - 1;
	for( int i=0; i<ne; i++ )
		s[i] = cifra[k--] + '0';

	s[ne] = 0;		// fine stringa

	return s;
}

CBin CBin::operator+(const CBin& x)
{
	byte c = 0;		// bit di curry
	byte somma;		// utilizzando l'operatore bit a bit && (and)
	CBin app;
	int i;
	byte max = ne > x.ne ? ne : x.ne;
	for( i=0; i<max; i++ )
	{
		somma = cifra[i] + x.cifra[i] + c;

		if( somma > 1 )
		{
			app.cifra[i] = somma -2;
			c = 1;
		}
		else
		{
			app.cifra[i] = somma;
			c = 0;
		}
	}
	app.ne = i;

	if( c > 0 )
	{
		app.cifra[i] = c;
		app.ne++;
	}

	return app;
}