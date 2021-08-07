#include <iostream>
#include <string.h>
#include <stdio.h>
#include <time.h>
char buf[80];
char buf2[80];
char * currentDate() {
	time_t	now = time(0);
	struct tm tstruct;
	
	tstruct = *localtime(&now);
	strftime(buf, sizeof(buf), "%d-%m-%Y", &tstruct);
	return buf;
}
char * currentTime() {
	time_t	now = time(0);
	struct tm tstruct;
	
	tstruct = *localtime(&now);
	strftime(buf2, sizeof(buf), "%X", &tstruct);
	return buf2;
}
