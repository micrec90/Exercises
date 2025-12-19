namespace LeetCode.Problems
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class BinaryTreeLevelOrderTraversalSolution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null)
                return new List<IList<int>>();
            IList<IList<int>> ret = new List<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int count = queue.Count;
                List<int> currentLevel = new List<int>();
                for (int i = 0; i < count; i++)
                {
                    TreeNode node = queue.Dequeue();
                    currentLevel.Add(node.val);
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if(node.right != null)
                        queue.Enqueue(node.right);
                }
                ret.Add(currentLevel);
            }
            return ret;
        }
    }
}
