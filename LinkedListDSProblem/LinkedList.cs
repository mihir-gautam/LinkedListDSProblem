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
        public Node InsertAfterNode(int insertedValue, int previousValue)
        {
            Node temp = SearchNode(previousValue);
            if (temp != null)
            {
                Node node = new Node(insertedValue);
                node.next = temp.next;
                temp.next = node;
                Console.Write("Node {0} has been inserted after {1}", insertedValue, previousValue);
                return node;
            }
            else
            {
                Console.Write("Node could not be inserted");
                return null;
            }
        }
        public void DeleteNodeOfKey(int data)
        {
            Node key = SearchNode(data);
            Node temp = head;
            if (temp == null)
            {
                Console.Write("Node could not be found");
                return;
            }
            else
            {
                while (temp.next.data != key.data)
                {
                    temp = temp.next;
                }
                temp.next = key.next;
                key.next = null;
                Console.WriteLine("Data with value {0} has been deleted ", key.data);
            }
        }
        public int Size()
        {
            int size = 1;
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
            }
            while (temp.next != null)
            {
                size++;
                temp = temp.next;
            }
            Console.WriteLine("Size of the list is {0}", size);
            return size;
        }
    }
}
