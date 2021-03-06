﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleyLinkedList
{
    public class SingleyLinkedList<T> where T : IComparable<T>
    {
        public Node<T> head;
        public int Count { get; private set; }


        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }

                var curr = head;
                for (int i = 0; i < index; i++)
                {
                    curr = curr.Next;
                }

                return curr.Value;
            }
            set
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }

                var curr = head;
                for (int i = 0; i < index; i++)
                {
                    curr = curr.Next;
                }

                curr.Value = value;
            }
        }


        public SingleyLinkedList()
        {
            Count = 0;
        }

        public void AddFirst(T Value)
        {
            Count++;
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
            Count++;
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
                Count--;
                head = head.Next; //technically doesn't change the structure but since there is no way to reach the original head it is cleaned up by the garbage collecter
                return true;
            }
            if (exists != true)
            {
                return false;
            }

            else
            {
                Count--;
                Node<T> current = head;

                while (current.Next != null)
                {
                    if (current.Next.Value.CompareTo(Value) == 0)
                    {
                        current.Next = current.Next.Next;
                        return true;
                    }
                    current = current.Next; //does not change the structure
                }
                return false;

            }

        }
        public bool RemoveAt(int Index)
        {


            if (head == null)
            {
                return false;
            }

            if (Index == 0)
            {
                head = head.Next;
                Count--;
                return true;
            }
            else if (Index > 0)
            {
                //for loop to index before the index we want to remove and link around the index

                Node<T> current = head;
                for (int i = 0; i < Index - 1; i++)
                {
                    if (current.Next != null)
                    {
                        current = current.Next;
                    }
                    else
                    {
                        return false;
                    }
                }
                if (current.Next != null)
                {
                    current.Next = current.Next.Next;
                    Count--;
                    return true;
                }
                else
                {
                    return false;
                }

            }

            return false;
        }
        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Clear()
        {
            Count = 0;
            head = null;
        }
        public bool Contains(T Value)
        {
            bool contains = false;
            Node<T> current = head;
            if (head.Next == null)
            {
                if (head.Value.CompareTo(Value) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            while (current.Next != null)
            {
                if (current.Next.Value.CompareTo(Value) == 0)
                {
                    return true;
                }

                current = current.Next;
            }
            return contains;
        }
        public Node<T> Find(T Value)
        {
            if (head.Next == null)
            {
                if (head.Value.CompareTo(Value) == 0)
                {
                    return head;
                }
                else
                {
                    return null;
                }
            }
            Node<T> current = head;
            while (current.Next != null)
            {
                if (current.Next.Value.CompareTo(Value) == 0)
                {
                    return current;
                }

                current = current.Next;
            }
            return null;
        }


    }
}

