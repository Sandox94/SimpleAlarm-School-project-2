
//--------------------//           // Date: 21.04.2016
#ifndef Csharp_Command_h
#define Csharp_Command_h

class CommandClass
{
    public:
    CommandClass();
      void CommandSetup();
      char CommandCode();
      void DataFormat();
      void DataFlush();
};

extern CommandClass command;

#endif

