using System;
using System.Collections.Generic;
using System.Text;

namespace factory
{
    class RoboticChassis : RoboticPart
    {
        protected double _MAXbattery { get; }

        public RoboticArm Arm1 { get; set; }
        public RoboticArm Arm2 { get; set; }
        protected double Hours { get; set; }
        public RoboticChassis(double battery, string statusmessage) : base(statusmessage)
        {
            _MAXbattery = battery;
            _power = 85; //Wh

        }

        public void HourCalc()
        {
            double temp = _power;
            if (Arm1._statusmessage == "install")
            {
                temp += Arm1._power;
            }
            if (Arm2._statusmessage == "install")
            {
                temp += Arm2._power;
            }
            Hours = _MAXbattery / temp;
        }
        public override string ToString()
        {
            HourCalc();
            return string.Format("Chassis - {0}\nArm1 - {1}\nArm2 - {2}\nHours - {3}\nDrillArm1 - {4}\nDrillArm2 - {5}",
                _statusmessage,
                Arm1._statusmessage,
                Arm2._statusmessage,
                Hours,
                Arm1._drill == null ? "nothing" : Arm1._drill._statusmessage,
                Arm2._drill == null ? "nothing" : Arm2._drill._statusmessage);

        }


    }
}
