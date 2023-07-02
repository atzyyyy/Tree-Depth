namespace TreeDepth
{
    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode MiddleChild { get; set; }
        public TreeNode RightChild { get; set; }

        public TreeNode(int val)
        {
            this.Value = val;
        }
    }

    public class Tree
    {
        private TreeNode root { get; set; }

        public void Insert(int value)
        {
            root = InsertItem(root, value);
        }

        public TreeNode InsertItem(TreeNode node, int val)
        {
            TreeNode newNode = new TreeNode(val);

            if (node == null)
            {
                node = newNode;
                return node;
            }

            if (val < node.Value)
            {
                node.LeftChild = InsertItem(node.LeftChild, val);
            }
            else if (val == node.Value)
            {
                node.MiddleChild = InsertItem(node.MiddleChild, val);
            }
            else
            {
                node.RightChild = InsertItem(node.RightChild, val);
            }

            return node;
        }

        int maxDepth(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                int leftDepth = maxDepth(node.LeftChild);
                int rightDepth = maxDepth(node.RightChild);
                int middleDepth = maxDepth(node.MiddleChild);

                return 1 + Math.Max(leftDepth, Math.Max(rightDepth, middleDepth));
            }
            
        }

        public static void Main()
        {
            Tree tree = new Tree();

            tree.Insert(15);
            tree.Insert(14);
            tree.Insert(13);
            tree.Insert(21);
            tree.Insert(17);
            tree.Insert(16);
            tree.Insert(21);
            tree.Insert(20);
            tree.Insert(22);
            tree.Insert(20);
            tree.Insert(34);
            
            Console.WriteLine("Height of the tree is: ");
            Console.Write(tree.maxDepth(tree.root));
        }
    }
    
    
}

