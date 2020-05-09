using System;
using System.Collections.Generic;
using System.Text;

namespace factory
{
    class Drill : RoboticArm
    {
        public Drill(string statusmessage,int size) : base(statusmessage,size)
        {
            _power = 25;
            _size = size;
        }
    }
}
