using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures
{
    internal class queue
    {
        public Node Head;
        public int Count { get; set; }
        public queue() { }

        public int getcount() { return Count; }

        public void enqueue(int data) 
        {
            Node node  = new Node(data);
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
            Count++;
        }

        public Node dequeue()
        {
            if (Head == null) 
            {
                return null;
            }
            Node ans = Head;
            Head = Head.Next;
            Count--;    
            return ans;
        }

        public int peek()
        {
            if(Head != null) 
           { return Head.Value; }
            return -1;

        }

        public string Display()
        {
            if (Head == null)
            {
                return "";
            }

            Node current = Head;
            string result = "";

            while (current != null)
            {
                result += current.getValue().ToString();
                if (current.getNext() != null)
                {
                    result += " -> ";
                }
                current = current.Next;
            }

            return result;
        }

        
    }
}
