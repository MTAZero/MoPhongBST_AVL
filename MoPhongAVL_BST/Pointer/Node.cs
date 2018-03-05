using MoPhongAVL_BST.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoPhongAVL_BST.Pointer
{
    public class Node
    {
        public Node Parent { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
        public Student Info { get; set; }
    }
}
