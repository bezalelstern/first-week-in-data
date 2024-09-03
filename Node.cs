using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace data_structures
{
    public class Node
    {
        public int Value;

        public Node Next;

        public int getValue() { return Value; }
        public Node getNext() { return Next; } 

        public void setValue(int value) { Value = value; }
        public void setNext(Node next) { Next = next; }


        public Node(int data)
        {
            Value = data;
        }
    }
}
