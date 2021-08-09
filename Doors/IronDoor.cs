using System;

namespace Design_Patterns.Doors
{
    class IronDoor : IDoor
    {
        public void GetDescription()
        {
            Console.WriteLine("This is an iron door!");
        }
    }
}