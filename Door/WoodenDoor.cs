using System;

namespace Design_Patterns.Door
{
    public class WoodenDoor : IDoor
    {
        public void GetDescription()
        {
            Console.WriteLine("I am a wooden door!");
        }
    }
}