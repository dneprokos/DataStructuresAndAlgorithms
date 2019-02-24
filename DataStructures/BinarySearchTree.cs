namespace ConsoleApp1.DataStructures
{
    public class BinarySearchTree
    {
        private Node root;

        public BinarySearchTree(Node root)
        {
            this.root = root;
        }

        public bool Contains(int value, Node node)
        {
            if (node.value == value)
            {
                return true;
            }

            if (node.lChild != null)
            {
                if (!Contains(value, node.lChild))
                {
                    if (node.rChild != null)
                    {
                        return Contains(value, node.rChild);
                    }
                }
                else
                {

                }
            }

            return false;
        }
    }

    public class Node
    {
        public int value;
        public Node lChild;
        public Node rChild;

        public Node(int value, Node lChild, Node rChild)
        {
            this.value = value;
            this.lChild = lChild;
            this.rChild = rChild;
        }

        public Node(int value)
        {
            this.value = value;
        }
    }
}
