#include <stdio.h>
#include <string.h>
#include </usr/include/mariadb/mysql.h>
#include "testar.cpp"
#include "initDB.cpp"
#include "gettime.cpp"
#include "led.cpp"
int main(int argc, char *argv[]){

		MANTER_AZUL();
	    char X[500]; //auxiliar
		memset (X,0,500); //setar tudo 0
		char temp[255];
		memset (temp,0,255); //setar tudo 0
	    char temp2[255];
		memset (temp2,0,255);//setar tudo 0
	    char temp3[255];
		memset (temp3,0,255);//setar tudo 0
		char linhas[255];
		memset (linhas,0,255);//setar tudo 0
		char capacidade[255];
		memset (capacidade,0,255);//setar tudo 0
		const char *tag;
		//memset (tag,0,255);
	    //printf("droga");
	    while(1){
		int i = 0;
		char *var;
		
		delay(1000);
		dadosDB();
		memset (X,0,500); //setar tudo 0
		memset (temp,0,255); //setar tudo 0
		memset (temp2,0,255);//setar tudo 0
		memset (temp3,0,255);//setar tudo 0
		//memset (tag,0,255);
		tag=readtag(X);
		std::cout << "currentDate()=" << currentDate() << std::endl;
		std::cout << "currentTime()=" << currentTime() << std::endl;
		char Data[500];
		memset (Data,0,500); //setar tudo 0
		sprintf(Data, "%s", currentDate());
		//getchar();
			sprintf(temp, "SELECT * FROM PESSOAS WHERE TAG LIKE '%%%s%%'", tag); //Dois % pois C interpreta % como comando
			if(mysql_query(&conexao, temp)){
			printf("ALUNO NAO EXISTE \n");
			}
			else{
				result = mysql_store_result(&conexao);
				if(result){
					unsigned int fields = mysql_num_fields(result);
					unsigned int linhas2=0;
					const char* capacidade2 = "101";
					    row = mysql_fetch_row(result);
						if(row!=0){
								sprintf(linhas, "SELECT * FROM PESSOAS WHERE ID_BLOCO = 3");
								sprintf(capacidade, "SELECT CAPACIDADE FROM BLOCOS WHERE ID = 3");
								if (&conexao != NULL){
									mysql_query(&conexao, linhas);
									result = mysql_store_result(&conexao);  // armazena resultado
									linhas2 = mysql_num_rows(result); // tira o numero de linhas desse resultado
								}
								if (&conexao != NULL){
									mysql_query(&conexao, capacidade);
									result = mysql_store_result(&conexao);  // armazena resultado
									row = mysql_fetch_row(result);
									capacidade2=row[0];// Como sempre retornará só um valor, indico a primeira linha [0]
								}								
								int capacidadeint = atoi(capacidade2); //converte char para int
								if (linhas2>=capacidadeint-1){
									printf("Capacidade maxima atingida %i / %i  (acender LED amarelo e vermelho?) \n \n",linhas2, capacidadeint);
									BLINK_VM_AM();
								}
								else{							 
									sprintf(temp2, "INSERT INTO LOG(ID, DATA, HORA, ACAO, ID_BLOCO, ID_PESSOA ) values ('0', '%s', '%s', 'IN', 3, '%s')",  Data, currentTime(), tag);
									sprintf(temp3, "UPDATE PESSOAS SET ID_BLOCO = 3 WHERE TAG = '%s'", tag);//

									if (&conexao != NULL){
										mysql_query(&conexao, temp3);
										printf("Ok! \n");
									}
									if (&conexao != NULL){
										mysql_query(&conexao, temp2);
									}

								
								BLINK_VERDE();
								printf("Liberado ok\n %s (LED VERDE)\n \n ", temp2);
								printf("\n%s \n \n ", temp3);
								printf("Numero de pessoas no bloco :%i / %i  \n", linhas2, capacidadeint);
								}
							 //inserir no LOG que aluno entrou
						}
						else{
							BLINK_VERMELHO();
							printf("Aluno nao cadastrado (LED VERMELHO) \n");	
						}

			}
					
		else printf("DEU ERRO");
				
	}
	//	else printf("banco com problema");
	}
}
