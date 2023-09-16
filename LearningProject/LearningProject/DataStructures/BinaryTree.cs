namespace LearningProject.DataStructures
{
    public class BinaryTree
    {
        private TreeNode root;

        public BinaryTree()
        {
            root = null;
        }

        public void InsertNode(int data)
        {
            root = InsertNode(root, data);
        }

        private TreeNode InsertNode(TreeNode root, int data)
        {
            if (root == null)
            {
                root = new TreeNode(data);
                return root;
            }

            if (data < root.Data)
            {
                root.Left = InsertNode(root.Left, data);
            }
            else if (data > root.Data)
            {
                root.Right = InsertNode(root.Right, data);
            }

            return root;
        }

        public void InorderTraversal()
        {
            InorderTraversal(root);
        }

        private void InorderTraversal(TreeNode node)
        {
            if (node != null)
            {
                InorderTraversal(node.Left);
                Console.Write(node.Data + " ");
                InorderTraversal(node.Right);
            }
        }

        public void PreOrderTraversal()
        {
            PreOrderTraversal(root);
        }

        private void PreOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                Console.Write(node.Data + " ");
                PreOrderTraversal(node.Left);
                PreOrderTraversal(node.Right);
            }
        }

        public void PostOrderTraversal()
        {
            PostOrderTraversal(root);
        }

        private void PostOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                PostOrderTraversal(node.Left);
                PostOrderTraversal(node.Right);
                Console.Write(node.Data + " ");
            }
        }
    }

    public class TreeNode
    {
        public int Data { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}
