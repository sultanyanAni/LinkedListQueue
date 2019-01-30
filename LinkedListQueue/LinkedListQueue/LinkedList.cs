using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListQueue
{
    class LinkedList<T>
    {
        int Count { get; set; }

        public Node<T> Head;
        public Node<T> Tail;



        public LinkedList()
        {

        }

        public bool isEmpty()
        {
            if (Head == null)
            {
                return true;
            }
            return false;
        }

        public IEnumerator<Node<T>> GetEnumerator()
        {
            Node<T> currentNode = Head;
            while (currentNode != null)
            {
                yield return currentNode;
                currentNode = currentNode.Next;
            }
        }

        public void AddFirst(T ItemToAdd)
        {
            Node<T> nodeToAdd = new Node<T>(ItemToAdd);
            if (isEmpty())
            {
                Head = nodeToAdd;
            }
            else
            {
                nodeToAdd.Next = Head;
                Head = nodeToAdd;

            }
            Count++;
        }

        public void AddLast(T itemToAdd)
        {
            Node<T> nodeToAdd = new Node<T>(itemToAdd);
            if (isEmpty())
            {
                Head = nodeToAdd;
            }
            else
            {
                Node<T> currentNode = Head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = nodeToAdd;
                Tail = currentNode.Next;

            }
            Count++;
        }

        public void AddBefore(Node<T> nodeToAddBefore, T itemToAdd)
        {

            if (isEmpty())
            {
                AddFirst(itemToAdd);
            }
            else
            {
                Node<T> currentNode = Head;
                while (currentNode.Next != nodeToAddBefore)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = new Node<T>(itemToAdd, nodeToAddBefore);
                Count++;
            }
        }

        public void AddAfter(Node<T> nodeToAddAfter, T itemToAdd)
        {
            if (isEmpty())
            {
                AddFirst(itemToAdd);
            }
            else
            {
                Node<T> currentNode = Head;
                while (currentNode != nodeToAddAfter)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = new Node<T>(itemToAdd, currentNode.Next);
                Count++;
            }

        }

        public bool RemoveFirst()
        {
            if (isEmpty())
            {
                return false;
            }
            else
            {
                Head = Head.Next;
                Count--;
                return true;
            }
        }

        public bool RemoveLast()
        {

            if (isEmpty())
            {
                return false;
            }
            else
            {
                if (Head.Next == null)
                {
                    Head = null;
                }
                else
                {
                    Node<T> currentNode = Head;
                    while (currentNode.Next.Next != null)
                    {
                        currentNode = currentNode.Next;
                    }
                    currentNode.Next = null;

                }
                Count--;
                return true;
            }
        }

        public bool Remove(T itemToRemove)
        {
            Node<T> currentNode = Head;
            if (currentNode.Value.Equals(itemToRemove))
            {
                Head = Head.Next;
                return true;
            }

            int count = 0;
            while (count < Count)
            {
                if(currentNode.Next != null && currentNode.Next.Value.Equals(itemToRemove))
                {

                }

                currentNode = currentNode.Next;
                count++;
            }

            return false;
        }
    }
}
