using System;
using System.Collections.Generic;
using System.Text;

namespace factory
{
    abstract class RoboticPart
    {
        public int _power;
        public string _statusmessage { get; set ; }

        protected RoboticPart(string statusmessage)
        {
            _statusmessage = statusmessage;
        }
        


          

    }
}
