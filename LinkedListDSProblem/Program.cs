using System;
using System.Collections.Generic;

namespace LinkedListDSProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Data Structure Problem.");
            //UC1
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            

            //UC2 inserting new node before an existing node
            Console.WriteLine("\n=================================================================");
            LinkedList list2 = new LinkedList();
            list2.Add(70);
            list2.AddBefore(30);
            list2.AddBefore(56);
            list2.Display();

            //UC3 inserting new node after an existing node
            Console.WriteLine("\n=================================================================");
            LinkedList list3 = new LinkedList();
            list3.Add(56);
            list3.Add(30);
            list3.Add(70);
            list3.Display();

            //UC4 inserting new node in between existing nodes
            Console.WriteLine("\n=================================================================");
            LinkedList list4 = new LinkedList();
            list4.Add(56);
            list4.Add(70);
            list4.InsertAtParticularPosition(2, 30);
            list4.Display();

            //UC5 deleting first node of the linked list
            Console.WriteLine("\n=================================================================");
            LinkedList list5 = new LinkedList();
            list5.Add(56);
            list5.Add(30);
            list5.Add(70);
            list5.DeleteFirstNode();
            list5.Display();

            //UC6 deleting last node of the linked list
            Console.WriteLine("\n=================================================================");
            LinkedList list6 = new LinkedList();
            list6.Add(56);
            list6.Add(30);
            list6.Add(70);
            list6.PopLast();
            list6.Display();

            //UC7 Searching for node
            Console.WriteLine("\n=================================================================");
            LinkedList list7 = new LinkedList();
            list7.Add(56);
            list7.Add(30);
            list7.Add(70);
            list7.SearchNode(30);
            //UC8 Insert after a particular value
            list7.InsertAfterNode(40, 30);
            Console.WriteLine("\n");
            list7.Display();
        }
    }
}
