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


        public void DeleteNAfterM(int m, int n)
        {
            Node currentNode = Head;
            Node prevNode = null;

            while (currentNode != null)
            { 
                for (int i = 0; i < m && currentNode != null; i++)
                {
                    prevNode = currentNode;
                    currentNode = currentNode.Next;
                }

                for (int i = 0; i < n && prevNode != null && currentNode != null; i++)
                {
                    currentNode = currentNode.Next;
                    prevNode.Next = currentNode;
                }
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
