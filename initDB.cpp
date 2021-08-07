#include </usr/include/mariadb/mysql.h>
#include <stdio.h>

MYSQL conexao;
MYSQL_RES *result;
MYSQL_ROW row;
void dadosDB(void){

    mysql_init(&conexao);
    if(mysql_real_connect(&conexao, "database-1.c9rst2cteqor.sa-east-1.rds.amazonaws.com", "lukesdras", "gostoso12", "Cadastro", 3306, NULL, 0)){
		printf("Conectado com sucesso no DB \n");
		} 
	else {
	        printf ("Impossivel conectar no banco \n");
		}
	
}
