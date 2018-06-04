
//--------------------//           // Date: 21.04.2016
#ifndef Temperature_h
#define Temperature_h

class TemperatureClass
{
    public:
    TemperatureClass();
    void TemperatureSetup();
    static float TemperatureSensor();
    void TemperatureView(unsigned long CurrentMillis);
};

extern TemperatureClass temperature;

#endif
