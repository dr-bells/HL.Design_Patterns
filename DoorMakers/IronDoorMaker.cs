using System;

namespace Design_Patterns.DoorMakers
{
    public class IronDoorMaker : DoorMakingProcess
    {
        public void MakeDoor()
        {
            Console.WriteLine("We are in the process of making an iron door now.");
        }
    }
}