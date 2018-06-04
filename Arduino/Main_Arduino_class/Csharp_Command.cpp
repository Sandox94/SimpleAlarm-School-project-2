#include "Arduino.h"
#include "Csharp_Command.h"
#include "Pir.h"
#include "Temperatur.h"

CommandClass::CommandClass() {}

void CommandClass:: CommandSetup()
{
//Empty  
}

char CommandClass:: CommandCode()                                       // Read command code from program                     // Date: 21.04.2016
{
  char pc = Serial.read();
  return pc;
}
void CommandClass::DataFormat()                                         // Send data value to program in C-Sharp              // Date: 21.04.2016
{
  String Temp = String(temperature.TemperatureSensor(),2);
  String Pir = pir.PirSensor();
  
  Serial.print("#P:");
  Serial.print(Pir);
  Serial.print("\t");
  Serial.print(" #T:");
  Serial.println(Temp);
}
void CommandClass::DataFlush()
{

  while(Serial.available())
  Serial.read();
}



CommandClass command = CommandClass();
