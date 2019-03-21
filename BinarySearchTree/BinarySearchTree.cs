using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        // member methods
        Node root;
        Node current;
        public Node left;
        public Node right;

        // constructor
        public BinarySearchTree()
        {
            root = null;
        }

        // member variables
        public void Add(int info)
        {
            if (root == null)
            {
                Node newNode = new Node(info);
                root = newNode;
                current = root;
                return;
            }
            
            else
            {
                while (true)
                {
                    if (info <= current.info)
                    {
                        if (current.left == null)
                        {
                            Node newNode = new Node(info);
                            current.left = newNode;
                            break;
                        }
                        else
                        {
                            current = current.left;
                        }
                    }
                    else
                    {
                        if (current.right == null)
                        {
                            Node newNode = new Node(info);
                            current.right = newNode;
                            break;
                        }
                        else
                        {
                            current = current.right;
                        }
                    }
                }
            }
        }

        public bool Search(int find)
        {
            bool isFound = false;
            current = root;
            while (current != null && isFound == false)
            {
                if (current.info == find)
                {
                    isFound = true;
                }
                if (find <= current.info)
                {
                    if (current.left == null)
                    {
                        break;
                    }
                    else
                    {
                        current = current.left;
                    }
                }
                if (find > current.info)
                {
                    if (current.right == null)
                    {
                        break;
                    }
                    else
                    {
                        current = current.right;
                    }
                }
            }
            if (isFound == true)
            {
                Console.WriteLine("Found it.");
                return true;
            }
            else
            {
                Console.WriteLine("Did not find");
                return false;
            }
        }
    }
}
