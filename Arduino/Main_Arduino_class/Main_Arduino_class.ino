

//--------------------Include-----------------------//              // Date: 21.04.2016
#include "Arduino.h"
#include "Csharp_Command.h"
#include "Temperatur.h"
#include "Pir.h"
#include "LCD.h"
#include "Buzzer.h"

bool DefaultTemperatureShow = false;

//--------------------Setup-------------------------//              // Date: 21.04.2016

void setup() {
  // put your setup code here, to run once:
 Serial.begin(9600);
  temperature.TemperatureSetup();
  lcd.LCDSetup();
  pir.PirSetup();
 // pir.PirCalibration(30);
  buzzer.BuzzerSetup();
}


//------------------Main---------------------------//              // Date: 21.04.2016
void loop() {
  // put your main code here, to run repeatedly:


if(DefaultTemperatureShow)
{
  lcd.Default();
}

if(Serial.available() > 0)
{
  char Comp = command.CommandCode();
  
switch (Comp)
{
    case '1':       //DEFALUT
    DefaultTemperatureShow = true;
    buzzer.BuzzerReset();
    command.DataFormat();
    break;

    case'2':        // ALARM ON
    DefaultTemperatureShow = false;
    command.DataFormat();
    lcd.DeleteLine();
    buzzer.BuzzerOn();
    lcd.PrintLine("Alarm On");
    break;

}

Comp = 0;
}
}
