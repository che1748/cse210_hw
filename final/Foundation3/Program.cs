using System;

class Program
{
    static void Main(string[] args)
    {
        Address ad1 = new Address("129 Princeton Ct", "Rexburg", "ID", "US");
        Address ad2 = new Address("82 S Main St", "Bountiful", "UT","US");
        Address ad3 = new Address("525 Center St", "Rexburg", "ID", "US");

        Lecture et1 = new Lecture("Math 210", "This lecture is meant to help students appreciate calculus more", "7/20/2024","5:30 pm", ad1, "Dr. Willson", 50);
        Reception et2 = new Reception("Amy & Sam's wedding reception", "This event is to celebrate the marriage of Amy and Sam", "9/21/2024", "10:00 am", ad2, "Asmarriy921@gmail.com");
        Outdoor et3 = new Outdoor("Ultimate Frisbee", "We will gather and have fun playing Frisbee!!", "8/1/2024", "6:00 pm", ad3, "overcast");

        List<Event> eventList = new List<Event>()
        {et1, et2, et3};

        foreach (Event et in eventList)
        {
            Console.WriteLine("Standard Detail:");
            Console.WriteLine(et.GetStandardDetail());
            Console.WriteLine("\nShort description");
            Console.WriteLine(et.GetShortDescription());
            Console.WriteLine("\nFull Detail:");
            Console.WriteLine(et.GetFullDetail());
            Console.WriteLine("\n\n");
        }
        
    }
}