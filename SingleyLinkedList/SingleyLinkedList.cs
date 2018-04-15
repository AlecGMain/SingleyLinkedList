using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleyLinkedList
{
    public class SingleyLinkedList<T>
    {
        Node<T> head;

        public SingleyLinkedList()
        {

        }

        public void AddFirst(T Value)
        {
            if (head == null)
            {
                head = new Node<T>(Value);
            }
            else
            {
                Node<T> newNode = new Node<T>(Value);
                newNode.Next = head;
                head = newNode;
            }
        }
        public void AddLast(T Value)
        {
            Node<T> tempNode = head;
            if (head == null)
            {
                head = new Node<T>(Value);
            }
            else
            {
                while (tempNode.Next != null)
                {
                    tempNode = tempNode.Next;
                }
                tempNode.Next = new Node<T>(Value);
            }
        }
        public void Remove(T Value)
        {
            if(head == null)
            {

            }
            else
            {
                while (current.Next != null)
                {
                    current = current.Next;
                }
            }
        }
    }
}
