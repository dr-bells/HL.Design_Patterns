using System;

namespace Design_Patterns.DoorFitter
{
    class Carpenter : IDoorFittingExpert
    {
        public void GetDescription()
        {
            Console.WriteLine("I can only fit wooden doors");
        }
    }
}