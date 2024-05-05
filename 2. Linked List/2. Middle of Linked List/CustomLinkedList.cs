using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExercises
{
    public class CustomLinkedList
    {
        public Node Head { get; set; }

        public void AddNode(Node node)
        {
            if(Head == null)
            {
                Head = node;
            }
            else
            {
                Node temp = Head;

                while(temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = node;
            }
        }

        public void PrintMiddle(Node head)
        {
            List<int> values = new List<int>();

            Node temp = Head;

            while(temp != null)
            {
                values.Add(temp.Value);
                temp = temp.Next;
            }

            int totalElements = values.Count;
            int middle = totalElements / 2;

            Console.WriteLine(values[middle]);

        }

        public void PrintList()
        {
            Node temp = Head;

            while (temp != null)
            {
                Console.Write(temp.Value + " ");
                temp = temp.Next;
            }
        }
    }
}
