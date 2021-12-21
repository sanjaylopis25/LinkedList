using System;

namespace LinkedList1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Datastructure");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            //list.InsertAtParticularPosition(2,30);
            list.Display();
            Console.ReadKey();
        }
    }
}
