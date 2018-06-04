using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using SQLCommunication;

namespace Prosjekt
{
    abstract class Alarm
    {
        protected bool state;
        protected bool oldState;
        public string AlarmDescription { get; protected set; }
        public string AlarmTitle { get { return "Alarm"; } }
        public AlarmtypesEnum AlarmType { get; protected set; }
    }

    class AlarmLowTemperature : Alarm
    {
        // This class depends on that Properties is set to raise event for low temperature alarm
        protected double lowTempLimit;
        protected double temperature;

        public delegate void LowTemperatureEventHandler(object source, EventArgs args);
        public event LowTemperatureEventHandler LowTemperatureAlarm;

        // Constructor
        public AlarmLowTemperature(double lowTempLimit)
        {
            AlarmType = AlarmtypesEnum.LowTemp;
            AlarmDescription = SQL.GetDescription(AlarmType);
            this.lowTempLimit = lowTempLimit;
        }

        protected void OnLowTemperatureAlarm()
        {
            if (LowTemperatureAlarm != null)
            {
                LowTemperatureAlarm(this, EventArgs.Empty);
            }
        }

        public double LowTemperatureLimit
        {
            get { return lowTempLimit; }
            set
            {
                lowTempLimit = value;
                oldState = state;
                if (temperature > lowTempLimit)
                {
                    state = false;
                }
                else if (oldState == false)
                {
                    state = true;
                    OnLowTemperatureAlarm();
                }
            }
        }

        public double Temperature
        {
            get { return temperature; }
            set
            {
                temperature = value;
                oldState = state;
                if (temperature > lowTempLimit)
                {
                    state = false;
                }
                else if (oldState == false)
                {
                    state = true;
                    OnLowTemperatureAlarm();
                }
            }
        }
    }

    class AlarmHighTemperature : Alarm
    {
        // This class depends on that Properties is set to raise event for high temperature alarm
        protected double highTempLimit;
        protected double temperature;
        public delegate void HighTemperatureEventHandler(object source, EventArgs args);
        public event HighTemperatureEventHandler HighTemperatureAlarm;

        // Constructor
        public AlarmHighTemperature (double highTempLimit)
        {
            AlarmType = AlarmtypesEnum.HighTemp;
            AlarmDescription = SQL.GetDescription(AlarmType);
            this.highTempLimit = highTempLimit;
        }

        protected void OnHighTemperatureAlarm()
        {
            if (HighTemperatureAlarm != null)
            {
                HighTemperatureAlarm (this, EventArgs.Empty);
            }
        }
        public double Temperature
        {
            get { return temperature; }
            set
            {
                temperature = value;
                oldState = state;
                if (temperature < highTempLimit)
                {
                    state = false;
                }
                else if (oldState == false)
                {
                    state = true;
                    OnHighTemperatureAlarm();
                }
            }
        }

        public double HighTemperatureLimit
        {
            get { return highTempLimit; }
            set
            {
                highTempLimit = value;
                oldState = state;
                if (temperature < highTempLimit)
                {
                    state = false;
                }
                else if (oldState == false)
                {
                    state = true;
                    OnHighTemperatureAlarm();
                }
            }
        }
    }

    class AlarmMotion : Alarm
    {
        // This class raises event when AlarmActivated property is set to true
        public bool AlarmActivated { get; set; }

        public delegate void MotionAlarmEventHandler(object sender, EventArgs args);
        public event MotionAlarmEventHandler MotionAlarm;
        
        // Constructor
        public AlarmMotion()
        {
            AlarmType = AlarmtypesEnum.Motion;
            AlarmDescription = SQL.GetDescription(AlarmType);

        }

        protected void OnMotionAlarm()
        {
            if (MotionAlarm != null)
            {
                MotionAlarm (this, EventArgs.Empty);
            }
        }

        public bool InAlarm
        {
            get { return state; }
            set
            {
                oldState = state;
                state = value;
                if (AlarmActivated && oldState == false && state == true)
                {
                    OnMotionAlarm();
                }
            }
        }
    }

    class AlarmNoCharge : Alarm
    {
        // This class subscribes to System Event PowerModeChanged which is a static propery.
        // Thats why the descructor is used
        public bool PowerConnected { get; protected set; }

        public delegate void PowerStatusChangedEventHandler (object source, EventArgs args);
        public event PowerStatusChangedEventHandler PowerStatusChanged;
        public delegate void NoChargeAlarmEventHandler(object source, EventArgs args);
        public event NoChargeAlarmEventHandler NoChargeAlarm;

