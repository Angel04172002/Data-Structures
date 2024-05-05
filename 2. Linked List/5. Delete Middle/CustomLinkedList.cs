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

       
        public void DeleteMiddle()
        {
            int count = 0;

            Node temp = Head;

            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }

            int middle = count / 2;

            temp = Head;

            Node prev = null;

            for(int i = 0; i < middle; i++)
            {
                prev = temp;
                temp = temp.Next;
             
            }

            prev.Next = temp.Next;
            temp.Next = null;
            temp = null;

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
