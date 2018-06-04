using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLCommunication;

namespace Prosjekt
{
    public partial class Settings : Form
    {
        //ProgramParameter programParameter = new ProgramParameter();


        public Settings()
        {
            InitializeComponent();

            lowTempLimitUpDown.Value = Convert.ToDecimal(SQL.GetAlarmLimit(AlarmtypesEnum.LowTemp));
            highTempLimitUpDown.Value = Convert.ToDecimal(SQL.GetAlarmLimit(AlarmtypesEnum.HighTemp));
            lowBatteryLimitUpDown.Value = Convert.ToDecimal(SQL.GetAlarmLimit(AlarmtypesEnum.LowBattery));

            readIntervalUpDown.Value = Home.ProgramParameter.ReadInterval;
            logIntervalUpDown.Value = Home.ProgramParameter.LogInterval;
            
        }

        private void lowTempLimitUpDown_ValueChanged(object sender, EventArgs e)
        {
            SQL.UpdateAlarmLimit(AlarmtypesEnum.LowTemp, Convert.ToDouble(lowTempLimitUpDown.Value));
        }

        private void highTempLimitUpDown_ValueChanged(object sender, EventArgs e)
        {
            SQL.UpdateAlarmLimit(AlarmtypesEnum.HighTemp, Convert.ToDouble(highTempLimitUpDown.Value));
        }

        private void lowBatteryLimitUpDown_ValueChanged(object sender, EventArgs e)
        {
            SQL.UpdateAlarmLimit(AlarmtypesEnum.LowBattery, Convert.ToDouble(lowBatteryLimitUpDown.Value));
        }

        private void cboReadInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            int interval;
            //bool resultIntervalConvert = int.TryParse(cboReadInterval.Text, out interval);
            //if (resultIntervalConvert) ProgramParameter. = interval * 1000;
            //else MessageBox.Show("Ugyldig verdi");
        }


        private void readIntervalUpDown_ValueChanged(object sender, EventArgs e)
        {
            Home.ProgramParameter.ReadInterval = (int)(readIntervalUpDown.Value);
        }

        private void logIntervalUpDown_ValueChanged(object sender, EventArgs e)
        {
            Home.ProgramParameter.LogInterval = (int)(logIntervalUpDown.Value);
        }
    }
}
