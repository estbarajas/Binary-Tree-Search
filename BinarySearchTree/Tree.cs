using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Tree
    {
        Node Top;

        public Tree()
        {
            Top = null;
        }

        public Tree(int initial)
        {
            Top = new Node(initial);
        }

        public void AddRec(int value)
        {
            AddR(ref Top, value);
        }

        private void AddR(ref Node N, int value)
        {
            if (N == null)
            {
                Node NewNode = new Node(value);
                N = NewNode;
                return;
            }
            if (value < N.value)
            {
                AddR(ref N.left, value);
                return;
            }
            if (value >= N.value)
            {
                AddR(ref N.right, value);
                return;
            }
        }

        public void PrintInOrder(Node N, ref string s)
        {
            if (N == null){
                N = Top;
            }
            if (N.left != null)
            {
                PrintInOrder(N.left, ref s);
                s = s + N.value.ToString().PadLeft(3);
            }
            else
            {
                s = s + N.value.ToString().PadLeft(3);
            }
            if (N.right != null)
            {
                PrintInOrder(N.right, ref s);
            }
        }
    }
}
