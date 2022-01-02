using System;

namespace day15_binary_tree
{
    class Program
    {
        //Ability to create a BST by adding 56 and then adding 30 & 70 - Use INode to create My Binary Node 
        static void Main(string[] args)
        {
            BinaryTree obj1 = new BinaryTree();
            obj1.Insert(56);
            obj1.Insert(30);
            obj1.Insert(70);
            obj1.TraversePreorder(obj1.root);
        }
    }
}
