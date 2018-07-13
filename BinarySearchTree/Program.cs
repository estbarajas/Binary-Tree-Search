using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.AddRec(10);
            tree.AddRec(8);
            tree.AddRec(14);

            string treeString = "";
            tree.PrintInOrder(null, ref treeString);           
            Console.WriteLine(treeString);

            tree.search(null, 14);

            Console.ReadLine();
        }
    }
}
