using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListQueue
{
    class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next;

   
        public Node(T ItemToAdd, Node<T> Next = null)
        {
            Value = ItemToAdd;
            this.Next = Next;
        }
    }
}
