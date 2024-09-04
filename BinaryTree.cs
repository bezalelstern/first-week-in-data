using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures
{
    internal class BinaryTree
    {
        public TreeNode Root;
        public BinaryTree() { }

        public BinaryTree(int data)
        {
            this.Root = new TreeNode(data);
        }


        public void Insert(int data) 
        {
            Root = insertrec2(Root, data);
        }

        private TreeNode insertrec2(TreeNode node, int data)
        {
            if (node == null)
            {
                node = new TreeNode(data);
                return node;
            }

            if (data < node.Value)
            {
                node.left = insertrec2(node.left, data);
            }
            else
            {
                node.right = insertrec2(node.right, data);
            }
            return node;

        }

        public bool Find(int data)
        {
            bool result = Findrec(Root, data); 
            return result;
        }

        public bool Findrec(TreeNode node, int data)
        {
            if (node == null)
                return false;
            if (node.Value == data)
                return true;
            if (data < node.Value)
                return Findrec(node.left, data);
            else 
                return Findrec(node.right, data);
        }

        public int findmin()
        {
            if (Root == null)
            {
                return -1;
            }
            TreeNode current = Root;
            while (current.left != null)
            {
                current = current.left; 
            }
            return current.Value;
        }

        public int findmax()
        {
            if (Root == null)
            {
                return -1;
            }
            TreeNode current = Root;
            while (current.right != null)
            {
                current = current.right;
            }
            return current.Value;
        }

        public void print()
        {
            printrec(Root);
        }

        private void printrec(TreeNode root)
        {
            if (root != null)
            {
                printrec(root.left);
                Console.Write(root.Value + " ");
                printrec(root.right);
            }
        }
    }
}
