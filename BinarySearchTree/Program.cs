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
            BinarySearchTree test = new BinarySearchTree();
            test.Add(10);
            test.Add(9);
            test.Add(8);
            test.Add(11);
            test.Add(2);
            test.Search(8);
        }
    }
}
