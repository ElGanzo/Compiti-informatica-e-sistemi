#pragma once

#define MAX 32

typedef unsigned char byte;

class CBin
{
	byte cifra[MAX];
	byte ne;
	char s[MAX+1];

public:

	CBin(int n = 0);
	CBin(char* sn);		// stringa del numero in binario
	~CBin(void);

	CBin operator+(const CBin& x);	// (qualcosa) + x

	char* Get(void);

protected:
	void Converti( int n );
};