using System;
using System.Collections.Generic;
using System.Text;

namespace Day15_BTS_UC2
{
    public class Node
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
