using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleyLinkedList
{
    public class SingleyLinkedList<T> where T : IComparable<T>
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
        public bool Remove(T Value)
        {
            //add a check to see if the value is in the list before doing anything else...
            Node<T> temp = head;
            
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            if (head.Value.CompareTo(Value) == 0)
            {
                head = head.Next;
                return true;
            }
            else
            { 
          
                bool found = false;
                Node<T> current = head;
                while (current.Next.Value.CompareTo(Value) != 0)
                {

                    current = current.Next;
                }

            }
        }
    }
}
