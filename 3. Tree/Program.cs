using System.Xml.XPath;

namespace BinaryTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node<int> root = new Node<int>(10);

            Insert(root, 5);
            Insert(root, 6);
            Insert(root, 7);


            Node<int> root2 = new Node<int>(3);
            Insert(root2, 2);
            


            Console.WriteLine(CheckForSubtree(root, root2));


            //DeleteNode(root, 6);

            //int depth = MaxDepthRecursive(root);
            //Console.WriteLine(depth);

            //DFS(root);
        }

        public static Node<T> Insert<T>(Node<T> node, T item)
        {
            if (node == null)
            {
                node = new Node<T>(item);
                return node;
            }

            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                node = queue.Dequeue();

                if (node.Left == null)
                {
                    node.Left = new Node<T>(item);
                    return node;
                }

                if (node.Right == null)
                {
                    node.Right = new Node<T>(item);
                    return node;
                }

                queue.Enqueue(node.Left);
                queue.Enqueue(node.Right);
            }

            return node;
        }
        public static void DeleteDeepest<T>(Node<T> root, Node<T> nodeToRemove)
        {
            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();

                if (currentNode == nodeToRemove)
                {
                    currentNode = null;
                    return;
                }

                if(currentNode.Left != null && currentNode.Left == nodeToRemove)
                {
                    currentNode.Left = null;
                    return;
                }

                if(currentNode.Right != null && currentNode.Right == nodeToRemove)
                {
                    currentNode.Right = null;
                    return;
                }

                if(currentNode.Left !=null)
                {

                    queue.Enqueue(currentNode.Left);
                }

                if (currentNode.Right != null)
                {
                    queue.Enqueue(currentNode.Right);
                }
            }
        }
        public static void DeleteNode<T>(Node<T> root, T item)
        {
            Node<T> keyNode = null;
            Node<T> currentNode = null;

            Queue<Node<T>> queue = new Queue<Node<T>>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                currentNode = queue.Dequeue();

                if (currentNode.Value.Equals(item))
                {
                    keyNode = currentNode;
                }

                if(currentNode.Left != null)
                {
                    queue.Enqueue(currentNode.Left);
                }

                if (currentNode.Right != null)
                { 
                    queue.Enqueue(currentNode.Right);
                }
            }

            if(keyNode != null)
            {
                keyNode.Value = currentNode.Value;
                DeleteDeepest(root, currentNode);

            }

        }

        public static int MaxDepthRecursive<T>(Node<T> node)
        {
            if(node == null)
            {
                return 0;
            }

            int lDepth = MaxDepthRecursive(node.Left);
            int rDepth = MaxDepthRecursive(node.Right);  

            if(lDepth > rDepth)
            {
                return lDepth + 1;
            }
            else
            {
                return rDepth + 1;
            }

        }
        public static int MaxDepth<T>(Node<T> node)
        {
            int height = 0;

            Queue<Node<T>> queue = new Queue<Node<T>>();

            queue.Enqueue(node);

            while(queue.Count > 0)
            {
                int count = queue.Count;

                for (int i = 0; i < count; i++)
                {
                    var currentNode = queue.Dequeue();

                    if (currentNode.Left != null)
                    {
                        queue.Enqueue(currentNode.Left);
                    }

                    if (currentNode.Right != null)
                    {
                        queue.Enqueue(currentNode.Right);
                    }
                }


                height++;
            }

            return height;
        }

        public static bool CheckIdentical<T>(Node<T> root1, Node<T> root2)
        {
            if(root1 == null && root2 == null)
            {
                return true;
            }

            if(root1 == null && root2 != null || root1 != null && root2 == null)
            {
                return false;
            }


            bool result = CheckIdentical(root1.Left, root2.Left) && CheckIdentical(root1.Right, root2.Right);
            return result;
        }

        public static bool CheckForSubtree<T>(Node<T> root1, Node<T> root2)
        {
            if (root1 == null || root2 == null)
            {
                return false;
            }

            if(root1.Value.Equals(root2.Value))
            {
                root2 = root2.Left;
                return true;
            }


            bool result = false;
            

            if(CheckForSubtree(root1.Left, root2))
            {
                root1 = root1.Left;
                root2 = root2.Left;
                result = CheckForSubtree(root1.Left, root2);
            }

            else if (CheckForSubtree(root1.Right, root2))
            {
                root1 = root1.Right;
                root2 = root2.Right;
                result = CheckForSubtree(root1, root2);
            }


            return result;

        }

        public static void DFS<T>(Node<T> node)
        {
            Console.Write(node.Value + " ");

            DFS(node.Left);
            DFS(node.Right);
        }
    }
}
