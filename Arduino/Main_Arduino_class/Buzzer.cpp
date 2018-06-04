#include "Arduino.h"
#include "Buzzer.h"

const int BuzzPin = 7;                      // Pin                                    // Date: 21.04.2016
int count = 0;
BuzzerClass::BuzzerClass(){}

void BuzzerClass::BuzzerSetup()             // Set buzzer pin and output              // Date: 21.04.2016
{
  pinMode(BuzzPin, OUTPUT);
}

void BuzzerClass:: BuzzerOn()               // Set pin, frequency and duration        // Date: 21.04.2016
{
  if( count < 1)
  {
    tone(BuzzPin, 1000, 2000);
    count++;
  }
  
}

void BuzzerClass::BuzzerReset()
{
  count = 0;
}


BuzzerClass buzzer = BuzzerClass();

