using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class LinkedList
    {
        private Node Head;
        private Node Tail;
        private int size = 0;  // contains size of our LinkedList

        public void AddNode(int data)   // this adds node at start 
        {
            Node node=new Node(data);
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }
            size++;
            Console.WriteLine("Node is added");
        }

        public void AppendNode(int data)
        {
            Node node = new Node(data);

            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.next = node;
                Tail = node;
            }
            size++;
            Console.WriteLine("Node is added");
        }


        public void InsertNode(int data, int afterNum)
        {
            Node node=new Node(data);
            Node temp = Head;

            while (temp.data!=afterNum)
            {
                temp = temp.next;
            }

            node.next = temp.next;
            temp.next = node;
            size++;
            Console.WriteLine("Node {0} inserted after {1}",data,afterNum);

        }


        public void DeleteFirstNode()
        {
            int value = Head.data;
            Head = Head.next;

            if (Head == null)
                Tail = null;

            size--;
            Console.WriteLine("Node with data {0} is deleted", value);
        }

        public void DeleteLastNode()
        {
            Node temp = Head;
            Node current = null;  

            while (temp.next != null)
            {
                current = temp;
                temp = temp.next;
            }

            Tail = current;
            Tail.next = null;
            size--;
            Console.WriteLine("Last node deleted");
        }

        public void DeleteIntermediateNode(int data)
        {
            if (Head == null)
                Console.WriteLine("No element is present");

            else
            {
                Node temp = Head;

                while (temp != null)
                {
                    if (temp.next.data==data)
                    {
                        temp.next=temp.next.next;
                        Console.WriteLine("Node is deleted");
                        break;
                    }
                    temp=temp.next;
                }
                size--;
            }
        }

        public void DisplayNodes()
        {
            Node temp = Head;
            if (temp == null)
                Console.WriteLine("Linked list is empty");
            else
            {
                Console.WriteLine("Linked list contents");
                while (temp != null)
                {
                    Console.Write(temp.data);
                    if (temp.next != null)
                        Console.Write("->");
                    temp = temp.next;
                }

                Console.WriteLine();
                Console.WriteLine("LinkedList Size is: " + size);
            }
        }

    }
    }
