using System;
using System.Collections.Generic;
using System.Text;

namespace day15_binary_tree
{
    class Node
    {
        public int data;
        public Node LeftNode;
        public Node RightNode;

        public Node()
        {
            this.LeftNode = null;
            this.RightNode = null;
        }
    }
}
