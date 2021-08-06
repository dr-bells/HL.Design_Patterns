using System;

namespace Design_Patterns.Door
{
    class IronDoor : IDoor
    {
        public void GetDescription()
        {
            Console.WriteLine("I am a iron door");
        }
    }
}