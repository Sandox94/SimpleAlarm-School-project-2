#include "Arduino.h"
#include "Pir.h"
#include "LCD.h"

const int PirPin = 13;

PirClass::PirClass() {}

void PirClass::PirSetup()                                // Set Pir                                          // Date: 21.04.2016
{
 pinMode(PirPin, INPUT);
 digitalWrite(PirPin, LOW);
}
void PirClass::PirCalibration(int CalibrationTime)      // Start Calibration                                // Date: 21.04.2016
{
  lcd.DeleteLine();
  lcd.PrintLine("Calibrate Sensor");
  delay(5000);
  lcd.DeleteLine();
  for(int i = 0; i< CalibrationTime; i++)
  {
   lcd.PrintLine(".");
   delay(5000);
  }
  lcd.DeleteLine();
  lcd.PrintLine("Done");
  lcd.DeleteLine();
  lcd.PrintLine("Welcome");
}

String PirClass::PirSensor()                            // Return state of alarm                            // Date: 21.04.2016
{
  if(digitalRead(PirPin) == HIGH)
  {
    return "ON";
  }
  else
  {
    return "OFF";
  }
}


PirClass pir = PirClass();
