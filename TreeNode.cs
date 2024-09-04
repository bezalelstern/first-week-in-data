using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures
{
    internal class TreeNode
    {
       

        public int Value { get; set; }
        public TreeNode left { get; set; }
        public TreeNode right { get; set; }
        public TreeNode(int data) 
        {
            Value = data;
            left = null;
            right = null;
        }
    }
}
