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
            tree.Add(47);
            tree.Add(23);
            tree.Add(35);
            tree.Add(89);
            tree.Add(55);
            tree.Add(100);
            Console.ReadKey();
        }
    }
}
