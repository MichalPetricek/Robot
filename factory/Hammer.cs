using System;
using System.Collections.Generic;
using System.Text;

namespace factory
{
    class Hammer :RoboticArm
    {
        public  Hammer(string statusmessage,int size) : base(statusmessage,size)
        {
            _power = 12;
            _size = size;
        }

    }
}
