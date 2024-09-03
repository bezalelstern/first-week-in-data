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

        public int getvalue() { return Value; }
        public Node getnext() { return Next; } 

        public void setvalue(int value) { Value = value; }
        public void setnext(Node next) { Next = next; }


        public Node(int data)
        {
            Value = data;
        }
    }
}
