using LinkedListExercises;

namespace DeleteMiddle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList list = new CustomLinkedList();

            list.AddNode(new Node(10));
            list.AddNode(new Node(20));
            list.AddNode(new Node(30));
            list.AddNode(new Node(40));
            list.AddNode(new Node(50));

            list.DeleteMiddle();

            list.PrintList();
        }
    }
}
