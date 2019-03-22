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

        // constructor
        public BinarySearchTree()
        {
            root = null;
        }

        // member variables
        public void Add(int info)
        {
            current = root;
            Node newNode = new Node(info);
            if (root == null)
            {
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
