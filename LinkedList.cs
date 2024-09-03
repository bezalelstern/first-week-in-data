using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace data_structures
{
    public class LinkedList
    {
        public Node head;

        public LinkedList(){}

        public LinkedList(int data)
        {
            head = new Node(data);
        }

        // Method to add to  the end of the list
        public void Add(int data)
        {
            if (head == null)
            {
                head = new Node(data);
            }
            else
            {
                Node toAdd = new Node(data);

                Node current = head;
                while (current.getnext() != null)
                {
                    current = current.getnext();
                }

                current.setnext(toAdd);
            }
        }


        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.getvalue());
                current = current.getnext();
            }
        }

        public int Length()
        {
            int counter = 0;
            Node current = head;
            while (current != null)
            {
                counter++;
                current = current.getnext();
            }
            return counter;
        }

        // Method to remove the first value
        public void RemoveValue(int data)
        {
            if (head == null) { return; }
            Node current = head;
            Node prev = null;
            while (current != null)
            {
                if (current.getvalue() == data)
                {

                    if (prev == null)
                    {
                        head = current.getnext();
                    }

                    else
                    {
                        prev.setnext(current.getnext());
                    }
                    current = current.getnext();
                }
                else
                {

                    prev = current;
                    current = current.getnext();
                    break;
                }
            }

        }

        // Method to remove all value
        public void RemoveAllValues(int data)
        {
            if (head == null) { return; }
            Node current = head;
            Node prev = null;
            while (current != null)
            {
                if (current.getvalue() == data)
                {

                    if (prev == null)
                    {
                        head = current.getnext();
                    }

                    else
                    {
                        prev.setnext(current.getnext());
                    }
                    current = current.getnext();
                }
                else
                {


                    prev = current;
                    current = current.getnext();
                }
            }
        }

        // Method to remove the value in an index
        public void RemoveIndex(int index)
        {
            int caounter = 0;
            Node current = head;
            while (current != null)
            {
                caounter++;
                if (caounter == index)
                {
                    RemoveValue(current.getvalue());
                    break;
                }
                current = current.getnext();
            }
        }

        // Method to find by value
        public Node Find(int data)
        {
            Node current = head;
            while (current != null)
            {
                if(current.getvalue() == data)
                    return current;
                current = current.getnext();
            }
            return null;
        }

        // Method to get a value by  index
        public int Get(int index)
        {
            int caounter = 0;
            Node current = head;
            while (current != null)
            {
                caounter++;
                if (caounter == index)
                {
                    return current.getvalue();
                }
                current = current.getnext();
            }
            return 0;
        }
    }
}
