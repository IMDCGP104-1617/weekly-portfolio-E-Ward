using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lists
{
    class List<T> //T is the type of data stored in a perticular instance of List
    {
        public class Node // declare a class called node
        {
            public T Data; //Each node holds a value of type T
            public Node Next; //Each node has a reference to the next node in the list
        }

        private Node head; //Has a head variable to point to the start of the list
        private int count = 0; // Tells us where we are in the list and how big it is

        public T Head { get { return head.Data; } } // When the head is called it returns head.Data

        public List()
        {
            head = null; //Head is set to null
        }

        public void InsertBeginning(T data)
        {
            Node newNode = new Node(); // Creates a new node
            newNode.Data = data; // Places the data into the new node that was just created 
            if(head == null) // if the head is empty
            {
                head = newNode; //sets the node that was just created as the head
            }
            else
            {
                newNode.Next = head; // everything bumps to the right and the head becomes the new node
                head = newNode;
            }
            count++;
        }

        public T RemoveBeginning() { //Returns the value of T
            T ret = default(T);
            if(head != null)
            {
                ret = head.Data;
                if(head.Next == null) //Checks if the head is null
                {
                    head = null;
                }
                else // Makes the new node the head
                {
                    head = head.Next;
                }
            }
            count--;
            return ret;
        }

        public void InsertEnd(T data) //Returns the value of T
        {
            if (head == null)
            {
                InsertBeginning(data);
            }
            else
            {
                Node current = head;
                while(current.Next != null)
                {
                    current = current.Next;
                }
                Node newNode = new Node();
                newNode.Data = data;
                newNode.Next = null;
                current.Next = newNode;
            }
        }

        public T RemoveAfter(int count)
        {
            T ret = default(T);

            Node current = head;
            int counter = 0;

            while (current != null)
            {
                if(current.Next != null)
                {
                    ret = current.Next.Data;
                    current.Next = current.Next.Next;
                    counter--; //Takes 1 from the count
                }

                break;
            }

            current = current.Next;

            return ret; //Returns the value of ret

        }
    }
}
