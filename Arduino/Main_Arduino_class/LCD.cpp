#include "Arduino.h"
#include "LCD.h"
#include "Temperatur.h"
#include <LiquidCrystal.h>
LiquidCrystal LCD(12,11,5,4,6,2);                                                       


LCDClass::LCDClass() {}

void LCDClass::LCDSetup()                                                                // Set columns and row                                                                  // Date: 21.04.2016
{
  LCD.begin(16,2);
}

void LCDClass::MaxTemperatureAndPir()                                                    // Print out temperature when its to High and Pir is On after user choice               // Date: 21.04.2016
{
  String Temp = String(temperature.TemperatureSensor(),2);
  DeleteLine();
  PrintLine("T-High: ");
  PrintLine(Temp);
  PrintLine(" C");
  LCD.setCursor(0,1);
  PrintLine("Motion detected");
  LCD.setCursor(0,0);
}
void LCDClass::MinTemperatureAndPir()                                                   // Print out temperature when its to Low and Pir is On after user choice                // Date: 21.04.2016
{
  String Temp = String(temperature.TemperatureSensor(),2);
  DeleteLine();
  PrintLine("T-Low: ");
  PrintLine(Temp);
  PrintLine(" C");
  LCD.setCursor(0,1);
  PrintLine("Motion detected");
  LCD.setCursor(0,0);
}

void LCDClass::MaxTemperature()                                                       // Print out temperature when its to High after user choice                                 // Date: 21.04.2016
{
  String Temp = String(temperature.TemperatureSensor(),2);
  
  DeleteLine();
  PrintLine("Temp High: ");
  LCD.setCursor(0,1);
  PrintLine(Temp);
  PrintLine(" C");
  LCD.setCursor(0,0);
}

void LCDClass::MinTemperature()                                                       // Print out temperature when its to Low after user choice                                // Date: 21.04.2016
{
  String Temp = String(temperature.TemperatureSensor(),2);
  
  DeleteLine();
  PrintLine("Temp Low: ");
  LCD.setCursor(0,1);
  PrintLine(Temp);
  PrintLine(" C");
  LCD.setCursor(0,0);
}

void LCDClass::Pir()                                                                 // Print out Pir when its On after user choice                                             // Date: 21.04.2016
{
  DeleteLine();
  PrintLine("Motion detected");
}

void LCDClass::Default()                                                            // Print out temperature.                                                                  // Date: 21.04.2016  
{
  String Temp = String(temperature.TemperatureSensor(),2);
  DeleteLine();
  PrintLine(Temp);
  PrintLine(" degree C");
  delay(500);
 
}

void LCDClass:: PrintLine(String Line)                                              // Print tekst                                                                               // Date: 21.04.2016
{
  LCD.print(Line);
}

void LCDClass:: DeleteLine()                                                        // Delete tekst
{
  LCD.clear();
}
LCDClass lcd = LCDClass();
