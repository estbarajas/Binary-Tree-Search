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

        }

        public void Print()
        {

        }
    }
}
