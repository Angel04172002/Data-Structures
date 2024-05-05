using LinkedListExercises;

namespace NthNode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList list = new CustomLinkedList();

            list.AddNode(new Node(1));
            list.AddNode(new Node(2));
            list.AddNode(new Node(3));
            list.AddNode(new Node(4));
    

            list.PrintNthNode(4);
        }
    }
}
