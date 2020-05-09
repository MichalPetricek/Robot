using System;
using System.Collections.Generic;
using System.Text;

namespace factory
{
    class RoboticArm : RoboticPart

    {
        protected internal Drill _drill { get; set; }
        protected internal Hammer _hammer { get; set; }
        protected int _size;
        public RoboticArm(string statusmessage, int size) : base(statusmessage)
        {
            _power = 50; //Wh
            if (_drill != null) { DrillPower(); }
            if (_hammer != null) { HammerPower(); }
            _size = size;
        }
        public void SetDrill(Drill drill)
        {
            _drill = drill;
            
        }
        public void SetHammmer(Hammer hammer)
        {
            _hammer = hammer;
        }
        public void DrillPower()
        {
            if (_drill._statusmessage == "install")
            {
                _power += _drill._power;
            }

        }

        public void HammerPower()
        {
            if (_hammer._statusmessage == "install")
            {
                _power += _hammer._power;
            }
        }
    }
}
