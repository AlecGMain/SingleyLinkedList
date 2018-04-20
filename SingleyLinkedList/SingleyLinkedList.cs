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
            bool exists = false;

            while (temp.Next != null)
            {
                if (temp.Value.CompareTo(Value) == 0)
                {
                    
                    exists = true;
                }

                temp = temp.Next;
            }

            if (head.Value.CompareTo(Value) == 0)
            {
                head = head.Next; //technically doesn't change the structure but since there is no way to reach the original head it is cleaned up by the garbage collecter
                return true;
            }
            if (exists != true)
            {
                return false;
            }

            else
            {
                Node<T> current = head;

                while (current.Next != null)
                {
                    if (current.Next.Value.CompareTo(Value) == 0)
                    {
                        current.Next = current.Next.Next;
                        head = current;//changes the structure
                        return true;
                    }
                    current = current.Next; //does not change the structure
                }
                return false;

            }

        }
        public void RemoveAt(int Index)
        {
            Node<T> current = head;
            for(int i = 0; i < Index; i++)
            {
                current = current.Next;
            }
        }
    }
}
