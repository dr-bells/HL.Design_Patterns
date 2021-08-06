using System;

namespace Design_Patterns.DoorFitter
{
    class Welder : IDoorFittingExpert
    {
        public void GetDescription()
        {
            Console.WriteLine("I am a Welder and l can only fit iron doors");
        }
    }
}