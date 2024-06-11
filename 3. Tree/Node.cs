using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node<T>
    {
        public Node(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
        public T Value { get; set; }

        public Node<T> Left { get; set; }

        public Node<T> Right { get; set; }
    }
}
