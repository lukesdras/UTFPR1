#include <stdio.h>
#include <wiringPi.h>
#define AZUL 25 //GPIO 26
#define VERDE 21 //GPIO 5
#define AMARELO 22 //GPIO 6
#define VERMELHO 23 //GPIO 13

void BLINK_AZUL(){
	wiringPiSetup();
	pinMode(AZUL, OUTPUT);	
	digitalWrite(AZUL, HIGH);
	delay(500);
	digitalWrite(AZUL, LOW);
}
void MANTER_AZUL(){
	wiringPiSetup();
	pinMode(AZUL, OUTPUT);	
	digitalWrite(AZUL, HIGH);
}
void BLINK_VERDE(){
	wiringPiSetup();
	pinMode(VERDE, OUTPUT);	
	digitalWrite(VERDE, HIGH);
	delay(500);
	digitalWrite(VERDE, LOW);
}
void BLINK_AMARELO(){
	wiringPiSetup();
	pinMode(AMARELO, OUTPUT);	
	digitalWrite(AMARELO, HIGH);
	delay(500);
	digitalWrite(AMARELO, LOW);
}
void BLINK_VERMELHO(){
	wiringPiSetup();
	pinMode(VERMELHO, OUTPUT);	
	digitalWrite(VERMELHO, HIGH);
	delay(500);
	digitalWrite(VERMELHO, LOW);
}
void BLINK_VM_AM(){
	wiringPiSetup();
	pinMode(VERMELHO, OUTPUT);	
	pinMode(AMARELO, OUTPUT);
	digitalWrite(VERMELHO, HIGH);
	digitalWrite(AMARELO, HIGH);
	delay(80);
	digitalWrite(AMARELO, LOW);
	delay(80);
	digitalWrite(AMARELO, HIGH);
	delay(80);
	digitalWrite(AMARELO, LOW);
	delay(80);
	digitalWrite(AMARELO, HIGH);

	delay(500);
	digitalWrite(VERMELHO, LOW);
	digitalWrite(AMARELO, LOW);
}
