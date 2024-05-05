namespace DeleteNAfterM
{
    using LinkedListExercises;
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
            list.AddNode(new Node(60));
            list.AddNode(new Node(70));
            list.AddNode(new Node(80));
            list.AddNode(new Node(90));
            list.AddNode(new Node(100));



            list.DeleteNAfterM(2, 1);

            list.PrintList();

            Console.ReadLine();
        }
    }
}
