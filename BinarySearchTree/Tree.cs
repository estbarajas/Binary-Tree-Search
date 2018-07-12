using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Tree
    {
        Node root;
        public Tree()
        {
            root = null;
        }

        public Tree(int initial)
        {
            root = new Node(initial);
        }

        public void Search()
        {

        }

        public void Add(int value)
        {
            if (root == null)
            {
                Node newNode = new Node(value);
                root = newNode;
                return;
            }
            Node currentNode = root;
            bool added = false;
            do
            {//traverse tree
                if (value < currentNode.value)
                {
                    if (currentNode.left == null)
                    {
                        Node newNode = new Node(value);
                        currentNode.left = newNode;
                        added = true;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                    }                   
                }
                if (value >= currentNode.value)
                {
                    if (currentNode.right == null)
                    {
                        Node newNode = new Node(value);
                        currentNode.right = newNode;
                        added = true;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }

            } while (!added);
        }

        public void Print()
        {

        }
    }
}
