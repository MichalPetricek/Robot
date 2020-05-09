using System;

namespace factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var chas = new RoboticChassis(1000, "Mark1") { Arm1 = new RoboticArm("install", 10), Arm2 = new RoboticArm("install", 10) { _drill = new Drill("install", 5) }};
            Console.WriteLine(chas);
            Console.WriteLine(chas._power);
        }
    }
}
