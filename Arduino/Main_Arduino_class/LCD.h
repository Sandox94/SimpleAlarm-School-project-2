
//--------------------//           // Date: 21.04.2016
#ifndef LCD_h
#define LCD_h

class LCDClass 
{
    public:
      LCDClass();
      void LCDSetup();
      void MaxTemperatureAndPir();
      void MinTemperatureAndPir();
      void MaxTemperature();
      void MinTemperature();
      void Pir();
      void Default();
      void PrintLine(String line);
      void DeleteLine();
};

extern LCDClass lcd;

#endif
