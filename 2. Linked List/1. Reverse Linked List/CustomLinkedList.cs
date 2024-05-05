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

        public void ReverseList()
        {
            Node tempHead = Head;
            Node tempNode = Head.Next;
            tempHead.Next = null;

            while(tempNode != null)
            {
                Node nextNode = tempNode.Next;
                tempNode.Next = Head;
                Head = tempNode;
                tempNode = nextNode;
            }
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
