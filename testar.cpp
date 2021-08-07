#include <stdio.h>
#include "Read2.cpp"
#include <string.h>
#include <stdlib.h> //atoi ou strol

const char * readtag(char * uid){
	int x=0;
	int inteiro=0;
	//char uid[500];
	int aux[10];
	memset (aux,0,10); //setar tudo 0
	for (int y=0; y<4; y++){
		x=lertag(y);
		aux[y]=x;
		sprintf(uid, "%X %X %X %X", aux[0], aux[1], aux[2], aux[3]);
		//printf("%s", uid);
	}

	return uid;

}
