using System;

namespace Design_Patterns.DoorFitter
{
    class Carpenter : IDoorFittingExpert
    {
        public void GetDescription()
        {
            Console.WriteLine("I am a Carpenter and l can only fit wooden doors");
        }
    }
}