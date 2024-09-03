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
                while (current.getNext() != null)
                {
                    current = current.getNext();
                }

                current.setNext(toAdd);
            }
        }

        //O(n)
        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.getValue());
                current = current.getNext();
            }
        }
        //O(n)
        public int Length()
        {
            int counter = 0;
            Node current = head;
            while (current != null)
            {
                counter++;
                current = current.getNext();
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
                if (current.getValue() == data)
                {

                    if (prev == null)
                    {
                        head = current.getNext();
                    }

                    else
                    {
                        prev.setNext(current.getNext());
                    }
                    current = current.getNext();
                }
                else
                {

                    prev = current;
                    current = current.getNext();
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
                if (current.getValue() == data)
                {

                    if (prev == null)
                    {
                        head = current.getNext();
                    }

                    else
                    {
                        prev.setNext(current.getNext());
                    }
                    current = current.getNext();
                }
                else
                {


                    prev = current;
                    current = current.getNext();
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
                    RemoveValue(current.getValue());
                    break;
                }
                current = current.getNext();
            }
        }

        // Method to find by value
        public Node Find(int data)
        {
            Node current = head;
            while (current != null)
            {
                if(current.getValue() == data)
                    return current;
                current = current.getNext();
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
                    return current.getValue();
                }
                current = current.getNext();
            }
            return 0;
        }
    }
}
