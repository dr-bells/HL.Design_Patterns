using System;

namespace Design_Patterns.Doors
{
    public class WoodenDoor : IDoor
    {
        public void GetDescription()
        {
            Console.WriteLine("This is a wooden door!");
        }
    }
}