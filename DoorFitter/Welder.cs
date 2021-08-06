using System;

namespace Design_Patterns.DoorFitter
{
    class Welder : IDoorFittingExpert
    {
        public void GetDescription()
        {
            Console.WriteLine("I can only fit iron doors");
        }
    }
}