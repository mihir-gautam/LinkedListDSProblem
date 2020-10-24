using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDSProblem
{
    public class LinkedList
    {
        internal Node head;
        public void Add(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        //UC2
        internal void AddBefore(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                node.next = null;
            }
            else
            {
                node.next = head;
            }
            head = node;
            Console.WriteLine("{0} added before the head on the list", node.data);
        }
        //UC4 inserting new node in between existing nodes
        internal Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position == 1)
            {
                Node newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        Console.WriteLine("{0} added successfully at position no. {1}", node.data, position);
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            return head;
        }
        public void DeleteFirstNode()
        {
            if (this.head == null)
            {
                Console.WriteLine("No nodes are there in the linked list");
            }
            this.head = head.next;
        }
        public void PopLast()
        {
            Node lastNode = head;
            while (lastNode.next.next != null)
            {
                lastNode = lastNode.next;

            }
            lastNode.next = null;
        }
        public Node SearchNode(int data)
        {

            Node foundNode = new Node(data);
            Node temp = head;
            while (temp.next != null)
            {
                if (foundNode.data == temp.data)
                {
                    Console.WriteLine("Node with value {0} found", foundNode.data);
                    return temp;
                }
                temp = temp.next;
            }
            return null;
        }
    }
}
