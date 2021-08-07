#ifdef WIN32
#include <windows.h>
#else
#include <unistd.h>
#endif
#include "initDB.cpp"
void delay(int ms){
#ifdef WIN32
  Sleep(ms);
#else
  usleep(ms*1000);
#endif
}

#include "MFRC522.h"

int main(){
  
  MFRC522 mfrc;
  dadosDB();
  mfrc.PCD_Init();

  while(1){
    
    // Look for a card
    if(!mfrc.PICC_IsNewCardPresent()){
     
      continue;
}
    if( !mfrc.PICC_ReadCardSerial()){
      
      continue;
}
    // Print UID
    for(byte i = 0; i < mfrc.uid.size; ++i){
      if(mfrc.uid.uidByte[i] < 0x10){ // se for menor q 10h add 0 atras
	printf(" 0");
	printf("%X",mfrc.uid.uidByte[i]);
  
      }
      else{
	printf(" "); // adiciona espaço entre os hexadecimais
	printf("%X", mfrc.uid.uidByte[i]);
      }
      
    }
    printf("\n");
    delay(1000);
  }
  printf("saiu");
  return 0;
}
