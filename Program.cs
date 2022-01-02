using System;

namespace Day15_BTS_UC3
{
    class Program
    {
        //- Implement Search method and  recursively search left or right nodes to find 63
        static void Main(string[] args)
        {

            BinaryTree obj1 = new BinaryTree();
            obj1.Insert(56);
            obj1.Insert(30);
            obj1.Insert(70);
            obj1.Insert(63);
            obj1.TraversePreorder(obj1.root);
            Console.WriteLine();
            bool isFound = obj1.SearchBST(obj1.root, 63);
            Console.WriteLine("63 is found " + isFound);

        }
    }
}
