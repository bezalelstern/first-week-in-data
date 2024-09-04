using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures
{
    internal class Stack
    {
        public int Counter;
        public Node Top;
        public Stack() { }

        public void push(int num) 
        {
            Node node = new Node(num);
            if (Top != null)
            {
                node.Next = Top;
                Top = node;
            }
            else {Top = node; }
            Counter++;
        }

        public int pop() 
        {
            if (Top != null)
            {
                Node ans = Top;
                Top = Top.Next;
                Counter--;
                return (ans.Value);
                
            }
            return -1;
        }

        public int peek()
        {
            if (Top != null)
            {
                return (Top.Value);
            }
            return -1;
        }
    }
}
