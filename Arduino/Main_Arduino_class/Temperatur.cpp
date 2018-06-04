#include "Arduino.h"
#include "Temperatur.h"
#include "LCD.h"

const int SensorPin = A0;
unsigned long PreMillisA = 0;
long OnTimeA = 750;
long OffTimeA = 1000;

const int numReadings = 10;
int readings[numReadings];
int readIndex = 0;
int total = 0;
int average = 0;


TemperatureClass::TemperatureClass() {}                                      // Initialize all reading to 0                              // Date: 21.04.2016


void TemperatureClass::TemperatureSetup()
{
  for(int thisReading = 0; thisReading < numReadings; thisReading++)
{
  readings[thisReading] = 0;
}
}
float TemperatureClass::TemperatureSensor()                                 // Return Temperature value                                 // Date: 21.04.2016
{
  total = total - readings[readIndex];
int SensorVal = analogRead(SensorPin);
float Voltage = (SensorVal/ 1024.0) * 5.0;
float Temperature = (Voltage - .5) *100;
readings[readIndex] = Temperature;
total = total + readings[readIndex];
readIndex = readIndex +1;

if(readIndex >= numReadings)
{
  readIndex = 0;
}
average = total / numReadings;


return average;
}

void TemperatureClass::TemperatureView(unsigned long CurrentMillis)     // View temperature value on LCD screen                        // Date: 21.04.2016
{
  if(CurrentMillis - PreMillisA >= OnTimeA)
  {
    PreMillisA = CurrentMillis;
  }
  else if(CurrentMillis - PreMillisA >= OffTimeA)
  {
    lcd.DeleteLine();
    String Temp = String(TemperatureSensor(),2);
    lcd.PrintLine(Temp);
    lcd.PrintLine(" degrees C");
  }
}


TemperatureClass temperature = TemperatureClass();
