using System;

namespace Design_Patterns.DoorMakers
{
    public class IronDoorMaker : DoorMakingProcess
    {
        // This is where we can put the logic of creating the door.
        //Cutting the iron, welding, etc
        public void MakeDoor()
        {
            Console.WriteLine("We are in the process of making an iron door now......");
        }
    }
}