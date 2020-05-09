using System;
using System.Collections.Generic;
using System.Text;

namespace factory
{
    class Hangar
    {
        public List<RoboticPart> Storage { get; set; }
        public void Write()
        {
            foreach(var x in Storage)
            {
                Console.WriteLine(x);
            }
        }
        public void OneAdd()
        {
            Storage.Add(new RoboticChassis(20, "install"));
        }
    }
}
