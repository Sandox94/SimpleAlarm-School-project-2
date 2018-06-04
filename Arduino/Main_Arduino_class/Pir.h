
//--------------------//           // Date: 21.04.2016
#ifndef Pir_h
#define Pir_h

class PirClass 
{
    public:
    PirClass();
    void PirSetup();
    void PirCalibration( int calibrationTime);
    static  String PirSensor();
};

extern PirClass pir;

#endif