        // Constructor
        public AlarmNoCharge()
        {
            AlarmType = AlarmtypesEnum.NoCharge;
            AlarmDescription = SQL.GetDescription(AlarmType);
            SystemEvents.PowerModeChanged += PowerChange;
            CheckPowerLineStatus();

            // Displays warning message at startup if power is not connected
            if (!PowerConnected) MessageBox.Show(AlarmDescription, AlarmTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void CheckPowerLineStatus()
        {
            switch (SystemInformation.PowerStatus.PowerLineStatus)
            {
                case PowerLineStatus.Online:
                    PowerConnected = true;
                    break;
                default:
                    PowerConnected = false;
                    break;
            }
        }
        private void PowerChange(object sender, PowerModeChangedEventArgs ev)
        {
            oldState = state;
            CheckPowerLineStatus();
            OnPowerStatusChanged();

            if (oldState == false && PowerConnected == false)
            {
                state = true;
                OnNoChargeAlarm();
            }
        }
            
        protected void OnPowerStatusChanged ()
        {
            if (PowerStatusChanged != null)
            {
                PowerStatusChanged(this, EventArgs.Empty);
            }
        }
            
        protected void OnNoChargeAlarm()
        {
            if (NoChargeAlarm != null)
            {
                NoChargeAlarm(this, EventArgs.Empty);
            }
        }

        // Destructor
        // Quote from MSDN: "Because this is a static event, you must detach your event 
        //   handlers when your application is disposed, or memory leaks will result."
        ~AlarmNoCharge()
        {
            SystemEvents.PowerModeChanged -= PowerChange;
        }
    }

    class AlarmLowBattery : Alarm
    {
        // This class create a timer to update the CurrentBatteryPercent Property ever 20 sec
        public double CurrentBatteryPercent { get; protected set; }
        public double LowBatteryLimit { get; set; }
        public delegate void LowBatteryAlarmEventHandler(object source, EventArgs args);
        public event LowBatteryAlarmEventHandler LowBatteryAlarm;

        // Constructor
        public AlarmLowBattery(double lowBatteryPercent)
        {
            AlarmType = AlarmtypesEnum.LowBattery;
            AlarmDescription = SQL.GetDescription(AlarmType);
            LowBatteryLimit = lowBatteryPercent;

            // Creates timer and ChechBatteryPercent method to tick-event
            Timer batteryUpdate = new Timer();
            batteryUpdate.Interval = 20000;
            batteryUpdate.Start();
            batteryUpdate.Tick += CheckBatteryPercent;

            CheckBatteryPercent(null, EventArgs.Empty);
            
            // Displays warning at startup if batterypercent is lower then limit
            if (CurrentBatteryPercent <= LowBatteryLimit) MessageBox.Show(AlarmDescription, AlarmTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        protected void CheckBatteryPercent(object sender, EventArgs e)
        {
            CurrentBatteryPercent = Math.Round( (SystemInformation.PowerStatus.BatteryLifePercent * 100), 1);
            oldState = state;
            if (CurrentBatteryPercent > LowBatteryLimit)
            {
                state = false;
            }
            else if (oldState == false)
            {
                state = true;
                OnLowBatteryAlarm();
            }
        }

        protected void OnLowBatteryAlarm()
        {
            if (LowBatteryAlarm != null)
            {
                LowBatteryAlarm(this, EventArgs.Empty);
            }
        }
    }

    class AlarmComFault : Alarm
    {
        // This class could only raise an event when the arduino have been connected to the computer.
        // If it isn't connected at startup, it should not trigger alarmevent.
        protected bool arduinoConnected;
        protected bool startup;
        public delegate void ComFaultAlarmEventhandler(object sender, EventArgs args);
        public event ComFaultAlarmEventhandler ComFaultAlarm;

        // Constructor
        public AlarmComFault()
        {
            AlarmType = AlarmtypesEnum.ComFault;
            AlarmDescription = SQL.GetDescription(AlarmType);
            startup = true;
        }

        protected void OnComFaultAlarm()
        {
            if (ComFaultAlarm != null)
            {
                ComFaultAlarm(this, EventArgs.Empty);
            }
        }

        public bool ArduinoConnected
        {
            get { return arduinoConnected; }
            set
            {
                arduinoConnected = value;
                oldState = state;
                if (arduinoConnected)
                {
                    startup = false;
                    state = false;
                }
                else if (!arduinoConnected && oldState == false && startup == false)
                {
                    state = true;
                    OnComFaultAlarm();
                }
            }
        }
    }

}
