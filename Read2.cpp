#include <unistd.h>
#include "MFRC522.h"
#include <stdio.h>
#include <string.h>
MFRC522 mfrc;
void delay(int ms){

  usleep(ms*1000);

}
int lertag(int Bianca){
 
 mfrc.PCD_Init();
 int uid[4];
 int decimal;
 
 while(1){
    
    // Look for a card
    if(!mfrc.PICC_IsNewCardPresent())
		continue;
	


    if(mfrc.PICC_ReadCardSerial()){
		     for(byte i = 0; i < mfrc.uid.size; ++i){

			decimal=mfrc.uid.uidByte[i];
			uid[i]=decimal;
		
						
			}
    break;



      
    }
    
    delay(1000);
 }
  return uid[Bianca];
}
