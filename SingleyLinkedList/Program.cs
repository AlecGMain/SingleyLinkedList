using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleyLinkedList
{
    class Program
    {
        /*
            1. Create an array called "checkNumbers" and a SinglyLinkedList<int>
            2. Add 10 randomly generated values to BOTH the array and the list
            3. In a separate loop, check that the values are the same in both array and the list, which will ensure the list is working
            4. Remove 3 values at random from the list
            5. Make sure the linked list still has 7 values, and is properly linked
             
         */

        static void Main(string[] args)
        {
            SingleyLinkedList<int> list = new SingleyLinkedList<int>();
            int[] checkNumbers = new int[10];
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int number = (r.Next(0, 101));
                list.AddLast(number);
                checkNumbers[i] = number;
                Console.Write("{0},", number);
            }

            bool correct = true;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != checkNumbers[i])
                {
                    correct = false;
                }
            }
            if (correct)
            {
                Console.WriteLine();
                Console.WriteLine("Works.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Dosen't work.");
            }
            
            for (int i = 0; i < 3; i++)
            {
                int index = r.Next(0, list.Count);
                list.RemoveAt(index);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write("{0},", list[i]);
            }

            //Node head = new Node(5); //jimmy
            //head.Next = new Node(7); //billy
            //head.Next.Next = new Node(4); //kimmy
            //head.Next.Next.Next = new Node(1); //jim
            //head.Next.Next.Next.Next = new Node(0); //pat


            //Node<T> current = head;

            //while (current.Next != null)
            //{
            //    current = current.Next;
            //}

            //current.Next = new Node(9); //bryan

            //head.Next.Next = head.Next.Next.Next;
            Console.ReadKey();
        }
    }
}
