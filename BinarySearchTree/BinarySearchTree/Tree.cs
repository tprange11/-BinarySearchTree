using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Tree
    {
        // member variables
        Node head;
        Node current;

        // constructor
        public Tree()
        {

        }
        public Tree(int data)
        {
            head = new Node(data);
        }

        // member methods
        public void Add(int data)
        {
            Node toAdd = new Node(data);
            if (head == null)
            {
                head = toAdd;
                return;
            }
            current = head;
            current = Traverse(current, toAdd);

            if (current.data > toAdd.data)
            {
                current.left = toAdd;
            }

            else
            {
                current.right = toAdd;
            }
        }
        public Node Traverse(Node current, Node toAdd)
        {
            while (current != null)
            {
                if (current.data > toAdd.data && current.left != null)
                {
                    current = current.left;
                }

                else if (current.data <= toAdd.data && current.right != null)
                {
                    current = current.right;
                }

                else
                {
                    return current;
                }
            }
            return current;
        }
        public bool Search(int searchData)
        {
            current = head;
            while (current.left != null || current.right != null)
            {
                if (current.data == searchData)
                {
                   Console.WriteLine("Found: " + current.data);
                    Console.ReadLine();
                    return true;
                }

                else if (searchData < current.data)
                {
                    Console.WriteLine("Moved'Left'");
                    current = current.left;
                }

                else
                {
                    Console.WriteLine("Moved 'Right'");
                    current = current.right;
                }
            }

            if (current.data == searchData)
            {
                Console.WriteLine("Found: " + current.data);
                Console.ReadLine();
                return true;
            }

            else
            {
                Console.WriteLine("Value not found");
                return false;
            }

        }
       
    }
}
