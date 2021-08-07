#include <stdio.h>
#include <string.h>
#include </usr/include/mariadb/mysql.h>
#include "testar.cpp"
#include "initDB.cpp"

int main(int argc, char *argv[]){
		
		
	    char X[500]; //auxiliar
		memset (X,0,500); //setar tudo 0
		char temp[255];
		memset (temp,0,255); //setar tudo 0
	    
	    //printf("droga");
	    while(1){
		delay(1000);
		
		dadosDB();
		memset (X,0,500); //setar tudo 0
		memset (temp,0,255); //setar tudo 0
		
		if (&conexao != NULL){
			
			sprintf(temp, "INSERT INTO CATCH_TAG(id, tag ) values('0', '%s');", readtag(X));
			mysql_query(&conexao, temp);
			printf("%s \n", temp);
		
	}
		else printf("banco com problema");
	}
}
